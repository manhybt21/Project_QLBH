using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_KHACH
    {
        public static DataTable getKhach()
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachKhachHang";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;

            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool insertKhach(DTO_KHACH khach)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertKHACH";
                cmd.Parameters.AddWithValue("DienThoai",khach.dienThoai);
                cmd.Parameters.AddWithValue("TenKhach",khach.tenKhach);
                cmd.Parameters.AddWithValue("DiaChi",khach.diaChi);
                cmd.Parameters.AddWithValue("GioiTinh",khach.gioiTinh);
                cmd.Parameters.AddWithValue("email", khach.emailNV);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool updateKhach(DTO_KHACH khach)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateKHACH";
                cmd.Parameters.AddWithValue("DienThoai",khach.dienThoai);
                cmd.Parameters.AddWithValue("TenKhach",khach.tenKhach);
                cmd.Parameters.AddWithValue("DiaChi",khach.diaChi);
                cmd.Parameters.AddWithValue("email",khach.emailNV);
                cmd.Parameters.AddWithValue("GioiTinh",khach.gioiTinh);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool deleteKhach(string soDienThoai)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteKHACH";
                cmd.Parameters.AddWithValue("DienThoai", soDienThoai);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static DataTable searchKhach(string tenKhach)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchKhachHang";
                cmd.Parameters.AddWithValue("tenKhach", tenKhach);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;

            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
    }
}
