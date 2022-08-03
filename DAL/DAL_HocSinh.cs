using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HocSinh : DBConnect
    {
        public DataTable LayDanhSachHocSinh()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HOCSINH", _conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public bool ThemHocSinh(DTO_HocSinh hs)
        {
            try
            {
                if (String.IsNullOrEmpty(hs.HoTen) || String.IsNullOrEmpty(hs.QueQuan))
                    return false;

                _conn.Open();

                string SQL = string.Format("INSERT INTO HOCSINH(MaHS, HoTen, QueQuan, Tuoi) VALUES ('{0}', N'{1}', N'{2}', {3})", hs.MaHS, hs.HoTen, hs.QueQuan, hs.Tuoi);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool XoaHocSinh(string id)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("delete from HOCSINH where MaHS = '" + id + "'");

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool SuaHocSinh(DTO_HocSinh hs)
        {
            try
            {
                _conn.Open();

                if (String.IsNullOrEmpty(hs.HoTen) || String.IsNullOrEmpty(hs.QueQuan))
                    return false;

                string SQL = string.Format("update HOCSINH set HoTen = N'{1}', QueQuan = N'{2}', Tuoi = {3} where MaHS = '{0}'", hs.MaHS, hs.HoTen, hs.QueQuan, hs.Tuoi);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
    }
}
