using DarkUI.Controls;

namespace Example
{
    partial class DialogControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogControls));
            pnlMain = new System.Windows.Forms.Panel();
            tblMain = new System.Windows.Forms.TableLayoutPanel();
            pnlTreeView = new DarkSectionPanel();
            treeTest = new DarkTreeView();
            pnlListView = new DarkSectionPanel();
            lstTest = new DarkListView();
            pnlMessageBox = new DarkSectionPanel();
            panel1 = new System.Windows.Forms.Panel();
            darkGroupBox1 = new DarkGroupBox();
            darkRadioButton4 = new DarkRadioButton();
            darkCheckBox3 = new DarkCheckBox();
            panel7 = new System.Windows.Forms.Panel();
            darkComboBox1 = new DarkComboBox();
            darkTitle4 = new DarkTitle();
            panel6 = new System.Windows.Forms.Panel();
            darkNumericUpDown1 = new DarkNumericUpDown();
            darkTitle5 = new DarkTitle();
            panel5 = new System.Windows.Forms.Panel();
            darkRadioButton3 = new DarkRadioButton();
            darkRadioButton2 = new DarkRadioButton();
            darkRadioButton1 = new DarkRadioButton();
            darkTitle3 = new DarkTitle();
            panel4 = new System.Windows.Forms.Panel();
            darkCheckBox2 = new DarkCheckBox();
            darkCheckBox1 = new DarkCheckBox();
            darkTitle2 = new DarkTitle();
            panel3 = new System.Windows.Forms.Panel();
            btnMessageBox = new DarkButton();
            panel2 = new System.Windows.Forms.Panel();
            btnDialog = new DarkButton();
            darkTitle1 = new DarkTitle();
            pnlMain.SuspendLayout();
            tblMain.SuspendLayout();
            pnlTreeView.SuspendLayout();
            pnlListView.SuspendLayout();
            pnlMessageBox.SuspendLayout();
            panel1.SuspendLayout();
            darkGroupBox1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDown1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            // pnlMain
            // 
            pnlMain.Controls.Add(tblMain);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(2, 30);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            pnlMain.Size = new System.Drawing.Size(800, 723);
            pnlMain.TabIndex = 2;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tblMain.Controls.Add(pnlTreeView, 0, 0);
            tblMain.Controls.Add(pnlListView, 0, 0);
            tblMain.Controls.Add(pnlMessageBox, 0, 0);
            tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tblMain.Location = new System.Drawing.Point(5, 10);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblMain.Size = new System.Drawing.Size(790, 713);
            tblMain.TabIndex = 0;
            // 
            // pnlTreeView
            // 
            pnlTreeView.Controls.Add(treeTest);
            pnlTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTreeView.Location = new System.Drawing.Point(531, 0);
            pnlTreeView.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pnlTreeView.Name = "pnlTreeView";
            pnlTreeView.SectionHeader = "Tree view test";
            pnlTreeView.Size = new System.Drawing.Size(254, 713);
            pnlTreeView.TabIndex = 14;
            // 
            // treeTest
            // 
            treeTest.AllowMoveNodes = true;
            treeTest.Dock = System.Windows.Forms.DockStyle.Fill;
            treeTest.Location = new System.Drawing.Point(1, 25);
            treeTest.MaxDragChange = 20;
            treeTest.MultiSelect = true;
            treeTest.Name = "treeTest";
            treeTest.ShowIcons = true;
            treeTest.Size = new System.Drawing.Size(252, 687);
            treeTest.TabIndex = 0;
            treeTest.Text = "darkTreeView1";
            // 
            // pnlListView
            // 
            pnlListView.Controls.Add(lstTest);
            pnlListView.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlListView.Location = new System.Drawing.Point(268, 0);
            pnlListView.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pnlListView.Name = "pnlListView";
            pnlListView.SectionHeader = "List view test";
            pnlListView.Size = new System.Drawing.Size(253, 713);
            pnlListView.TabIndex = 13;
            // 
            // lstTest
            // 
            lstTest.Dock = System.Windows.Forms.DockStyle.Fill;
            lstTest.Location = new System.Drawing.Point(1, 25);
            lstTest.MultiSelect = true;
            lstTest.Name = "lstTest";
            lstTest.Size = new System.Drawing.Size(251, 687);
            lstTest.TabIndex = 7;
            lstTest.Text = "darkListView1";
            // 
            // pnlMessageBox
            // 
            pnlMessageBox.Controls.Add(panel1);
            pnlMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMessageBox.Location = new System.Drawing.Point(5, 0);
            pnlMessageBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pnlMessageBox.Name = "pnlMessageBox";
            pnlMessageBox.SectionHeader = "Controls test";
            pnlMessageBox.Size = new System.Drawing.Size(253, 713);
            pnlMessageBox.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(darkGroupBox1);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(1, 25);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(10);
            panel1.Size = new System.Drawing.Size(251, 687);
            panel1.TabIndex = 0;
            // 
            // darkGroupBox1
            // 
            darkGroupBox1.AutoSize = true;
            darkGroupBox1.Controls.Add(darkRadioButton4);
            darkGroupBox1.Controls.Add(darkCheckBox3);
            darkGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            darkGroupBox1.Location = new System.Drawing.Point(10, 412);
            darkGroupBox1.Name = "darkGroupBox1";
            darkGroupBox1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            darkGroupBox1.Size = new System.Drawing.Size(231, 69);
            darkGroupBox1.TabIndex = 24;
            darkGroupBox1.TabStop = false;
            darkGroupBox1.Text = "GroupBox";
            // 
            // darkRadioButton4
            // 
            darkRadioButton4.AutoSize = true;
            darkRadioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            darkRadioButton4.Location = new System.Drawing.Point(10, 40);
            darkRadioButton4.Name = "darkRadioButton4";
            darkRadioButton4.Size = new System.Drawing.Size(211, 19);
            darkRadioButton4.TabIndex = 1;
            darkRadioButton4.TabStop = true;
            darkRadioButton4.Text = "Radio button";
            // 
            // darkCheckBox3
            // 
            darkCheckBox3.AutoSize = true;
            darkCheckBox3.Dock = System.Windows.Forms.DockStyle.Top;
            darkCheckBox3.Location = new System.Drawing.Point(10, 21);
            darkCheckBox3.Name = "darkCheckBox3";
            darkCheckBox3.Size = new System.Drawing.Size(211, 19);
            darkCheckBox3.TabIndex = 0;
            darkCheckBox3.Text = "Checkbox";
            // 
            // panel7
            // 
            panel7.Controls.Add(darkComboBox1);
            panel7.Controls.Add(darkTitle4);
            panel7.Dock = System.Windows.Forms.DockStyle.Top;
            panel7.Location = new System.Drawing.Point(10, 349);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(231, 63);
            panel7.TabIndex = 23;
            // 
            // darkComboBox1
            // 
            darkComboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            darkComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            darkComboBox1.FormattingEnabled = true;
            darkComboBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "This is a really long item in the collection to check out how text is clipped", "Item 4" });
            darkComboBox1.Location = new System.Drawing.Point(0, 26);
            darkComboBox1.Name = "darkComboBox1";
            darkComboBox1.Size = new System.Drawing.Size(231, 24);
            darkComboBox1.TabIndex = 20;
            // 
            // darkTitle4
            // 
            darkTitle4.Dock = System.Windows.Forms.DockStyle.Top;
            darkTitle4.Location = new System.Drawing.Point(0, 0);
            darkTitle4.Name = "darkTitle4";
            darkTitle4.Size = new System.Drawing.Size(231, 26);
            darkTitle4.TabIndex = 21;
            darkTitle4.Text = "ComboBox";
            // 
            // panel6
            // 
            panel6.Controls.Add(darkNumericUpDown1);
            panel6.Controls.Add(darkTitle5);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(10, 285);
            panel6.Margin = new System.Windows.Forms.Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(231, 64);
            panel6.TabIndex = 22;
            // 
            // darkNumericUpDown1
            // 
            darkNumericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
            darkNumericUpDown1.Location = new System.Drawing.Point(0, 26);
            darkNumericUpDown1.Name = "darkNumericUpDown1";
            darkNumericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            darkNumericUpDown1.Size = new System.Drawing.Size(231, 23);
            darkNumericUpDown1.TabIndex = 24;
            // 
            // darkTitle5
            // 
            darkTitle5.Dock = System.Windows.Forms.DockStyle.Top;
            darkTitle5.Location = new System.Drawing.Point(0, 0);
            darkTitle5.Name = "darkTitle5";
            darkTitle5.Size = new System.Drawing.Size(231, 26);
            darkTitle5.TabIndex = 23;
            darkTitle5.Text = "Numeric Up/Down";
            // 
            // panel5
            // 
            panel5.Controls.Add(darkRadioButton3);
            panel5.Controls.Add(darkRadioButton2);
            panel5.Controls.Add(darkRadioButton1);
            panel5.Controls.Add(darkTitle3);
            panel5.Dock = System.Windows.Forms.DockStyle.Top;
            panel5.Location = new System.Drawing.Point(10, 185);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(231, 100);
            panel5.TabIndex = 12;
            // 
            // darkRadioButton3
            // 
            darkRadioButton3.AutoSize = true;
            darkRadioButton3.Checked = true;
            darkRadioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            darkRadioButton3.Enabled = false;
            darkRadioButton3.Location = new System.Drawing.Point(0, 64);
            darkRadioButton3.Name = "darkRadioButton3";
            darkRadioButton3.Size = new System.Drawing.Size(231, 19);
            darkRadioButton3.TabIndex = 4;
            darkRadioButton3.TabStop = true;
            darkRadioButton3.Text = "Disabled radio button";
            // 
            // darkRadioButton2
            // 
            darkRadioButton2.AutoSize = true;
            darkRadioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            darkRadioButton2.Location = new System.Drawing.Point(0, 45);
            darkRadioButton2.Name = "darkRadioButton2";
            darkRadioButton2.Size = new System.Drawing.Size(231, 19);
            darkRadioButton2.TabIndex = 3;
            darkRadioButton2.Text = "Radio button";
            // 
            // darkRadioButton1
            // 
            darkRadioButton1.AutoSize = true;
            darkRadioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            darkRadioButton1.Location = new System.Drawing.Point(0, 26);
            darkRadioButton1.Name = "darkRadioButton1";
            darkRadioButton1.Size = new System.Drawing.Size(231, 19);
            darkRadioButton1.TabIndex = 2;
            darkRadioButton1.Text = "Radio button";
            // 
            // darkTitle3
            // 
            darkTitle3.Dock = System.Windows.Forms.DockStyle.Top;
            darkTitle3.Location = new System.Drawing.Point(0, 0);
            darkTitle3.Name = "darkTitle3";
            darkTitle3.Size = new System.Drawing.Size(231, 26);
            darkTitle3.TabIndex = 16;
            darkTitle3.Text = "Radio buttons";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(darkCheckBox2);
            panel4.Controls.Add(darkCheckBox1);
            panel4.Controls.Add(darkTitle2);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(10, 111);
            panel4.Name = "panel4";
            panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            panel4.Size = new System.Drawing.Size(231, 74);
            panel4.TabIndex = 11;
            // 
            // darkCheckBox2
            // 
            darkCheckBox2.AutoSize = true;
            darkCheckBox2.Checked = true;
            darkCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            darkCheckBox2.Dock = System.Windows.Forms.DockStyle.Top;
            darkCheckBox2.Enabled = false;
            darkCheckBox2.Location = new System.Drawing.Point(0, 45);
            darkCheckBox2.Name = "darkCheckBox2";
            darkCheckBox2.Size = new System.Drawing.Size(231, 19);
            darkCheckBox2.TabIndex = 13;
            darkCheckBox2.Text = "Disabled checkbox";
            // 
            // darkCheckBox1
            // 
            darkCheckBox1.AutoSize = true;
            darkCheckBox1.Dock = System.Windows.Forms.DockStyle.Top;
            darkCheckBox1.Location = new System.Drawing.Point(0, 26);
            darkCheckBox1.Name = "darkCheckBox1";
            darkCheckBox1.Size = new System.Drawing.Size(231, 19);
            darkCheckBox1.TabIndex = 12;
            darkCheckBox1.Text = "Enabled checkbox";
            // 
            // darkTitle2
            // 
            darkTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            darkTitle2.Location = new System.Drawing.Point(0, 0);
            darkTitle2.Name = "darkTitle2";
            darkTitle2.Size = new System.Drawing.Size(231, 26);
            darkTitle2.TabIndex = 15;
            darkTitle2.Text = "Check boxes";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(btnMessageBox);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(10, 71);
            panel3.Name = "panel3";
            panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            panel3.Size = new System.Drawing.Size(231, 40);
            panel3.TabIndex = 10;
            // 
            // btnMessageBox
            // 
            btnMessageBox.Dock = System.Windows.Forms.DockStyle.Top;
            btnMessageBox.Location = new System.Drawing.Point(0, 0);
            btnMessageBox.Name = "btnMessageBox";
            btnMessageBox.Padding = new System.Windows.Forms.Padding(5);
            btnMessageBox.Size = new System.Drawing.Size(231, 30);
            btnMessageBox.TabIndex = 12;
            btnMessageBox.Text = "Message Box";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(btnDialog);
            panel2.Controls.Add(darkTitle1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(10, 10);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            panel2.Size = new System.Drawing.Size(231, 61);
            panel2.TabIndex = 5;
            // 
            // btnDialog
            // 
            btnDialog.Dock = System.Windows.Forms.DockStyle.Top;
            btnDialog.Location = new System.Drawing.Point(0, 26);
            btnDialog.Name = "btnDialog";
            btnDialog.Padding = new System.Windows.Forms.Padding(5);
            btnDialog.Size = new System.Drawing.Size(231, 30);
            btnDialog.TabIndex = 4;
            btnDialog.Text = "Dialog";
            btnDialog.Click += btnDialog_Click;
            // 
            // darkTitle1
            // 
            darkTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            darkTitle1.Location = new System.Drawing.Point(0, 0);
            darkTitle1.Name = "darkTitle1";
            darkTitle1.Size = new System.Drawing.Size(231, 26);
            darkTitle1.TabIndex = 14;
            darkTitle1.Text = "Dialogs";
            // 
            // DialogControls
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(804, 807);
            Controls.Add(pnlMain);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "DialogControls";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Controls";
            Controls.SetChildIndex(pnlMain, 0);
            pnlMain.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            pnlTreeView.ResumeLayout(false);
            pnlListView.ResumeLayout(false);
            pnlMessageBox.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            darkGroupBox1.ResumeLayout(false);
            darkGroupBox1.PerformLayout();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDown1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private DarkSectionPanel pnlTreeView;
        private DarkTreeView treeTest;
        private DarkSectionPanel pnlListView;
        private DarkListView lstTest;
        private DarkSectionPanel pnlMessageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DarkButton btnDialog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DarkButton btnMessageBox;
        private DarkCheckBox darkCheckBox2;
        private DarkCheckBox darkCheckBox1;
        private System.Windows.Forms.Panel panel5;
        private DarkRadioButton darkRadioButton2;
        private DarkRadioButton darkRadioButton1;
        private DarkRadioButton darkRadioButton3;
        private DarkTitle darkTitle1;
        private DarkTitle darkTitle2;
        private DarkTitle darkTitle3;
        private System.Windows.Forms.Panel panel7;
        private DarkComboBox darkComboBox1;
        private DarkTitle darkTitle4;
        private System.Windows.Forms.Panel panel6;
        private DarkNumericUpDown darkNumericUpDown1;
        private DarkTitle darkTitle5;
        private DarkGroupBox darkGroupBox1;
        private DarkRadioButton darkRadioButton4;
        private DarkCheckBox darkCheckBox3;
    }
}