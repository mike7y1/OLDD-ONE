using ComponentFactory.Krypton.Toolkit;
using InvokedCommon.DNS;
using InvokedServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvokedServer.Forms
{
    public partial class FrmAssembly : KryptonForm
    {
        private bool _profileLoaded;
        private bool _changed;
        private readonly BindingList<Host> _hosts = new BindingList<Host>();
        private readonly HostsConverter _hostsConverter = new HostsConverter();
        public FrmAssembly()
        {
            InitializeComponent();
        }

        private void HasChanged()
        {
            if (!_changed && _profileLoaded)
                _changed = true;
        }

        private void FrmAssembly_Load(object sender, EventArgs e)
        {
            LoadProfile("Default");
        }

        private void LoadProfile(string profileName)
        {
            var builderProfile = new BuilderProfile(profileName);
            _hosts.Clear();

            foreach (var host in _hostsConverter.RawHostsToList(builderProfile.Hosts))
                _hosts.Add(host);

            // Icon Settings
            chkChangeIcon.Checked = builderProfile.ChangeIcon;
            txtIconPath.Text = builderProfile.IconPath;

            // Assembly Settings
            chkChangeIcon.Checked = builderProfile.ChangeAsmInfo;
            txtProductName.Text = builderProfile.ProductName;
            txtDescription.Text = builderProfile.Description;
            txtCompanyName.Text = builderProfile.CompanyName;
            txtCopyright.Text = builderProfile.Copyright;
            txtTrademarks.Text = builderProfile.Trademarks;
            txtOriginalFilename.Text = builderProfile.OriginalFilename;
            txtProductVersion.Text = builderProfile.ProductVersion;
            txtFileVersion.Text = builderProfile.FileVersion;

            _profileLoaded = true;
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Icon";
                openFileDialog.Filter = "Icons *.ico|*.ico";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIconPath.Text = openFileDialog.FileName;
                    iconPreview.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(64, 64)).Handle);
                }
            }
        }
    }
}
