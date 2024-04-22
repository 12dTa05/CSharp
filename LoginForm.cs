using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsForm
{
    public partial class LoginForm : Form
    {
        public static SqlConnection conn;
        public static String conn_string;
        public LoginForm()
        {
            ConnectDatabase();
            InitializeComponent();
        }
        private void ConnectDatabase()
        {
            conn_string = $"Server= NHDANDZ; Database= QLYRAVAO; User Id= lin; Password= 123";
            using (conn = new SqlConnection(conn_string))
            {
                try
                {
                    conn.Open(); 
                }
                catch (SqlException)
                {
                    MessageBox.Show("Check your information again");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string query = "SELECT * FROM Sys_Users WHERE Username = '" + txtUsername.Text +"'";
            try
            {
                SqlConnection conn = new SqlConnection(LoginForm.conn_string);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                // Kiểm tra xem có dữ liệu không 
                if (reader.HasRows)
                {
                    // Đọc và hiển thị dữ liệu
                    while (reader.Read())
                    {
                        if (reader.GetString(reader.GetOrdinal("Password")).ToString() == txtPassword.Text)
                        {
                            MessageBox.Show("Login success!");
                            if (reader.GetBoolean(reader.GetOrdinal("Type")).ToString() == "True")
                            {
                                new AdminForm().Show();
                            }
                            else
                            {
                                new CameraForm().Show();
                            }
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn SQL: " + ex.Message);
            } 
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
