using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocSinh
    {
        private string _MaHS;
        public string MaHS { get { return _MaHS; } set { _MaHS = value; } }
        private string _HoTen;
        public string HoTen { get { return _HoTen; } set { _HoTen = value; } }
        private string _QueQuan;
        public string QueQuan { get { return _QueQuan; } set { _QueQuan = value; } }
        private int _Tuoi;
        public int Tuoi { get { return _Tuoi; } set { _Tuoi = value; } }

        public DTO_HocSinh() { }


        public DTO_HocSinh(string maHS, string hoTen, string queQuan, int tuoi)
        {
            this.MaHS = maHS;
            this.HoTen = hoTen;
            this.QueQuan = queQuan;
            this.Tuoi = tuoi;
        }
    }
}
