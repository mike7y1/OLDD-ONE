using InvokedServer.Models;
using InvokedServer.Networking;
using InvokedServer.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Net.Sockets;
using System.Windows.Forms;


namespace InvokedServer.Forms
{
    public partial class FrmSettings : Form
    {

        private FrmMain frmMain;
        private readonly HannibalServer _listenServer;

        public FrmSettings(HannibalServer listenServer, FrmMain frmMain)
        {
            this._listenServer = listenServer;
            this.frmMain = frmMain;  // Assign the FrmMain instance
            this.InitializeComponent();
            this.ToggleListenerSettings(!listenServer.Listening);
            this.ShowPassword(false);
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            frmMain.ncPort.Value = (Decimal)Settings.ListenPort;
            frmMain.chkIPv6Support.Checked = Settings.IPv6Support;
            frmMain.chkAutoListen.Checked = Settings.AutoListen;
            frmMain.chkPopup.Checked = Settings.ShowPopup;
            frmMain.chkUseUpnp.Checked = Settings.UseUPnP;
            frmMain.chkShowTooltip.Checked = Settings.ShowToolTip;
            frmMain.chkNoIPIntegration.Checked = Settings.EnableNoIPUpdater;
            frmMain.txtNoIPHost.Text = Settings.NoIPHost;
            frmMain.txtNoIPUser.Text = Settings.NoIPUsername;
            frmMain.txtNoIPPass.Text = Settings.NoIPPassword;
        }

        private ushort GetPortSafe()
        {
            ushort result;
            return ushort.TryParse(frmMain.ncPort.Value.ToString((IFormatProvider)CultureInfo.InvariantCulture), out result) ? result : (ushort)0;
        }

        public void btnListen_Click(object sender, EventArgs e)
        {
            ushort portSafe = this.GetPortSafe();
            if (portSafe == (ushort)0)
            {
                int num1 = (int)MessageBox.Show("Please enter a valid port > 0.", "Please enter a valid port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (frmMain.btnListen.Text == "Start listening")
                {
                    if (!this._listenServer.Listening)
                    {
                        try
                        {
                            if (this.chkNoIPIntegration.Checked)
                                NoIpUpdater.Start();
                            this._listenServer.Listen(portSafe, frmMain.chkIPv6Support.Checked, frmMain.chkUseUpnp.Checked);
                            this.ToggleListenerSettings(false);
                            return;
                        }
                        catch (SocketException ex)
                        {
                            if (ex.ErrorCode == 10048)
                            {
                                int num2 = (int)MessageBox.Show((IWin32Window)this, "The port is already in use.", "Socket Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else
                            {
                                int num3 = (int)MessageBox.Show((IWin32Window)this, string.Format("An unexpected socket error occurred: {0}\n\nError Code: {1}\n\n", (object)ex.Message, (object)ex.ErrorCode), "Unexpected Socket Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            this._listenServer.Disconnect();
                            return;
                        }
                        catch
                        {
                            this._listenServer.Disconnect();
                            return;
                        }
                    }
                }
                if (!(frmMain.btnListen.Text == "Stop listening") || !this._listenServer.Listening)
                    return;
                this._listenServer.Disconnect();
                this.ToggleListenerSettings(true);
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            ushort portSafe = this.GetPortSafe();
            if (portSafe == (ushort)0)
            {
                int num = (int)MessageBox.Show("Please enter a valid port > 0.", "Please enter a valid port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Settings.ListenPort = portSafe;
                Settings.IPv6Support = frmMain.chkIPv6Support.Checked;
                Settings.AutoListen = frmMain.chkAutoListen.Checked;
                Settings.ShowPopup = frmMain.chkPopup.Checked;
                Settings.UseUPnP = frmMain.chkUseUpnp.Checked;
                Settings.ShowToolTip = frmMain.chkShowTooltip.Checked;
                Settings.EnableNoIPUpdater = frmMain.chkNoIPIntegration.Checked;
                Settings.NoIPHost = frmMain.txtNoIPHost.Text;
                Settings.NoIPUsername = frmMain.txtNoIPUser.Text;
                Settings.NoIPPassword = frmMain.txtNoIPPass.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Discard your changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.Close();
        }

        public void chkNoIPIntegration_CheckedChanged(object sender, EventArgs e)
        {
            this.NoIPControlHandler(frmMain.chkNoIPIntegration.Checked);
        }

        private void ToggleListenerSettings(bool enabled)
        {
            frmMain.btnListen.Text = enabled ? "Start listening" : "Stop listening";
            frmMain.ncPort.Enabled = enabled;
            frmMain.chkIPv6Support.Enabled = enabled;
            frmMain.chkUseUpnp.Enabled = enabled;
        }

        private void NoIPControlHandler(bool enable)
        {
            frmMain.txtNoIPHost.Enabled = enable;
            frmMain.txtNoIPUser.Enabled = enable;
            frmMain.txtNoIPPass.Enabled = enable;
            frmMain.chkShowPassword.Enabled = enable;
        }

        private void ShowPassword(bool show = true)
        {
            frmMain.txtNoIPPass.PasswordChar = show ? char.MinValue : '●';
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowPassword(frmMain.chkShowPassword.Checked);
        }
    }
}