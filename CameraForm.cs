using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using AForge.Video;
using AForge.Video.DirectShow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using static WindowsForm.LoginForm;
using static WindowsForm.InformationForm;



using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Security.Cryptography.Xml;
using System.Diagnostics;

namespace WindowsForm
{
    public partial class CameraForm : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam1, cam;
        public static JArray DataArray;
        public static string CCCD_ID, FacePath;

        public CameraForm()
        {
            InitializeComponent();
// RunPythonApi();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
            }
            comboBox1.SelectedIndex = 0;
            foreach (FilterInfo info in cameras)
            {
                comboBox2.Items.Add(info.Name);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void RunPythonApi()
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"WindowsForm\app.exe"; // Đường dẫn đến tập tin thực thi API Python
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    MessageBox.Show(result);
                }
            }
        }

        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        // Ham goi HTTP Get len server
        public string sendGet(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        // Ham chuyen Image thanh Base 64
        public static string ConvertImageToBase64String(Image image)
        {
            using (MemoryStream ms = new MemoryStream())    
            {

                image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        private void sqlPOST(string responseString)
        {
            JObject jsonObject = JObject.Parse(responseString);
            JArray dataArray = (JArray)jsonObject["attribute"]["data"];


            using (Form2.conn)
            {
                conn.Open();

                // Prepare SQL INSERT statement
                string insertSql = "INSERT INTO YourTableName (address, dob, doe, home, id, name, nationality, sex) " +
                                   "VALUES (@Address, @Dob, @Doe, @Home, @Id, @Name, @Nationality, @Sex)";

                foreach (JToken dataItem in dataArray)
                {
                    using (SqlCommand command = new SqlCommand(insertSql, conn))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Address", dataItem["address"].ToString());
                        command.Parameters.AddWithValue("@Dob", dataItem["dob"].ToString());
                        command.Parameters.AddWithValue("@Doe", dataItem["doe"].ToString());
                        command.Parameters.AddWithValue("@Home", dataItem["home"].ToString());
                        command.Parameters.AddWithValue("@Id", dataItem["id"].ToString());
                        command.Parameters.AddWithValue("@Name", dataItem["name"].ToString());
                        command.Parameters.AddWithValue("@Nationality", dataItem["nationality"].ToString());
                        command.Parameters.AddWithValue("@Sex", dataItem["sex"].ToString());

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }
            }
            DataArray = dataArray;
        }
        // Ham convert B64 de gui len server
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

        // Ham goi HTTP POST len server de detect
        private String sendPOST(String url, String B64)
        {
            try
            {

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 50000;
                var postData = "image=" + EscapeData(B64);

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
                return "Exception" + ex.ToString();
            }
        }


        private string sendPOST_2(string url, string B64, string B64_2)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 100000;

                // Build the POST data with both images
                var postData = "image1=" + EscapeData(B64) + "&image2=" + EscapeData(B64_2);


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


        private void button1_Click(object sender, EventArgs e)
        {

            // Convert image to B64
            String B64 = ConvertImageToBase64String(pictureBox1.Image);
            String B64_2 = ConvertImageToBase64String(pictureBox2.Image); 
            // Goi len server va tra ve ket qua
            String server_ip = "127.0.0.1";
            //String retStr2 = sendPOST_2("http://" + server_ip + ":5000/check", B64, B64_2);
            String retStr = sendPOST("http://" + server_ip + ":5000/translate", B64); 
            CCCD_ID = retStr;
            //MessageBox.Show(retStr2);
            FacePath = "D:\\ImageRealTime\\" + CCCD_ID + ".jpg";
            pictureBox2.Image.Save(FacePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            InformationForm frm = new InformationForm();
            try
            {
                frm.Show();
            }
            catch (ObjectDisposedException ex)
            { 
            }
            //MessageBox.Show(retStr);
            /*try
            {
                // Parse chuỗi JSON thành một đối tượng JObject
                JObject jsonObject = JObject.Parse(retStr);

                // Kiểm tra xem "data" có tồn tại không
                if (jsonObject["data"] != null)
                {
                    // Trích xuất mảng "data"
                    DataArray = (JArray)jsonObject["data"];
/*
                    // Lặp qua từng phần tử trong mảng "data"
                    foreach (JToken dataItem in DataArray)
                    {
                        MessageBox.Show("ID: " + dataItem["id"], "Data Item Info");
                        MessageBox.Show("Name: " + dataItem["name"], "Data Item Info");
                        MessageBox.Show("Date of Birth: " + dataItem["dob"], "Data Item Info");
                        MessageBox.Show("Sex: " + dataItem["sex"], "Data Item Info");
                        MessageBox.Show("Nationality: " + dataItem["nationality"], "Data Item Info");
                        MessageBox.Show("Home Address: " + dataItem["home"], "Data Item Info");
                        MessageBox.Show("Address: " + dataItem["address"], "Data Item Info");
                        MessageBox.Show("Date of Expiration: " + dataItem["doe"], "Data Item Info");
                        MessageBox.Show("Overall Score: " + dataItem["overall_score"], "Data Item Info");
                        MessageBox.Show("", "Data Item Info");
                    } 
                    Form3 frm = new Form3();
                    frm.Show();
                }
                else
                {
                    Console.WriteLine("Không có dữ liệu được tìm thấy trong chuỗi JSON.");
                }
            }
            catch (JsonReaderException ex)
            {
                // Xử lý lỗi khi đọc chuỗi JSON
                Console.WriteLine("Lỗi khi đọc chuỗi JSON: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }*/

            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Resize anh cua picture box 1 de dam bao dung scale
            //        Image image = (Image)(new Bitmap(pictureBox1.Image, new Size(pictureBox1.Width, pictureBox1.Height)));
            //        pictureBox1.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cam1 != null && cam1.IsRunning)
            {
                cam1.Stop();
            }
            cam1 = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam1.NewFrame += Cam_NewFrame1;
            cam1.Start();

        }
        private void Cam_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;

        }
        private void Cam_NewFrame2(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = bitmap;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (cam1 != null && cam1.IsRunning)
            {
                cam1.Stop();
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\Users\\satia\\OneDrive\\Documents";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[comboBox2.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame2;
            cam.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (cam1 != null && cam1.IsRunning)
            {
                cam1.Stop();
            }
            cam1 = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam1.NewFrame += Cam_NewFrame1;
            cam1.Start();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[comboBox2.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame2;
            cam.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            // Convert image to B64
            String B64 = ConvertImageToBase64String(pictureBox1.Image);
            String B64_2 = ConvertImageToBase64String(pictureBox2.Image);
            // Goi len server va tra ve ket qua
            String server_ip = "127.0.0.1";
            //String retStr2 = sendPOST_2("http://" + server_ip + ":5000/check", B64, B64_2);
            String retStr = sendPOST("http://" + server_ip + ":5000/translate", B64);
            CCCD_ID = retStr;
            //MessageBox.Show(retStr2);
            FacePath = "D:\\ImageRealTime\\" + CCCD_ID + ".jpg";
            pictureBox2.Image.Save(FacePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            InformationForm frm = new InformationForm();
            try
            {
                frm.Show();
            }
            catch (ObjectDisposedException ex)
            {
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
    }
} 