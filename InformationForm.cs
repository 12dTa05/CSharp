using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsForm.LoginForm;
using static WindowsForm.CameraForm;
using System.Data.SqlClient;
using System.Globalization;
using System.Collections;
using static System.Windows.Forms.LinkLabel;
using System.IO;
using System.Net;

namespace WindowsForm
{
    public partial class InformationForm : Form
    { 

        public static bool status;
        public InformationForm()
        {
            InitializeComponent();
            LiDo_Khac.Hide();
            Add_DonVi();
            Add_Lido();
            Add_ChucVu();
            Add_ThongTin1();
            
        }

        private void Load_Image(string Path1, string Path2, string Path3, string Path4, string Path5)
        {
            pictureBox4.Image = Image.FromFile(Path1);
            pictureBox5.Image = Image.FromFile(Path2);
            pictureBox6.Image = Image.FromFile(Path3);
            pictureBox2.Image = Image.FromFile(Path4);
            pictureBox3.Image = Image.FromFile(Path5);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (status == false)
                sqlPost();
            else
                updatePost();

            this.Close();
        }

        public void Add_Tgian()
        {

        }

        public void Add_ChucVu()
        {
            ChucVu.Items.Add("Quân nhân");
            ChucVu.Items.Add("Thân nhân");
            ChucVu.SelectedIndex = 1;
        }

        public void Add_DonVi()
        {
            DonVi.Items.Add("DV01");
            DonVi.Items.Add("DV02");
            DonVi.Items.Add("DV03");
            DonVi.Items.Add("DV04");
            DonVi.Items.Add("DV05");
            DonVi.Items.Add("DV06");
        }

        public void Add_Lido()
        {
            LiDo.Items.Add("Vào làm");
            LiDo.Items.Add("Ra về");
            LiDo.Items.Add("Công tác");
            LiDo.Items.Add("Khác");
            LiDo.SelectedIndex = 0;
        }

