namespace WindowsApplication
{
    partial class MDIParent1
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
            menuStrip = new MenuStrip();
            masterDataToolStripMenuItem = new ToolStripMenuItem();
            kasirToolStripMenuItem = new ToolStripMenuItem();
            barangToolStripMenuItem = new ToolStripMenuItem();
            laporanPenjualanToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { masterDataToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // masterDataToolStripMenuItem
            // 
            masterDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kasirToolStripMenuItem, barangToolStripMenuItem, laporanPenjualanToolStripMenuItem });
            masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            masterDataToolStripMenuItem.Size = new Size(82, 20);
            masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // kasirToolStripMenuItem
            // 
            kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            kasirToolStripMenuItem.Size = new Size(180, 22);
            kasirToolStripMenuItem.Text = "Kasir";
            kasirToolStripMenuItem.Click += kasirToolStripMenuItem_Click;
            // 
            // barangToolStripMenuItem
            // 
            barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            barangToolStripMenuItem.Size = new Size(180, 22);
            barangToolStripMenuItem.Text = "Barang";
            barangToolStripMenuItem.Click += barangToolStripMenuItem_Click;
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            laporanPenjualanToolStripMenuItem.Size = new Size(180, 22);
            laporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            laporanPenjualanToolStripMenuItem.Click += laporanPenjualanToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(737, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIParent1";
            Text = "MDIParent1";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem masterDataToolStripMenuItem;
        private ToolStripMenuItem kasirToolStripMenuItem;
        private ToolStripMenuItem barangToolStripMenuItem;
        private ToolStripMenuItem laporanPenjualanToolStripMenuItem;
    }
}



