using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class frinputbarang : Form
    {
        // Properti aksi
        public string aksi { get; set; }

        // Objek frbarang untuk mengakses metode TampilBarang()
        private frbarang _frbarang;

        // Konstruktor dengan parameter frbarang untuk menerima referensi objek frbarang
        public frinputbarang(frbarang frbarang)
        {
            InitializeComponent();
            _frbarang = frbarang;
            this.FormClosing += new FormClosingEventHandler(frinputbarang_FormClosing);
        }

        // Metode untuk mengatur objek frbarang dan frkasir ketika form ditutup
        private void frinputbarang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_frbarang != null)
            {
                _frbarang.Enabled = true;
            }

            if (Application.OpenForms["frkasir"] != null)
            {
                Form frkasir = Application.OpenForms["frkasir"];
                frkasir.Enabled = true;
            }
        }

        // Metode bersih diubah menjadi public
        public void bersih()
        {
            // Membersihkan semua kontrol input
            txtkode.Text = "";
            txtnama.Text = "";
            txtstok.Text = "";
            txthargabeli.Text = "";
            txthargajual.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aksi == "entry")
            {
                // Simpan data
                if (string.IsNullOrEmpty(txtkode.Text) || string.IsNullOrEmpty(txtnama.Text) ||
                    string.IsNullOrEmpty(txtstok.Text) || string.IsNullOrEmpty(txthargabeli.Text) ||
                    string.IsNullOrEmpty(txthargajual.Text))
                {
                    MessageBox.Show("Lengkapi data terlebih dahulu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CallKoneksi();

                    string query = "INSERT INTO tbl_barang VALUES (@kode, @nama, @stok, @hargabeli, @hargajual)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@kode", MySqlDbType.String).Value = txtkode.Text;
                        cmd.Parameters.Add("@nama", MySqlDbType.String).Value = txtnama.Text;
                        cmd.Parameters.Add("@stok", MySqlDbType.UInt64).Value = Convert.ToUInt64(txtstok.Text);
                        cmd.Parameters.Add("@hargabeli", MySqlDbType.UInt64).Value = Convert.ToUInt64(txthargabeli.Text);
                        cmd.Parameters.Add("@hargajual", MySqlDbType.UInt64).Value = Convert.ToUInt64(txthargajual.Text);
                        cmd.ExecuteNonQuery();
                        try
                        {
                            MessageBox.Show("Data berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Memanggil metode TampilBarang() menggunakan objek frbarang
                            if (_frbarang != null)
                            {
                                _frbarang.TampilBarang();
                            }

                            bersih();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Edit data
                if (string.IsNullOrEmpty(txtkode.Text) || string.IsNullOrEmpty(txtnama.Text) ||
                    string.IsNullOrEmpty(txtstok.Text) || string.IsNullOrEmpty(txthargabeli.Text) ||
                    string.IsNullOrEmpty(txthargajual.Text))
                {
                    MessageBox.Show("Lengkapi data terlebih dahulu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CallKoneksi();

                    string query = "UPDATE tbl_barang SET nm_barang = @nama, qty = @stok, harga_beli = @hargabeli, harga_jual = @hargajual WHERE kd_barang = @kode";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@kode", MySqlDbType.String).Value = txtkode.Text;
                        cmd.Parameters.Add("@nama", MySqlDbType.String).Value = txtnama.Text;
                        cmd.Parameters.Add("@stok", MySqlDbType.UInt64).Value = Convert.ToUInt64(txtstok.Text);
                        cmd.Parameters.Add("@hargabeli", MySqlDbType.UInt64).Value = Convert.ToUInt64(txthargabeli.Text);
                        cmd.Parameters.Add("@hargajual", MySqlDbType.UInt64).Value = Convert.ToUInt64(txthargajual.Text);
                        cmd.ExecuteNonQuery();
                        try
                        {
                            MessageBox.Show("Data berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Memanggil metode TampilBarang() menggunakan objek frbarang
                            if (_frbarang != null)
                            {
                                _frbarang.TampilBarang();
                            }

                            bersih();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private MySqlConnection conn;

        private void CallKoneksi()
        {
            // Implementasi metode koneksi ke database di sini
            // Misalnya:
            string str = "Server=localhost;user id=root;password=;database=db_xyz";
            conn = new MySqlConnection(str);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak bisa terhubung ke database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtkode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}