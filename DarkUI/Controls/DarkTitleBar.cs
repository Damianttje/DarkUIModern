using DarkUI.Forms;
using System;
using System.Windows.Forms;

namespace DarkUI.Controls
{
    public class DarkTitleBar : DarkToolStrip
    {
        #region Field Region
        DarkForm _form;

        private DarkToolStrip darkToolStrip1;
        private ToolStripLabel lbTitle;
        private ToolStripButton btnClose;
        private ToolStripButton btnMaximize;
        private ToolStripButton btnMinimize;
        #endregion

        public DarkTitleBar(DarkForm form, DarkTitleBarStyle titleBarStyle)
        {
            _form = form;

            darkToolStrip1 = this;

            InitializeComponent();

            form.Load += DarkDefaultTitleBar_Load;

            darkToolStrip1.MouseDown += _form.Drag;
            btnClose.Click += _form.Close_Click;

            if (titleBarStyle == DarkTitleBarStyle.Standard)
            {
                btnMaximize.Click += _form.Maximize_Click;
                btnMaximize.Visible = true;

                btnMinimize.Click += _form.Minimize_Click;
                btnMinimize.Visible = true;
            }
        }

        private void DarkDefaultTitleBar_Load(object sender, EventArgs e)
        {
            lbTitle.Text = _form.Text;
        }

        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager("DarkUI.Icons.DockIcons", typeof(DockIcons).Assembly);
            lbTitle = new ToolStripLabel();
            btnClose = new ToolStripButton();
            btnMaximize = new ToolStripButton();
            btnMinimize = new ToolStripButton();
            darkToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // darkToolStrip1
            // 
            darkToolStrip1.AutoSize = false;
            darkToolStrip1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            darkToolStrip1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            darkToolStrip1.Items.AddRange(lbTitle, btnClose, btnMaximize, btnMinimize );
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
            btnClose.Image = (System.Drawing.Image)resources.GetObject("Close_vs");
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
            btnMaximize.Image = (System.Drawing.Image)resources.GetObject("PlanePreview");
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
            btnMinimize.Image = (System.Drawing.Image)resources.GetObject("RemoveNoColor");
            btnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new System.Drawing.Size(23, 25);
            btnMinimize.Text = "toolStripButton3";
            btnMinimize.Visible = false;
            // 
            // DarkDefaultTitleBar
            // 
            Name = "DarkTitleBar";
            Size = new System.Drawing.Size(729, 28);
            darkToolStrip1.ResumeLayout(false);
            darkToolStrip1.PerformLayout();
            ResumeLayout(false);
        }
    }
}
