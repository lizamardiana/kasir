using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsApplication
{
    public static class Module1
    {
        [DllImport("user32.dll")]
        private static extern int GetWindow(IntPtr hwnd, int wCmd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessageA")]
        private static extern int SendMessageString(IntPtr hwnd, int wMsg, int wParam, string lParam);

        private const int GW_CHILD = 5;
        private const int EM_SETCUEBANNER = 0x1501;

        public static void SetWatermark(TextBox ctl, string txt)
        {
            SendMessageString(ctl.Handle, EM_SETCUEBANNER, 1, txt);
        }

        public static void SetWatermark(ComboBox ctl, string txt)
        {
            IntPtr i = (IntPtr)GetWindow(ctl.Handle, GW_CHILD);
            SendMessageString(i, EM_SETCUEBANNER, 1, txt);
        }

        public static MySqlConnection conn;
        public static MySqlCommand cmd;
        public static MySqlDataReader rd;
        public static MySqlDataAdapter da;
        public static DataSet ds;
        public static string str;

        public static void Koneksi()
        {
            try
            {
                string str = "Server=localhost;user id=root;password=;database=db_xyz";
                conn = new MySqlConnection(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
