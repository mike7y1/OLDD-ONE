namespace InvokedServer.Forms
{
    partial class FrmAddWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddWord));
            this.MainKryptonPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.WordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SetTitleBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
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
            // WordTxt
            // 
            this.WordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WordTxt.Animated = true;
            this.WordTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.WordTxt.BorderRadius = 2;
            this.WordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WordTxt.DefaultText = "";
            this.WordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.WordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.WordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WordTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.WordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WordTxt.ForeColor = System.Drawing.Color.White;
            this.WordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WordTxt.Location = new System.Drawing.Point(12, 12);
            this.WordTxt.Name = "WordTxt";
            this.WordTxt.PlaceholderText = "[Enter Keyword]";
            this.WordTxt.SelectedText = "";
            this.WordTxt.Size = new System.Drawing.Size(283, 23);
            this.WordTxt.TabIndex = 37;
            // 
            // SetTitleBtn
            // 
            this.SetTitleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.SetTitleBtn.Image = global::InvokedServer.Properties.Resources.add;
            this.SetTitleBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.SetTitleBtn.Location = new System.Drawing.Point(12, 41);
            this.SetTitleBtn.Name = "SetTitleBtn";
            this.SetTitleBtn.Size = new System.Drawing.Size(283, 23);
            this.SetTitleBtn.TabIndex = 38;
            this.SetTitleBtn.Text = "Add";
            this.SetTitleBtn.Click += new System.EventHandler(this.SetTitleBtn_Click);
            // 
            // FrmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(307, 76);
            this.Controls.Add(this.WordTxt);
            this.Controls.Add(this.SetTitleBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddWord";
            this.Palette = this.MainKryptonPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.Text = "Add New Keyword";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette MainKryptonPalette;
        private Guna.UI2.WinForms.Guna2TextBox WordTxt;
        private Guna.UI2.WinForms.Guna2GradientButton SetTitleBtn;
    }
}