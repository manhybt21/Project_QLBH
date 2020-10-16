using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public static class DBConnected
    {
        internal static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QLBanHang"].ToString());
    }
}
