using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class frbarang : Form
    {
        // Properti aksi
        public string aksi { get; set; }

        public frbarang()
        {
            InitializeComponent();

            // Panggil metode TampilBarang() saat form frbarang diinisialisasi
            TampilBarang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            DataGridViewRow selectedRow = dataGridView1.Rows[i];

            // Membuat instance dari frinputbarang dengan memberikan objek frbarang sebagai argumen
            frinputbarang frinputbarang = new frinputbarang(this);

            // Membersihkan kontrol input
            frinputbarang.bersih();

            // Mengatur nilai properti aksi menjadi "entry"
            frinputbarang.aksi = "entry";

            // Mengatur nilai properti txtkode, txtnama, txtstok, txthargabeli, dan txthargajual
            frinputbarang.txtkode.Text = selectedRow.Cells[0].Value.ToString();
            frinputbarang.txtnama.Text = selectedRow.Cells[1].Value.ToString();
            frinputbarang.txtstok.Text = selectedRow.Cells[2].Value.ToString();
            frinputbarang.txthargabeli.Text = selectedRow.Cells[3].Value.ToString();
            frinputbarang.txthargajual.Text = selectedRow.Cells[4].Value.ToString();

            // Menampilkan frinputbarang
            frinputbarang.Show();
        }

        private void frbarang_Load(object sender, EventArgs e)
        {
            // Panggil metode TampilBarang() saat form frbarang dimuat
            TampilBarang();
        }

        // Metode untuk menampilkan data barang
        public void TampilBarang()
        {
            try
            {
                // Koneksi ke database
                string connStr = "Server=localhost;user id=root;password=;database=db_xyz";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_barang";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Misalkan Anda memiliki DataGridView dengan nama dataGridView1
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol untuk membuka form frkasir
        private void button1_Click(object sender, EventArgs e)
        {
            // Menyembunyikan form saat ini
            this.Hide();

            // Membuat instance dari frkasir
            frkasir frkasir = new frkasir();

            // Menampilkan frkasir
            frkasir.Show();
        }

        // Tombol untuk membuka form frinputbarang
        private void button6_Click(object sender, EventArgs e)
        {
            // Membuat instance dari frinputbarang dengan memberikan objek frbarang sebagai argumen
            frinputbarang frinputbarang = new frinputbarang(this);

            // Membersihkan kontrol input
            frinputbarang.bersih();

            // Mengatur nilai properti aksi menjadi "entry"
            frinputbarang.aksi = "entry";

            // Menampilkan frinputbarang
            frinputbarang.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Membuat instance dari frinputbarang dengan memberikan objek frbarang sebagai argumen
            frinputbarang frinputbarang = new frinputbarang(this);

            // Membersihkan kontrol input
            frinputbarang.bersih();

            // Mengatur nilai properti aksi menjadi "edit"
            frinputbarang.aksi = "edit";

            // Menampilkan frinputbarang
            frinputbarang.Show();

            // Menonaktifkan form saat ini dan frkasir (jika objek frkasir ada)
            if (Application.OpenForms["frkasir"] != null)
            {
                Form frkasir = Application.OpenForms["frkasir"];
                frkasir.Enabled = false;
            }
            this.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Mendapatkan indeks baris yang dipilih di DataGridView
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            // Mendapatkan nilai dari kolom kd_barang di baris yang dipilih
            string kodeBarang = dataGridView1.Rows[rowIndex].Cells["kd_barang"].Value.ToString();

            // Konfirmasi penghapusan
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus barang dengan kode " + kodeBarang + "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Hapus data dari database
                try
                {
                    string connStr = "Server=localhost;user id=root;password=;database=db_xyz";
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string query = "DELETE FROM tbl_barang WHERE kd_barang = @kode";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@kode", kodeBarang);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Refresh tampilan data setelah penghapusan
                    TampilBarang();
                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CariBarang(textBox1.Text);
        }

        // Metode untuk melakukan pencarian barang
        private void CariBarang(string keyword)
        {
            try
            {
                // Koneksi ke database
                string connStr = "Server=localhost;user id=root;password=;database=db_xyz";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_barang WHERE ";
                    if (radioButton1.Checked)
                    {
                        query += "kd_barang LIKE @keyword";
                    }
                    else if (radioButton2.Checked)
                    {
                        query += "nm_barang LIKE @keyword";
                    }
                    else if (radioButton3.Checked)
                    {
                        query += "kd_barang LIKE @keyword OR nm_barang LIKE @keyword";
                    }
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Misalkan Anda memiliki DataGridView dengan nama dataGridView1
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
