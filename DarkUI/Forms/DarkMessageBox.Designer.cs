using DarkUI.Controls;

namespace DarkUI.Forms
{
    partial class DarkMessageBox
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
            picIcon = new System.Windows.Forms.PictureBox();
            lblText = new DarkLabel();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(12, 12);
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(12, 12);
            // 
            // btnYes
            // 
            btnYes.Location = new System.Drawing.Point(12, 12);
            // 
            // btnNo
            // 
            btnNo.Location = new System.Drawing.Point(12, 12);
            // 
            // btnRetry
            // 
            btnRetry.Location = new System.Drawing.Point(452, 12);
            // 
            // btnIgnore
            // 
            btnIgnore.Location = new System.Drawing.Point(452, 12);
            // 
            // picIcon
            // 
            picIcon.Location = new System.Drawing.Point(17, 33);
            picIcon.Name = "picIcon";
            picIcon.Size = new System.Drawing.Size(39, 43);
            picIcon.TabIndex = 3;
            picIcon.TabStop = false;
            // 
            // lblText
            // 
            lblText.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lblText.Location = new System.Drawing.Point(75, 33);
            lblText.Name = "lblText";
            lblText.Size = new System.Drawing.Size(219, 61);
            lblText.TabIndex = 4;
            lblText.Text = "Something something something";
            // 
            // DarkMessageBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(308, 242);
            Controls.Add(lblText);
            Controls.Add(picIcon);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DarkMessageBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Message box";
            Controls.SetChildIndex(picIcon, 0);
            Controls.SetChildIndex(lblText, 0);
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private DarkLabel lblText;
    }
}