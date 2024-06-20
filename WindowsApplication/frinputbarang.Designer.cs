namespace WindowsApplication
{
    partial class frinputbarang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            txtkode = new TextBox();
            txtnama = new TextBox();
            txtstok = new TextBox();
            txthargabeli = new TextBox();
            txthargajual = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 0;
            label1.Text = "Nama Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 1;
            label2.Text = "Kode Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 2;
            label3.Text = "Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 3;
            label4.Text = "Harga Beli";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 148);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 4;
            label5.Text = "Harga Jual";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(159, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 6;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtkode
            // 
            txtkode.BorderStyle = BorderStyle.FixedSingle;
            txtkode.Location = new Point(129, 23);
            txtkode.Name = "txtkode";
            txtkode.Size = new Size(213, 23);
            txtkode.TabIndex = 7;
            txtkode.TextChanged += txtkode_TextChanged;
            // 
            // txtnama
            // 
            txtnama.BorderStyle = BorderStyle.FixedSingle;
            txtnama.Location = new Point(129, 55);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(213, 23);
            txtnama.TabIndex = 8;
            // 
            // txtstok
            // 
            txtstok.BorderStyle = BorderStyle.FixedSingle;
            txtstok.Location = new Point(129, 84);
            txtstok.Name = "txtstok";
            txtstok.Size = new Size(213, 23);
            txtstok.TabIndex = 9;
            // 
            // txthargabeli
            // 
            txthargabeli.BorderStyle = BorderStyle.FixedSingle;
            txthargabeli.Location = new Point(129, 114);
            txthargabeli.Name = "txthargabeli";
            txthargabeli.Size = new Size(213, 23);
            txthargabeli.TabIndex = 10;
            // 
            // txthargajual
            // 
            txthargajual.BorderStyle = BorderStyle.FixedSingle;
            txthargajual.Location = new Point(129, 144);
            txthargajual.Name = "txthargajual";
            txthargajual.Size = new Size(213, 23);
            txthargajual.TabIndex = 11;
            // 
            // frinputbarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 243);
            Controls.Add(txthargajual);
            Controls.Add(txthargabeli);
            Controls.Add(txtstok);
            Controls.Add(txtnama);
            Controls.Add(txtkode);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frinputbarang";
            Text = "frinputbarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        public TextBox txtkode;
        public TextBox txtnama;
        public TextBox txtstok;
        public TextBox txthargabeli;
        public TextBox txthargajual;
    }
}