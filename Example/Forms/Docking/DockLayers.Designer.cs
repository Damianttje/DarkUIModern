using DarkUI.Controls;
using DarkUI.Data.Enums.Docking;

namespace Example
{
    partial class DockLayers
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
            lstLayers = new DarkListView();
            cmbList = new DarkDropdownList();
            SuspendLayout();
            // 
            // lstLayers
            // 
            lstLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            lstLayers.HideScrollBars = false;
            lstLayers.ItemHeight = 40;
            lstLayers.Location = new System.Drawing.Point(0, 51);
            lstLayers.Name = "lstLayers";
            lstLayers.ShowDetails = true;
            lstLayers.ShowIcons = true;
            lstLayers.Size = new System.Drawing.Size(280, 399);
            lstLayers.TabIndex = 0;
            lstLayers.Text = "darkListView1";
            // 
            // cmbList
            // 
            cmbList.Dock = System.Windows.Forms.DockStyle.Top;
            cmbList.Location = new System.Drawing.Point(0, 25);
            cmbList.Name = "cmbList";
            cmbList.ShowBorder = false;
            cmbList.Size = new System.Drawing.Size(280, 26);
            cmbList.TabIndex = 1;
            cmbList.Text = "darkDropdownList1";
            // 
            // DockLayers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lstLayers);
            Controls.Add(cmbList);
            DefaultDockArea = DarkDockArea.Right;
            DockText = "Layers";
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = Icons.Collection_16xLG;
            Name = "DockLayers";
            SerializationKey = "DockLayers";
            Size = new System.Drawing.Size(280, 450);
            ResumeLayout(false);
        }

        #endregion

        private DarkListView lstLayers;
        private DarkDropdownList cmbList;
    }
}
