using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=VUONG\SQLSERVERDB;Initial Catalog=QuanLyHocSinh;Persist Security Info=True;User ID=sa;Password=123456");
    }
}
