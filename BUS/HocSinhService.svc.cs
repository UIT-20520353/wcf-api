using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using DTO;
using DAL;
using System.Data;

namespace BUS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HocSinhService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HocSinhService.svc or HocSinhService.svc.cs at the Solution Explorer and start debugging.
    public class HocSinhService : IHocSinhService
    {
        DAL_HocSinh dal = new DAL_HocSinh();
        public List<DTO_HocSinh> LayDanhSachHocSinh()
        {
            List<DTO_HocSinh> DanhSachHocSinh = new List<DTO_HocSinh>();

            DataTable dt = dal.LayDanhSachHocSinh();

            foreach (DataRow row in dt.Rows)
            {
                string MaHs = row.ItemArray[0].ToString();
                string hoten = row.ItemArray[1].ToString();
                string quequan = row.ItemArray[2].ToString();
                int tuoi = int.Parse(row.ItemArray[3].ToString());

                DTO_HocSinh hs = new DTO_HocSinh(MaHs, hoten, quequan, tuoi);
                DanhSachHocSinh.Add(hs);
            }

            return DanhSachHocSinh;
        }

        public bool ThemHocSinh(DTO_HocSinh hs)
        {
            return dal.ThemHocSinh(hs);
        }

        public bool XoaHocSinh(String id)
        {
            return dal.XoaHocSinh(id);
        }

        public bool SuaHocSinh(DTO_HocSinh hs)
        {
            return dal.SuaHocSinh(hs);
        }
    }
}
