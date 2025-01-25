using DarkUI.Controls;
using DarkUI.Docking;

namespace Example
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolMain = new DarkToolStrip();
            lbTitle = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            mnuView = new System.Windows.Forms.ToolStripMenuItem();
            mnuDialog = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            mnuProperties = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsole = new System.Windows.Forms.ToolStripMenuItem();
            mnuLayers = new System.Windows.Forms.ToolStripMenuItem();
            mnuHistory = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            btnClose = new System.Windows.Forms.ToolStripButton();
            btnMaximize = new System.Windows.Forms.ToolStripButton();
            btnMinimize = new System.Windows.Forms.ToolStripButton();
            toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            stripMain = new DarkStatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            DockPanel = new DarkDockPanel();
            toolMain.SuspendLayout();
            stripMain.SuspendLayout();
            SuspendLayout();
            // 
            // toolMain
            // 
            toolMain.AutoSize = false;
            toolMain.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolMain.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbTitle, toolStripSeparator3, mnuFile, mnuView, toolStripMenuItem1, toolStripMenuItem8, toolStripSeparator4, btnClose, btnMaximize, btnMinimize, toolStripMenuItem6 });
            toolMain.Location = new System.Drawing.Point(2, 2);
            toolMain.Name = "toolMain";
            toolMain.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            toolMain.Size = new System.Drawing.Size(1228, 28);
            toolMain.TabIndex = 1;
            toolMain.Text = "darkToolStrip1";
            // 
            // lbTitle
            // 
            lbTitle.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            lbTitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(74, 25);
            lbTitle.Text = "DarkUI - Test";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // mnuFile
            // 
            mnuFile.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuNewFile, toolStripSeparator1, mnuClose });
            mnuFile.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 28);
            mnuFile.Text = "&File";
            // 
            // mnuNewFile
            // 
            mnuNewFile.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuNewFile.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuNewFile.Image = Icons.NewFile_6276;
            mnuNewFile.Name = "mnuNewFile";
            mnuNewFile.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            mnuNewFile.Size = new System.Drawing.Size(180, 22);
            mnuNewFile.Text = "&New file";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuClose
            // 
            mnuClose.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuClose.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuClose.Image = Icons.Close_16xLG;
            mnuClose.Name = "mnuClose";
            mnuClose.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            mnuClose.Size = new System.Drawing.Size(180, 22);
            mnuClose.Text = "&Close";
            // 
            // mnuView
            // 
            mnuView.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuDialog });
            mnuView.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuView.Name = "mnuView";
            mnuView.Size = new System.Drawing.Size(44, 28);
            mnuView.Text = "&View";
            // 
            // mnuDialog
            // 
            mnuDialog.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuDialog.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuDialog.Image = Icons.properties_16xLG;
            mnuDialog.Name = "mnuDialog";
            mnuDialog.Size = new System.Drawing.Size(180, 22);
            mnuDialog.Text = "&Dialog test";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripSeparator5, toolStripMenuItem4, toolStripMenuItem5 });
            toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(47, 28);
            toolStripMenuItem1.Text = "&Tools";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuItem2.CheckOnClick = true;
            toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            toolStripMenuItem2.Text = "Checkable";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuItem3.CheckOnClick = true;
            toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuItem3.Image = Icons.properties_16xLG;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            toolStripMenuItem3.Text = "Checkable with icon";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuItem4.Checked = true;
            toolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked;
            toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(181, 22);
            toolStripMenuItem4.Text = "Checked";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuItem5.Checked = true;
            toolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuItem5.Image = Icons.properties_16xLG;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new System.Drawing.Size(181, 22);
            toolStripMenuItem5.Text = "Checked with icon";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuProject, mnuProperties, mnuConsole, mnuLayers, mnuHistory });
            toolStripMenuItem8.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new System.Drawing.Size(63, 28);
            toolStripMenuItem8.Text = "&Window";
            // 
            // mnuProject
            // 
            mnuProject.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuProject.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuProject.Image = Icons.application_16x;
            mnuProject.Name = "mnuProject";
            mnuProject.Size = new System.Drawing.Size(180, 22);
            mnuProject.Text = "&Project Explorer";
            // 
            // mnuProperties
            // 
            mnuProperties.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuProperties.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuProperties.Image = Icons.properties_16xLG;
            mnuProperties.Name = "mnuProperties";
            mnuProperties.Size = new System.Drawing.Size(180, 22);
            mnuProperties.Text = "P&roperties";
            // 
            // mnuConsole
            // 
            mnuConsole.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuConsole.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuConsole.Image = Icons.Console;
            mnuConsole.Name = "mnuConsole";
            mnuConsole.Size = new System.Drawing.Size(180, 22);
            mnuConsole.Text = "&Console";
            // 
            // mnuLayers
            // 
            mnuLayers.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuLayers.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuLayers.Image = Icons.Collection_16xLG;
            mnuLayers.Name = "mnuLayers";
            mnuLayers.Size = new System.Drawing.Size(180, 22);
            mnuLayers.Text = "&Layers";
            // 
            // mnuHistory
            // 
            mnuHistory.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuHistory.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuHistory.Image = (System.Drawing.Image)resources.GetObject("mnuHistory.Image");
            mnuHistory.Name = "mnuHistory";
            mnuHistory.Size = new System.Drawing.Size(180, 22);
            mnuHistory.Text = "&History";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // btnClose
            // 
            btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnClose.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnClose.Image = Properties.Resources.Close_vs;
            btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(23, 25);
            btnClose.Text = "toolStripButton2";
            // 
            // btnMaximize
            // 
            btnMaximize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnMaximize.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            btnMaximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnMaximize.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnMaximize.Image = Properties.Resources.PlanePreview;
            btnMaximize.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new System.Drawing.Size(23, 25);
            btnMaximize.Text = "toolStripButton3";
            // 
            // btnMinimize
            // 
            btnMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnMinimize.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            btnMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnMinimize.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnMinimize.Image = Properties.Resources.RemoveNoColor;
            btnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new System.Drawing.Size(23, 25);
            btnMinimize.Text = "toolStripButton4";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuAbout });
            toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new System.Drawing.Size(44, 28);
            toolStripMenuItem6.Text = "&Help";
            // 
            // mnuAbout
            // 
            mnuAbout.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            mnuAbout.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            mnuAbout.Image = Icons.StatusAnnotations_Information_16xLG_color;
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new System.Drawing.Size(180, 22);
            mnuAbout.Text = "&About DarkUI";
            // 
            // stripMain
            // 
            stripMain.AutoSize = false;
            stripMain.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            stripMain.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel6, toolStripStatusLabel5 });
            stripMain.Location = new System.Drawing.Point(2, 1194);
            stripMain.Name = "stripMain";
            stripMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            stripMain.Size = new System.Drawing.Size(1228, 24);
            stripMain.SizingGrip = false;
            stripMain.TabIndex = 2;
            stripMain.Text = "darkStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 50, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(39, 16);
            toolStripStatusLabel1.Text = "Ready";
            toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Margin = new System.Windows.Forms.Padding(0, 0, 50, 2);
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new System.Drawing.Size(1041, 14);
            toolStripStatusLabel6.Spring = true;
            toolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new System.Drawing.Size(46, 16);
            toolStripStatusLabel5.Text = "120 MB";
            toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DockPanel
            // 
            DockPanel.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            DockPanel.HostFormText = "";
            DockPanel.Location = new System.Drawing.Point(2, 30);
            DockPanel.Name = "DockPanel";
            DockPanel.Size = new System.Drawing.Size(1228, 1164);
            DockPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1232, 1220);
            Controls.Add(DockPanel);
            Controls.Add(stripMain);
            Controls.Add(toolMain);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(640, 480);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dark UI - Example";
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            stripMain.ResumeLayout(false);
            stripMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DarkToolStrip toolMain;
        private DarkStatusStrip stripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private DarkDockPanel DockPanel;
        private System.Windows.Forms.ToolStripLabel lbTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnMaximize;
        private System.Windows.Forms.ToolStripButton btnMinimize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuConsole;
        private System.Windows.Forms.ToolStripMenuItem mnuLayers;
        private System.Windows.Forms.ToolStripMenuItem mnuHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuDialog;
    }
}

