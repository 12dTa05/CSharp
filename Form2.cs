using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static WindowsForm.CameraForm;
using static WindowsForm.LogForm;


namespace WindowsForm
{
    public partial class Form2 : Form
    {
        public string server, database, userid, passwd;
        public static SqlConnection conn;
        public static String conn_string;


        private void Server_TextChanged(object sender, EventArgs e)
        {

        }

        private void Database_TextChanged(object sender, EventArgs e)
        {

        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            if (Check_Conn())
            {               
                conn_string = $"Server={server}; Database={database}; User Id={userid}; Password={passwd}";
                using (conn = new SqlConnection(conn_string))
                {
                    try
                    {
                        conn.Open();
                        AdminForm frm = new AdminForm();
                        this.Hide();
                        frm.Show();
                    }
                    catch(SqlException)
                    {
                        MessageBox.Show("Check your information again");
                    }
                } 
                
            }
            else
            {
                MessageBox.Show("Check your information again");
            }
        }

        public Form2()
        {
            InitializeComponent(); 
        }

        public bool Check_Conn()
        {
            server = Server.Text;
            database = Database.Text;
            userid = UserID.Text;
            passwd = Password.Text;
            if (server == "" || database == "" || userid == "" || passwd == "")
            {
                return false;
            }
            return true;
        }
    }
}
