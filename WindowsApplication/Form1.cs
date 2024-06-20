using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsApplication
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rd;

        public Form1()
        {
            InitializeComponent();      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.Color.Black;
                textBox2.PasswordChar = '*'; // Hide password characters
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = System.Drawing.Color.Gray;
                textBox2.PasswordChar = '\0'; // Show password characters
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetWatermark(textBox1, "Username");
            SetWatermark(textBox2, "Password");
        }

        // Metode untuk menetapkan watermark ke TextBox
        private void SetWatermark(TextBox textBox, string watermarkText)
        {
            textBox.Text = watermarkText;
            textBox.ForeColor = System.Drawing.Color.Gray;
        }

        private void koneksi()
        {
            try
            {
                string str = "Server=localhost;user id=root;password=;database=db_xyz";
                conn = new MySqlConnection(str);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Username" || string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Password")
            {
                MessageBox.Show("Isi username dan password terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi();
                string query = "SELECT * FROM tbl_user WHERE username = @username AND password = @password";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    string status = rd["status"].ToString();
                    if (status == "ADMIN" || status == "OPERATOR")
                    {
                        this.Hide();
                        Form MDIParent1 = new MDIParent1();
                        MDIParent1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (rd != null)
                {
                    rd.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
