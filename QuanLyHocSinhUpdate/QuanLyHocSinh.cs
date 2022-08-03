using System.Runtime.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Xml;

namespace QuanLyHocSinhUpdate
{
    public partial class QuanLyHocSinh : Form
    {
        private string pathConfig = @"..\..\Config.xml";
        XmlDocument doc = new XmlDocument();
        string UrlAdd, UrlDel, UrlUp, UrlGet;

        public QuanLyHocSinh()
        {
            InitializeComponent();
            doc.Load(pathConfig);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                switch (node.Attributes["id"].Value)
                {
                    case "addStudent":
                        UrlAdd = node.InnerText;
                        break;
                    case "deleteStudent":
                        UrlDel = node.InnerText;
                        break;
                    case "updateStudent":
                        UrlUp = node.InnerText;
                        break;
                    case "getStudents":
                        UrlGet = node.InnerText;
                        break;
                }
            }
        }

        private void RefreshList()
        {
            WebClient proxy = new WebClient();
            proxy.DownloadStringAsync(new Uri(UrlGet));
            proxy.DownloadStringCompleted += proxy_DownloadStringCompleted;
        }

        private void proxy_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Stream stream = new MemoryStream(Encoding.Default.GetBytes(e.Result));
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<DTO_HocSinh>));
            List<DTO_HocSinh> result = obj.ReadObject(stream) as List<DTO_HocSinh>;


            dtgvDanhSachHocSinh.DataSource = result;
        }

        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            RefreshList();
            ClearUI();
        }

        private void dtgvDanhSachHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDanhSachHocSinh.SelectedRows.Count <= 0)
                return;

            DataGridViewRow row = dtgvDanhSachHocSinh.SelectedRows[0];

            tbMaHS.Text = row.Cells[0].Value.ToString().Trim();
            tbHoTen.Text = row.Cells[1].Value.ToString().Trim();
            tbQueQuan.Text = row.Cells[2].Value.ToString().Trim();
            tbTuoi.Text = row.Cells[3].Value.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaHSMoi = "";
            int maxNumber = 0;

            if (dtgvDanhSachHocSinh.Rows.Count <= 0)
                MaHSMoi = "HS1";
            else
                foreach (DataGridViewRow row in dtgvDanhSachHocSinh.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;

                    string MaHS = row.Cells[0].Value.ToString().Trim();
                    string[] array = MaHS.Split(new[] { "HS" }, StringSplitOptions.None);
                    maxNumber = Math.Max(int.Parse(array[1]) + 1, maxNumber);
                    MaHSMoi = "HS" + maxNumber.ToString();
                }

            int Tuoi = String.IsNullOrEmpty(tbTuoi.Text.Trim()) ? 0 : int.Parse(tbTuoi.Text);
            DTO_HocSinh hs = new DTO_HocSinh(MaHSMoi, tbHoTen.Text.Trim(), tbQueQuan.Text.Trim(), Tuoi);

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DTO_HocSinh));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, hs);
            string data = Encoding.Default.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.Default;
            
            string message = webClient.UploadString(UrlAdd, "POST", data);

            if (message == "true")
            {
                MessageBox.Show("Thêm học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList();
                ClearUI();
            }
            else
                MessageBox.Show("Thêm học sinh không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearUI();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(string));
            ser.WriteObject(ms, tbMaHS.Text);

            // invoke the REST method    
            byte[] data = client.UploadData(UrlDel, "DELETE", ms.ToArray());

            string message = Encoding.Default.GetString(data);

            if (message == "true")
            {
                MessageBox.Show("Xóa học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearUI();
                RefreshList();
            }
            else
                MessageBox.Show("Xóa học sinh không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaHS = tbMaHS.Text.Trim();
            string HoTen = tbHoTen.Text.Trim();
            string QueQuan = tbQueQuan.Text.Trim();
            int Tuoi = String.IsNullOrEmpty(tbTuoi.Text.Trim()) ? 0 : int.Parse(tbTuoi.Text);
            DTO_HocSinh hs = new DTO_HocSinh(MaHS, HoTen, QueQuan, Tuoi);


            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";

            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DTO_HocSinh));
            ser.WriteObject(ms, hs);

            // invoke the REST method    
            byte[] data= client.UploadData(UrlUp, "PUT", ms.ToArray());

            string message = Encoding.Default.GetString(data);

            if (message == "true")
            {
                MessageBox.Show("Sửa thông tin học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList();
                ClearUI();
            }
            else
                MessageBox.Show("Sửa thông tin học sinh không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ClearUI()
        {
            tbMaHS.Text = String.Empty;
            tbHoTen.Text = String.Empty;
            tbQueQuan.Text = String.Empty;
            tbTuoi.Text = String.Empty;

            //dtgvDanhSachHocSinh.ClearSelection();
            foreach (DataGridViewRow row in dtgvDanhSachHocSinh.Rows)
                row.Selected = false;
        }
    }
}
