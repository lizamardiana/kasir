using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsApplication
{
    public partial class frkasir : Form
    {
        string kode;
        long stok, jumlah, harga, total;
        long grandtotal, subtotal, kembali, bayar, diskon;

        // Deklarasi variabel frbarangInstance di luar metode
        private frbarang frbarangInstance;

        public frkasir()
        {
            InitializeComponent();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            // Menyembunyikan form saat ini
            this.Hide();

            // Membuat instance dari frm_insert
            frbarang frbarang = new frbarang();

            // Menampilkan frm_insert
            frbarang.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data yang muncul ketika diisi kode barang atau nama barang
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frkasir_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Kosongkan metode textBox5_TextChanged karena tidak diperlukan
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Isi kode barang terlebih dahulu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Kode koneksi ke database
                    string connectionString = "Server=localhost;user id=root;password=;database=db_xyz";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_barang WHERE kd_barang = @kode", conn);
                    cmd.Parameters.AddWithValue("@kode", textBox5.Text);

                    try
                    {
                        conn.Open();
                        MySqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            kode = rd["kd_barang"].ToString();
                            textBox4.Text = rd["nm_barang"].ToString();
                            stok = Convert.ToInt64(rd["qty"]);
                            jumlah = 1;
                            harga = Convert.ToInt64(rd["harga_jual"]);
                            total = jumlah * harga;
                            textBox2.Text = jumlah.ToString();
                            textBox3.Text = harga.ToString();
                            textBox1.Text = total.ToString();
                            textBox2.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Kode barang tidak terdaftar", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox5.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                e.Handled = true; // Menandai bahwa peristiwa key press sudah ditangani
            }
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //nama barang
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //jumlah
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //harga
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //total
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //subtotal
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //diskon
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //grand diskon
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //uang yang dibayar
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //kembalian
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //total keseluruhan termasuk diskon
        }
    }

}
