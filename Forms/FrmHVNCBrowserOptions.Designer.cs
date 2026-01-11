using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using InvokedServer.Properties;

namespace InvokedServer.Forms
{
    partial class FrmHVNCBrowserOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHVNCBrowserOptions));
            this.cbBrowsers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StartProgramBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CloneProfileCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBrowsers
            // 
            this.cbBrowsers.BackColor = System.Drawing.Color.Transparent;
            this.cbBrowsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.cbBrowsers.BorderRadius = 2;
            this.cbBrowsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBrowsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrowsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.cbBrowsers.FocusedColor = System.Drawing.Color.Empty;
            this.cbBrowsers.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbBrowsers.ForeColor = System.Drawing.Color.White;
            this.cbBrowsers.ItemHeight = 18;
            this.cbBrowsers.Items.AddRange(new object[] {
            "Chrome",
            "Firefox",
            "Edge",
            "Brave",
            "Opera",
            "OperaGX"});
            this.cbBrowsers.Location = new System.Drawing.Point(66, 71);
            this.cbBrowsers.Margin = new System.Windows.Forms.Padding(0);
            this.cbBrowsers.Name = "cbBrowsers";
            this.cbBrowsers.Size = new System.Drawing.Size(142, 24);
            this.cbBrowsers.TabIndex = 39;
            this.cbBrowsers.SelectedIndexChanged += new System.EventHandler(this.cbBrowsers_SelectedIndexChanged);
            // 
            // StartProgramBtn
            // 
            this.StartProgramBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartProgramBtn.Animated = true;
            this.StartProgramBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StartProgramBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.StartProgramBtn.BorderRadius = 2;
            this.StartProgramBtn.BorderThickness = 1;
            this.StartProgramBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartProgramBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartProgramBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartProgramBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartProgramBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartProgramBtn.Enabled = false;
            this.StartProgramBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.StartProgramBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.StartProgramBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StartProgramBtn.ForeColor = System.Drawing.Color.White;
            this.StartProgramBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.StartProgramBtn.Image = global::InvokedServer.Properties.Resources.HiddenProgram_161;
            this.StartProgramBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.StartProgramBtn.Location = new System.Drawing.Point(241, 72);
            this.StartProgramBtn.Name = "StartProgramBtn";
            this.StartProgramBtn.Size = new System.Drawing.Size(63, 23);
            this.StartProgramBtn.TabIndex = 40;
            this.StartProgramBtn.Text = "Start";
            this.StartProgramBtn.Click += new System.EventHandler(this.StartProgramBtn_Click);
            // 
            // CloneProfileCheckBox
            // 
            this.CloneProfileCheckBox.Animated = true;
            this.CloneProfileCheckBox.AutoSize = true;
            this.CloneProfileCheckBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.CloneProfileCheckBox.Checked = true;
            this.CloneProfileCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CloneProfileCheckBox.CheckedState.BorderRadius = 0;
            this.CloneProfileCheckBox.CheckedState.BorderThickness = 0;
            this.CloneProfileCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloneProfileCheckBox.CheckMarkColor = System.Drawing.Color.Black;
            this.CloneProfileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CloneProfileCheckBox.ForeColor = System.Drawing.Color.White;
            this.CloneProfileCheckBox.Location = new System.Drawing.Point(81, 35);
            this.CloneProfileCheckBox.Name = "CloneProfileCheckBox";
            this.CloneProfileCheckBox.Size = new System.Drawing.Size(85, 17);
            this.CloneProfileCheckBox.TabIndex = 41;
            this.CloneProfileCheckBox.Text = "Clone Profile";
            this.CloneProfileCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CloneProfileCheckBox.UncheckedState.BorderRadius = 0;
            this.CloneProfileCheckBox.UncheckedState.BorderThickness = 0;
            this.CloneProfileCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 42;
            // 
            // FrmHVNCBrowserOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(415, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloneProfileCheckBox);
            this.Controls.Add(this.StartProgramBtn);
            this.Controls.Add(this.cbBrowsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHVNCBrowserOptions";
            this.Text = "FrmHVNCBrowserOptions";
            this.Load += new System.EventHandler(this.FrmHVNCBrowserOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2ComboBox cbBrowsers;
        private Guna2GradientButton StartProgramBtn;
        private Guna2CheckBox CloneProfileCheckBox;
        private Label label1;
    }
}
