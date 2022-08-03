
namespace QuanLyHocSinhUpdate
{
    partial class QuanLyHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaHS = new System.Windows.Forms.TextBox();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbTuoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDanhSachHocSinh
            // 
            this.dtgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHocSinh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgvDanhSachHocSinh.Location = new System.Drawing.Point(12, 178);
            this.dtgvDanhSachHocSinh.MultiSelect = false;
            this.dtgvDanhSachHocSinh.Name = "dtgvDanhSachHocSinh";
            this.dtgvDanhSachHocSinh.ReadOnly = true;
            this.dtgvDanhSachHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachHocSinh.Size = new System.Drawing.Size(871, 409);
            this.dtgvDanhSachHocSinh.TabIndex = 0;
            this.dtgvDanhSachHocSinh.SelectionChanged += new System.EventHandler(this.dtgvDanhSachHocSinh_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học sinh:";
            // 
            // tbMaHS
            // 
            this.tbMaHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHS.Location = new System.Drawing.Point(124, 8);
            this.tbMaHS.Name = "tbMaHS";
            this.tbMaHS.ReadOnly = true;
            this.tbMaHS.Size = new System.Drawing.Size(295, 26);
            this.tbMaHS.TabIndex = 2;
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQueQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQueQuan.Location = new System.Drawing.Point(124, 72);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.Size = new System.Drawing.Size(295, 26);
            this.tbQueQuan.TabIndex = 3;
            // 
            // tbHoTen
            // 
            this.tbHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(124, 40);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(295, 26);
            this.tbHoTen.TabIndex = 4;
            // 
            // tbTuoi
            // 
            this.tbTuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTuoi.Location = new System.Drawing.Point(124, 104);
            this.tbTuoi.Name = "tbTuoi";
            this.tbTuoi.Size = new System.Drawing.Size(295, 26);
            this.tbTuoi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quê quán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tuổi:";
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(478, 86);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 44);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(601, 86);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 44);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(725, 86);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 44);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 599);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTuoi);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.tbQueQuan);
            this.Controls.Add(this.tbMaHS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDanhSachHocSinh);
            this.Name = "QuanLyHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.QuanLyHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDanhSachHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaHS;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbTuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}

