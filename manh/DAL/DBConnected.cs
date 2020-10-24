using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DBConnected
    {/*@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|QLBanHang.mdf;Integrated Security = True"*/

        static string connstr = ConfigurationManager.ConnectionStrings["DuAnMau"].ToString(); 
        internal static SqlConnection conn = new SqlConnection(connstr);
    }
}
