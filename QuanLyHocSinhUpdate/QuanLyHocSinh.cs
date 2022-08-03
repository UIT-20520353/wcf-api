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

namespace QuanLyHocSinhUpdate
{
    public partial class QuanLyHocSinh : Form
    {
        public QuanLyHocSinh()
        {
            InitializeComponent();
        }

        private void RefreshList()
        {
            WebClient proxy = new WebClient();
            proxy.DownloadStringAsync(new Uri("http://localhost/StudentsService/HocSinhService.svc/GetStudents"));
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

            if (dtgvDanhSachHocSinh.Rows[0].Cells[0].Value == null)
                MaHSMoi = "HS1";
            else
                foreach (DataGridViewRow row in dtgvDanhSachHocSinh.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;

                    string MaHS = row.Cells[0].Value.ToString().Trim();
                    string[] array = MaHS.Split(new[] { "HS" }, StringSplitOptions.None);
                    int a = int.Parse(array[1]) + 1;
                    MaHSMoi = "HS" + a.ToString();
                }


            DTO_HocSinh hs = new DTO_HocSinh(MaHSMoi, tbHoTen.Text.Trim(), tbQueQuan.Text.Trim(), int.Parse(tbTuoi.Text));

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DTO_HocSinh));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, hs);
            string data = Encoding.Default.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.Default;
            webClient.UploadString("http://localhost/StudentsService/HocSinhService.svc/AddNewStudent", "POST", data);
            MessageBox.Show("Thêm học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearUI();
            RefreshList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";

            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(string));
            ser.WriteObject(ms, tbMaHS.Text);

            // invoke the REST method    
            byte[] data = client.UploadData("http://localhost/StudentsService/HocSinhService.svc/DeleteStudent", "DELETE", ms.ToArray());

            MessageBox.Show("Xóa học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearUI();
            RefreshList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaHS = tbMaHS.Text.Trim();
            string HoTen = tbHoTen.Text.Trim();
            string QueQuan = tbQueQuan.Text.Trim();
            int Tuoi = int.Parse(tbTuoi.Text.Trim());
            DTO_HocSinh hs = new DTO_HocSinh(MaHS, HoTen, QueQuan, Tuoi);


            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";

            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DTO_HocSinh));
            ser.WriteObject(ms, hs);

            // invoke the REST method    
            client.UploadData("http://localhost/StudentsService/HocSinhService.svc/UpdateStudent", "PUT", ms.ToArray());

            MessageBox.Show("Sửa thông tin học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearUI();
            RefreshList();
        }

        private void ClearUI()
        {
            tbMaHS.Text = String.Empty;
            tbHoTen.Text = String.Empty;
            tbQueQuan.Text = String.Empty;
            tbTuoi.Text = String.Empty;
        }
    }
}
