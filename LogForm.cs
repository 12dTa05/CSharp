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
using static WindowsForm.AdminForm;
using static WindowsForm.CameraForm;
using System.Data.SqlClient;
using System.Globalization;
using System.Collections;
using static System.Windows.Forms.LinkLabel;
using System.IO;
using System.Net;


namespace WindowsForm
{
    public partial class LogForm : Form
    {
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public LogForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetNhatKy().Tables[0];
        }

        private void NhatKy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetNhatKy().Tables[0]; 
        }
        DataSet GetNhatKy()
        {
            DataSet data = new DataSet();
            string query = "select NK.STT, NK.ID, CCCD.HoTen, NK.TGVao, NK.TGRa, NK.TrangThai, NK.LyDo, NK.TenDV from NhatKy as NK, CCCD where CCCD.ID = NK.ID";
            SqlConnection conn = new SqlConnection(conn_string);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(data);

            conn.Close(); 
            return data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string ma = row.Cells[0].Value.ToString();
            OpenChildForm(new ShowInfoForm(ma));        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string ma = row.Cells[0].Value.ToString(); 
            OpenChildForm(new ShowInfoForm(ma));

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
