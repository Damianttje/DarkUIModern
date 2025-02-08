namespace DarkUI.Forms
{
    partial class DarkToastForm
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            pbIcon = new System.Windows.Forms.PictureBox();
            messagePanel = new System.Windows.Forms.Panel();
            animTimer = new System.Windows.Forms.Timer(components);
            durtionTimer = new System.Windows.Forms.Timer(components);
            loadingPanel = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            lbClose = new Controls.DarkLabel();
            lbTitle = new Controls.DarkLabel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.73913F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.26087F));
            tableLayoutPanel2.Controls.Add(pbIcon, 0, 0);
            tableLayoutPanel2.Controls.Add(messagePanel, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(2, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(492, 300);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // pbIcon
            // 
            pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            pbIcon.Location = new System.Drawing.Point(13, 13);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new System.Drawing.Size(73, 274);
            pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pbIcon.TabIndex = 1;
            pbIcon.TabStop = false;
            // 
            // messagePanel
            // 
            messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            messagePanel.Location = new System.Drawing.Point(92, 13);
            messagePanel.Name = "messagePanel";
            messagePanel.Size = new System.Drawing.Size(387, 274);
            messagePanel.TabIndex = 2;
            // 
            // animTimer
            // 
            animTimer.Tick += Animation;
            // 
            // durtionTimer
            // 
            durtionTimer.Tick += Duration;
            // 
            // loadingPanel
            // 
            loadingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            loadingPanel.Location = new System.Drawing.Point(2, 328);
            loadingPanel.Name = "loadingPanel";
            loadingPanel.Size = new System.Drawing.Size(492, 4);
            loadingPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTitle);
            panel1.Controls.Add(lbClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(492, 26);
            panel1.TabIndex = 0;
            // 
            // lbClose
            // 
            lbClose.Dock = System.Windows.Forms.DockStyle.Right;
            lbClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbClose.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbClose.Location = new System.Drawing.Point(468, 0);
            lbClose.Name = "lbClose";
            lbClose.Size = new System.Drawing.Size(24, 25);
            lbClose.TabIndex = 0;
            lbClose.Text = "X";
            lbClose.Click += lbClose_Click;
            // 
            // lbTitle
            // 
            lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbTitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbTitle.Location = new System.Drawing.Point(0, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(87, 21);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "darkLabel2";
            // 
            // DarkToastForm
            // 
            AllowMoving = false;
            AllowResize = false;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(496, 334);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(loadingPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "DarkToastForm";
            Text = "DarkToastForm";
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer animTimer;
        private System.Windows.Forms.Timer durtionTimer;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Panel panel1;
        private Controls.DarkLabel lbTitle;
        private Controls.DarkLabel lbClose;
    }
}