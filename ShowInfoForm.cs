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
    public partial class ShowInfoForm : Form
    {
        public ShowInfoForm(string stt)
        {
            InitializeComponent();
            Add_ThongTin(stt);

        }
        private void Load_Image(string Path1, string Path2, string Path3, string Path4, string Path5)
        {
            pictureBox4.Image = Image.FromFile(Path1);
            pictureBox5.Image = Image.FromFile(Path2);
            pictureBox6.Image = Image.FromFile(Path3);
            pictureBox2.Image = Image.FromFile(Path4);
            pictureBox3.Image = Image.FromFile(Path5);
        }


        public void Add_ThongTin(string stt)
        {
            string query = "select * from NhatKy join CCCD ON CCCD.ID = NhatKy.ID WHERE STT = '" + stt + "'";
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
                        TGianRa.Text = reader.GetDateTime(reader.GetOrdinal("TGRa")).ToString();
                        TGianVao.Text = reader.GetDateTime(reader.GetOrdinal("TGVao")).ToString();
                        DonVi.Text = reader.GetString(reader.GetOrdinal("TenDV")).ToString();
                        LiDo.Text = reader.GetString(reader.GetOrdinal("LyDo")).ToString();
                        Load_Image(Path1, Path2, Path3, Path4, Path5);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu.");
                }                // Xử lý dữ liệu ở đây 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn SQL: " + ex.Message);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void LiDo_Khac_TextChanged(object sender, EventArgs e)
        {

        }

        private void TGianVao_TextChanged(object sender, EventArgs e)
        {

        }

        private void TGianRa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ShowInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void LiDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DonVi_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void ChucVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void QTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dinhdanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void ok_btn_Click(object sender, EventArgs e)
        { 
            this.Hide();
        }
    }
}
