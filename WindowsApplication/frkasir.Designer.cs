namespace WindowsApplication
{
    partial class frkasir
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, -42);
            label1.Name = "label1";
            label1.Size = new Size(0, 33);
            label1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(587, 205);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "KODE BARANG";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "NAMA BARANG";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "JUMLAH";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "HARGA";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "TOTAL";
            Column5.Name = "Column5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 6);
            label2.Name = "label2";
            label2.Size = new Size(215, 27);
            label2.TabIndex = 32;
            label2.Text = "SISTEM KASIR";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 33;
            label3.Text = "Kode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 52);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 34;
            label4.Text = "Nama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 52);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 35;
            label5.Text = "Jumlah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 52);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 36;
            label6.Text = "Harga";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 52);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 37;
            label7.Text = "Total";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(497, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 38;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(312, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(57, 23);
            textBox2.TabIndex = 39;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(386, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 40;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(129, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 41;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(12, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 42;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 341);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 43;
            label8.Text = "Sub Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(147, 340);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 44;
            label9.Text = "Diskon";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(223, 340);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 45;
            label10.Text = "GrandTotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(359, 340);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 46;
            label11.Text = "Dibayar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(483, 340);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 47;
            label12.Text = "Kembali";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(12, 359);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(129, 23);
            textBox6.TabIndex = 48;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(147, 358);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(70, 23);
            textBox7.TabIndex = 49;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(223, 359);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(130, 23);
            textBox8.TabIndex = 50;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Location = new Point(359, 358);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(118, 23);
            textBox9.TabIndex = 51;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Location = new Point(483, 358);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(116, 23);
            textBox10.TabIndex = 52;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.FixedSingle;
            textBox11.Location = new Point(613, 52);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(163, 41);
            textBox11.TabIndex = 53;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // frkasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 412);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "frkasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frkasir";
            Load += frkasir_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}