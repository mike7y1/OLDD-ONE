using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using InvokedServer.Properties;

namespace InvokedServer.Forms
{
    partial class FrmResetSurvival
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResetSurvival));
            this.FilePathBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.InstallBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FileTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LogsTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.logsVScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.PluginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilePathBtn
            // 
            this.FilePathBtn.Animated = true;
            this.FilePathBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.FilePathBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.FilePathBtn.BorderRadius = 2;
            this.FilePathBtn.BorderThickness = 1;
            this.FilePathBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilePathBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilePathBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilePathBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilePathBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilePathBtn.Enabled = false;
            this.FilePathBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FilePathBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.FilePathBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FilePathBtn.ForeColor = System.Drawing.Color.White;
            this.FilePathBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.FilePathBtn.Image = global::InvokedServer.Properties.Resources.inbox;
            this.FilePathBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.FilePathBtn.Location = new System.Drawing.Point(12, 12);
            this.FilePathBtn.Name = "FilePathBtn";
            this.FilePathBtn.Size = new System.Drawing.Size(93, 23);
            this.FilePathBtn.TabIndex = 31;
            this.FilePathBtn.Text = "Select File";
            this.FilePathBtn.Click += new System.EventHandler(this.ProgramsListBtn_Click);
            // 
            // InstallBtn
            // 
            this.InstallBtn.Animated = true;
            this.InstallBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.InstallBtn.BorderRadius = 2;
            this.InstallBtn.BorderThickness = 1;
            this.InstallBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InstallBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InstallBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InstallBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InstallBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InstallBtn.Enabled = false;
            this.InstallBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.InstallBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(35)))));
            this.InstallBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.InstallBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(0)))));
            this.InstallBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.InstallBtn.Location = new System.Drawing.Point(280, 69);
            this.InstallBtn.Name = "InstallBtn";
            this.InstallBtn.Size = new System.Drawing.Size(93, 23);
            this.InstallBtn.TabIndex = 32;
            this.InstallBtn.Text = "Install";
            this.InstallBtn.Click += new System.EventHandler(this.InstallBtn_Click);
            // 
            // FileTextbox
            // 
            this.FileTextbox.Animated = true;
            this.FileTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.FileTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileTextbox.DefaultText = "";
            this.FileTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileTextbox.Enabled = false;
            this.FileTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.FileTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(0)))));
            this.FileTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileTextbox.Location = new System.Drawing.Point(12, 41);
            this.FileTextbox.Name = "FileTextbox";
            this.FileTextbox.PlaceholderText = "Stub File Path";
            this.FileTextbox.ReadOnly = true;
            this.FileTextbox.SelectedText = "";
            this.FileTextbox.Size = new System.Drawing.Size(361, 22);
            this.FileTextbox.TabIndex = 33;
            this.FileTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogsTextbox
            // 
            this.LogsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.LogsTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.LogsTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogsTextbox.DefaultText = "";
            this.LogsTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LogsTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LogsTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LogsTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LogsTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.LogsTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LogsTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogsTextbox.ForeColor = System.Drawing.Color.White;
            this.LogsTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LogsTextbox.Location = new System.Drawing.Point(12, 104);
            this.LogsTextbox.Multiline = true;
            this.LogsTextbox.Name = "LogsTextbox";
            this.LogsTextbox.PlaceholderText = "Logs";
            this.LogsTextbox.ReadOnly = true;
            this.LogsTextbox.SelectedText = "";
            this.LogsTextbox.Size = new System.Drawing.Size(361, 161);
            this.LogsTextbox.TabIndex = 34;
            // 
            // logsVScrollBar
            // 
            this.logsVScrollBar.AutoSize = true;
            this.logsVScrollBar.BindingContainer = this.LogsTextbox;
            this.logsVScrollBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.logsVScrollBar.InUpdate = false;
            this.logsVScrollBar.LargeChange = 1;
            this.logsVScrollBar.Location = new System.Drawing.Point(346, 113);
            this.logsVScrollBar.Maximum = 1;
            this.logsVScrollBar.Name = "logsVScrollBar";
            this.logsVScrollBar.ScrollbarSize = 18;
            this.logsVScrollBar.Size = new System.Drawing.Size(18, 143);
            this.logsVScrollBar.TabIndex = 35;
            this.logsVScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.logsVScrollBar.ThumbSize = 5F;
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Image = global::InvokedServer.Properties.Resources.flag_yellow;
            this.statusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.Location = new System.Drawing.Point(9, 74);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(74, 18);
            this.statusLabel.TabIndex = 36;
            this.statusLabel.Text = "Stage:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PluginLabel
            // 
            this.PluginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginLabel.AutoSize = true;
            this.PluginLabel.BackColor = System.Drawing.Color.Black;
            this.PluginLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.PluginLabel.Location = new System.Drawing.Point(223, 12);
            this.PluginLabel.Name = "PluginLabel";
            this.PluginLabel.Size = new System.Drawing.Size(152, 13);
            this.PluginLabel.TabIndex = 43;
            this.PluginLabel.Text = "Checking if Module is loaded...";
            // 
            // FrmResetSurvival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(387, 278);
            this.Controls.Add(this.logsVScrollBar);
            this.Controls.Add(this.PluginLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.LogsTextbox);
            this.Controls.Add(this.FileTextbox);
            this.Controls.Add(this.InstallBtn);
            this.Controls.Add(this.FilePathBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmResetSurvival";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Survival";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmResetSurvival_FormClosing);
            this.Load += new System.EventHandler(this.FrmResetSurvival_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2GradientButton FilePathBtn;
        private Guna2GradientButton InstallBtn;
        private Guna2TextBox FileTextbox;
        private Guna2TextBox LogsTextbox;
        private Guna2VScrollBar logsVScrollBar;
        private Label statusLabel;
        private Label PluginLabel;
    }
}
