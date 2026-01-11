using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using InvokedServer.Properties;

namespace InvokedServer.Forms
{
    partial class FrmPlugins
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlugins));
            this.PluginsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FlagCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.StatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlugincontextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.btnInstall = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnGetLogs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DataGridFlagImageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PluginsDataGridView)).BeginInit();
            this.PlugincontextMenuStrip.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PluginsDataGridView
            // 
            this.PluginsDataGridView.AllowUserToAddRows = false;
            this.PluginsDataGridView.AllowUserToDeleteRows = false;
            this.PluginsDataGridView.AllowUserToOrderColumns = true;
            this.PluginsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PluginsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PluginsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PluginsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PluginsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PluginsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PluginsDataGridView.ColumnHeadersHeight = 20;
            this.PluginsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlagCol,
            this.StatusCol,
            this.NameCol,
            this.SizeCol});
            this.PluginsDataGridView.ContextMenuStrip = this.PlugincontextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PluginsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PluginsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PluginsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.PluginsDataGridView.Location = new System.Drawing.Point(0, 36);
            this.PluginsDataGridView.Name = "PluginsDataGridView";
            this.PluginsDataGridView.ReadOnly = true;
            this.PluginsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PluginsDataGridView.RowHeadersVisible = false;
            this.PluginsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PluginsDataGridView.Size = new System.Drawing.Size(467, 309);
            this.PluginsDataGridView.TabIndex = 7;
            this.PluginsDataGridView.TabStop = false;
            this.PluginsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.PluginsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PluginsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.PluginsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PluginsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PluginsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PluginsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.PluginsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.PluginsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PluginsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PluginsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PluginsDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.PluginsDataGridView.ThemeStyle.ReadOnly = true;
            this.PluginsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.PluginsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PluginsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.PluginsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.PluginsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.PluginsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PluginsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PluginsDataGridView_CellContentClick);
            this.PluginsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PluginsDataGridView_onMouseDown);
            // 
            // FlagCol
            // 
            this.FlagCol.FillWeight = 8F;
            this.FlagCol.HeaderText = "";
            this.FlagCol.Name = "FlagCol";
            this.FlagCol.ReadOnly = true;
            // 
            // StatusCol
            // 
            this.StatusCol.FillWeight = 50F;
            this.StatusCol.HeaderText = "Status";
            this.StatusCol.Name = "StatusCol";
            this.StatusCol.ReadOnly = true;
            // 
            // NameCol
            // 
            this.NameCol.FillWeight = 60F;
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            // 
            // SizeCol
            // 
            this.SizeCol.FillWeight = 30F;
            this.SizeCol.HeaderText = "Size";
            this.SizeCol.Name = "SizeCol";
            this.SizeCol.ReadOnly = true;
            // 
            // PlugincontextMenuStrip
            // 
            this.PlugincontextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.PlugincontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInstall});
            this.PlugincontextMenuStrip.Name = "hVNCContextMenuStrip";
            this.PlugincontextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.PlugincontextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.PlugincontextMenuStrip.RenderStyle.ColorTable = null;
            this.PlugincontextMenuStrip.RenderStyle.RoundedEdges = true;
            this.PlugincontextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.PlugincontextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PlugincontextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PlugincontextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.PlugincontextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.PlugincontextMenuStrip.Size = new System.Drawing.Size(106, 26);
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.Image = global::InvokedServer.Properties.Resources.package_go;
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(105, 22);
            this.btnInstall.Text = "Install";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelTop.Controls.Add(this.btnGetLogs);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(467, 36);
            this.panelTop.TabIndex = 12;
            // 
            // btnGetLogs
            // 
            this.btnGetLogs.Animated = true;
            this.btnGetLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnGetLogs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.btnGetLogs.BorderRadius = 2;
            this.btnGetLogs.BorderThickness = 1;
            this.btnGetLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetLogs.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetLogs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnGetLogs.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnGetLogs.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnGetLogs.ForeColor = System.Drawing.Color.White;
            this.btnGetLogs.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnGetLogs.Image = global::InvokedServer.Properties.Resources.refresh;
            this.btnGetLogs.ImageSize = new System.Drawing.Size(16, 16);
            this.btnGetLogs.Location = new System.Drawing.Point(12, 7);
            this.btnGetLogs.Name = "btnGetLogs";
            this.btnGetLogs.Size = new System.Drawing.Size(111, 23);
            this.btnGetLogs.TabIndex = 32;
            this.btnGetLogs.Text = "Refresh";
            this.btnGetLogs.Click += new System.EventHandler(this.btnGetLogs_Click);
            // 
            // DataGridFlagImageList
            // 
            this.DataGridFlagImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DataGridFlagImageList.ImageStream")));
            this.DataGridFlagImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DataGridFlagImageList.Images.SetKeyName(0, "tick.png");
            this.DataGridFlagImageList.Images.SetKeyName(1, "page_red.png");
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 320);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(467, 25);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusToolStripStatusLabel
            // 
            this.StatusToolStripStatusLabel.AutoSize = false;
            this.StatusToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusToolStripStatusLabel.Image = global::InvokedServer.Properties.Resources.flag_red;
            this.StatusToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusToolStripStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StatusToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
            this.StatusToolStripStatusLabel.Name = "StatusToolStripStatusLabel";
            this.StatusToolStripStatusLabel.Size = new System.Drawing.Size(300, 20);
            this.StatusToolStripStatusLabel.Text = "Status: Loading..";
            // 
            // FrmPlugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(467, 345);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.PluginsDataGridView);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(483, 384);
            this.Name = "FrmPlugins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPlugins_FormClosing);
            this.Load += new System.EventHandler(this.FrmPlugins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PluginsDataGridView)).EndInit();
            this.PlugincontextMenuStrip.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2DataGridView PluginsDataGridView;
        private Guna2GradientPanel panelTop;
        private Guna2GradientButton btnGetLogs;
        private ImageList DataGridFlagImageList;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel StatusToolStripStatusLabel;
        private DataGridViewImageColumn FlagCol;
        private DataGridViewTextBoxColumn StatusCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn SizeCol;
        private Guna2ContextMenuStrip PlugincontextMenuStrip;
        private ToolStripMenuItem btnInstall;
    }
}
