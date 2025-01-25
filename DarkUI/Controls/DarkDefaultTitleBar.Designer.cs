namespace DarkUI.Controls
{
    partial class DarkDefaultTitleBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DarkDefaultTitleBar));
            darkToolStrip1 = new DarkToolStrip();
            lbTitle = new System.Windows.Forms.ToolStripLabel();
            btnClose = new System.Windows.Forms.ToolStripButton();
            btnMaximize = new System.Windows.Forms.ToolStripButton();
            btnMinimize = new System.Windows.Forms.ToolStripButton();
            darkToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // darkToolStrip1
            // 
            darkToolStrip1.AutoSize = false;
            darkToolStrip1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            darkToolStrip1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            darkToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbTitle, btnClose, btnMaximize, btnMinimize });
            darkToolStrip1.Location = new System.Drawing.Point(0, 0);
            darkToolStrip1.Name = "darkToolStrip1";
            darkToolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            darkToolStrip1.Size = new System.Drawing.Size(729, 28);
            darkToolStrip1.TabIndex = 0;
            darkToolStrip1.Text = "darkToolStrip1";
            // 
            // lbTitle
            // 
            lbTitle.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            lbTitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(52, 25);
            lbTitle.Text = "<TITLE>";
            // 
            // btnClose
            // 
            btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnClose.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(23, 25);
            btnClose.Text = "toolStripButton1";
            // 
            // btnMaximize
            // 
            btnMaximize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnMaximize.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            btnMaximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnMaximize.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnMaximize.Image = (System.Drawing.Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new System.Drawing.Size(23, 25);
            btnMaximize.Text = "toolStripButton2";
            btnMaximize.Visible = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnMinimize.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            btnMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnMinimize.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new System.Drawing.Size(23, 25);
            btnMinimize.Text = "toolStripButton3";
            btnMinimize.Visible = false;
            // 
            // DarkDefaultTitleBar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(darkToolStrip1);
            Name = "DarkDefaultTitleBar";
            Size = new System.Drawing.Size(729, 28);
            Load += DarkDefaultTitleBar_Load;
            darkToolStrip1.ResumeLayout(false);
            darkToolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DarkToolStrip darkToolStrip1;
        private System.Windows.Forms.ToolStripLabel lbTitle;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnMaximize;
        private System.Windows.Forms.ToolStripButton btnMinimize;
    }
}