        private void LiDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LiDo.SelectedIndex == 4)
            {
                LiDo_Khac.Show();
            }
        }

        public String ConvertSQLTime(String dateTimeString)
        {
            // Chuyển đổi chuỗi thành đối tượng DateTime
            DateTime dateTime = DateTime.ParseExact(dateTimeString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            // Định dạng lại ngày theo định dạng kiểu DateTime của SQL Server
            string sqlDateTimeString = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

            // Kết quả
            return sqlDateTimeString; // In ra "2024-04-09 16:25:06"
        }
        public DateTime ConvertSQLTimeDay(String dateTimeString)
        {
            DateTime dateTime = DateTime.ParseExact(dateTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return dateTime;
        }

        public void Add_ThongTin()
        {
            var dataItems = CameraForm.DataArray[0];
           
            CCCD.Text = dataItems["id"].ToString();
            HoTen.Text = dataItems["name"].ToString();
            NgSinh.Text = dataItems["dob"].ToString();
            GTinh.Text = dataItems["sex"].ToString();
            QTich.Text = dataItems["nationality"].ToString();
            DiaChi.Text = dataItems["address"].ToString();
            QueQuan.Text = dataItems["home"].ToString();
            HetHan.Text = dataItems["doe"].ToString();
            string query = "SELECT * FROM Nguoi WHERE ID = '" + CCCD.Text + "'";
             
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
                        bool data = reader.GetBoolean(reader.GetOrdinal("TrangThai"));
                        if(data == false)
                            TGianRa.Text = (DateTime.Now).ToString();
                        status = data;
                        
                        //MessageBox.Show(ConvertSQLTime(TGianRa.Text)); // In ra "2024-04-09 16:25:06"
                        //MessageBox.Show(data.ToString());
                    }
                }
                else
                {
                    //MessageBox.Show("Không có dữ liệu.");
                    TGianVao.Text = (DateTime.Now).ToString();
                    status = false;
                    sqlPostINFO();
                    // Kết quả
                    //MessageBox.Show(ConvertSQLTime(TGianVao.Text));
                }                // Xử lý dữ liệu ở đây
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn SQL: " + ex.Message);
            }

        }
        private String EscapeData(String B64)
        {
            int B64_length = B64.Length;
            if (B64_length <= 32000)
            {
                return Uri.EscapeDataString(B64);
            }


            int idx = 0;
            StringBuilder builder = new StringBuilder();
            String substr = B64.Substring(idx, 32000);
            while (idx < B64_length)
            {
                builder.Append(Uri.EscapeDataString(substr));
                idx += 32000;

                if (idx < B64_length)
                {

                    substr = B64.Substring(idx, Math.Min(32000, B64_length - idx));
                }

            }
            return builder.ToString();

        }

        private string sendPOST_2(string url, string B64, string B64_2)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 100000;

                // Build the POST data with both images
                var postData = "image1=" + B64 + "&image2=" + B64_2;


                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;
            }
            catch (Exception ex)
            {
                return "Exception: " + ex.ToString();
            }
        }

        private bool FaceCheck(String Path)
        { 
            String server_ip = "127.0.0.1";
            String str2 = sendPOST_2("http://" + server_ip + ":5000/check",Path , FacePath);
            if (str2 == "False")
                return false;
            return true;
        }

        public void Add_ThongTin1()
        { 
            string query = "SELECT * FROM CCCD WHERE ID = '" + CCCD_ID + "'";
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
                        string Path1 = reader.GetString(reader.GetOrdinal("Image1")).ToString();
                        string Path2 = reader.GetString(reader.GetOrdinal("Image2")).ToString();
                        string Path3 = reader.GetString(reader.GetOrdinal("Image3")).ToString();
                        if (FaceCheck(Path2) == false)
                        {
                            MessageBox.Show("Sai người rồi bạn ơi! Đừng vào/ra nữa nhé!");
                            this.Close();
                        }
                        //MessageBox.Show(reader.GetString(reader.GetOrdinal("ID")).ToString());
                        CCCD.Text = reader.GetString(reader.GetOrdinal("ID")).ToString();
                        HoTen.Text = reader.GetString(reader.GetOrdinal("HoTen")).ToString();
                        NgSinh.Text = reader.GetString(reader.GetOrdinal("NgaySinh")).ToString();
                        string gt = reader.GetBoolean(reader.GetOrdinal("GioiTinh")).ToString();
                        if (gt == "1")
                            GTinh.Text = "Nam";
                        else
                            GTinh.Text = "Nữ";
                        QTich.Text = reader.GetString(reader.GetOrdinal("QuocTich")).ToString();
                        DiaChi.Text = reader.GetString(reader.GetOrdinal("DiaChi")).ToString();
                        QueQuan.Text = reader.GetString(reader.GetOrdinal("QueQUan")).ToString();
                        HetHan.Text = reader.GetString(reader.GetOrdinal("NgayhetHan")).ToString();
                        string Path4 = reader.GetString(reader.GetOrdinal("VanTay1")).ToString();
                        string Path5 = reader.GetString(reader.GetOrdinal("VanTay2")).ToString();
                        TenCha.Text = reader.GetString(reader.GetOrdinal("TenCha")).ToString();
                        TenMe.Text = reader.GetString(reader.GetOrdinal("TenMe")).ToString();
                        TenVC.Text = reader.GetString(reader.GetOrdinal("TenVo")).ToString();
                        NgayCap.Text = reader.GetString(reader.GetOrdinal("NgayCap")).ToString();
                        CMND.Text = reader.GetString(reader.GetOrdinal("CMND")).ToString();
                        Tongiao.Text = reader.GetString(reader.GetOrdinal("TonGiao")).ToString();
                        Load_Image(Path1, Path2, Path3, Path4, Path5);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu."); 
                }                // Xử lý dữ liệu ở đây
                /*                CCCD.Text = dataItems["id"].ToString();
                                HoTen.Text = dataItems["name"].ToString();
                                NgSinh.Text = dataItems["dob"].ToString();
                                GTinh.Text = dataItems["sex"].ToString();
                                QTich.Text = dataItems["nationality"].ToString();
                                DiaChi.Text = dataItems["address"].ToString();
                                QueQuan.Text = dataItems["home"].ToString();
                                HetHan.Text = dataItems["doe"].ToString();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn SQL: " + ex.Message);
            }
            
            query = "SELECT * FROM NhatKy WHERE ID = " + CCCD.Text + " AND TGRa is NULL";
            //MessageBox.Show(conn_string);

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
                        bool data = reader.GetBoolean(reader.GetOrdinal("TrangThai"));
                        if (data == false)
                        {
                            status = true;
                            TGianRa.Text = (DateTime.Now).ToString();
                            //updatePost();
                        }
                            //TGianVao.Text = reader.GetDateTime(reader.GetOrdinal("TGVao")).ToString();
                        //MessageBox.Show(ConvertSQLTime(TGianRa.Text)); // In ra "2024-04-09 16:25:06"
                        //MessageBox.Show(data.ToString());
                    }   
                }
                else
                {
                    //MessageBox.Show("Không có dữ liệu.");
                    TGianVao.Text = (DateTime.Now).ToString();

                    status = false; 
                    // Kết quả
                    //MessageBox.Show(ConvertSQLTime(TGianVao.Text));
                }                // Xử lý dữ liệu ở đây 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn SQL: " + ex.Message);
            } 

        }


        public bool Check()
        {
            bool check = false;
            if (ChucVu.SelectedIndex == 0)
            {
                if (DonVi.SelectedIndex == -1 || LiDo.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else if (LiDo.SelectedIndex == 4 && LiDo_Khac.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else check = true;
            }
            else check = true;
            return check;
        }

        public bool ConvertGT(String gt)
        {
            if (gt == "NAM")
                return true;
            else
                return false;
        }
        public void updatePost()
        {
            if (Check())
            {
                MessageBox.Show("Đã ra khỏi đơn vị.");
                string insert = "EXEC ThemDuLieu " +
                    "@tgra" + "," + "@id";
                SqlConnection conn = new SqlConnection(LoginForm.conn_string);
                conn.Open();
                SqlCommand command = new SqlCommand(insert, conn);
                command.CommandType = CommandType.Text; 
                    // Add parameters
                    command.Parameters.AddWithValue("@id", CCCD.Text.ToString()); 
                    if (TGianRa.Text != "")
                       command.Parameters.AddWithValue("@tgra", ConvertSQLTime(TGianRa.Text));
                    else
                       command.Parameters.AddWithValue("@tgra", DBNull.Value); 
                // Execute the command
                command.ExecuteNonQuery();
                
            }
        }
        public void sqlPost()
        {
            if (Check())
            {
                MessageBox.Show("Đã vào đơn vị!");
                string insert = "insert into NhatKy(ID, TenDV, TGVao, LyDo, TrangThai)" +
                    "values (@id, @tendv, @tgvao, @lido, @trangthai)";
                SqlConnection conn = new SqlConnection(LoginForm.conn_string);
                conn.Open();
                SqlCommand command = new SqlCommand(insert, conn);
                command.CommandType = CommandType.Text;
                // Add parameters
                command.Parameters.AddWithValue("@id", CCCD.Text.ToString());
                command.Parameters.AddWithValue("@tendv", DonVi.Text.ToString());
                if (TGianVao.Text != "")
                    command.Parameters.AddWithValue("@tgvao", ConvertSQLTime(TGianVao.Text));
                else
                    command.Parameters.AddWithValue("@tgvao", DBNull.Value); 
                command.Parameters.AddWithValue("@lido", LiDo.Text.ToString());
                command.Parameters.AddWithValue("@trangthai", status);
                // Execute the command
                command.ExecuteNonQuery();

            }
        }
        public void sqlPostINFO()
        {
            if (Check())
            {
                string insert = "insert into TTIN(ID, TenQN, NSinh, GTinh, QTich, DChiTTru, QQuan)" +
                    "values (@id, @Ten, @nsinh, @gt, @qt, @dc, @qq)";
                SqlConnection conn = new SqlConnection(LoginForm.conn_string);
                conn.Open();
                SqlCommand command = new SqlCommand(insert, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@id", CCCD.Text.ToString());
                command.Parameters.AddWithValue("@Ten", HoTen.Text.ToString());
                command.Parameters.AddWithValue("@nsinh", ConvertSQLTimeDay(NgSinh.Text));
                command.Parameters.AddWithValue("@gt", ConvertGT(GTinh.Text.ToString()));
                command.Parameters.AddWithValue("@qt", QTich.Text.ToString());
                command.Parameters.AddWithValue("@dc", DiaChi.Text.ToString());
                command.Parameters.AddWithValue("@qq", QueQuan.Text.ToString());
                // Execute the command
                command.ExecuteNonQuery();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void QTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void TenCha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TGianVao_TextChanged(object sender, EventArgs e)
        {

        }

        private void LiDo_Khac_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void DonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void LiDo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TGianRa_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void Tongiao_TextChanged(object sender, EventArgs e)
        {

        }

        private void QueQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void QTich_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void NgSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void CMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void HetHan_TextChanged(object sender, EventArgs e)
        {

        }

        private void NgayCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void TenVC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TenMe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
