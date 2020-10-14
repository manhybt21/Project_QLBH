using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HANG
    {
        public static DataTable getHang()
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachHang";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool insertHang(DTO_HANG hang)
        {
            try {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertHANG";
                cmd.Parameters.AddWithValue("TenHang", hang.tenHang);
                cmd.Parameters.AddWithValue("SoLuong",hang.soLuong);
                cmd.Parameters.AddWithValue("GiaNhap",hang.giaNhap);
                cmd.Parameters.AddWithValue("GiaBan",hang.giaBan);
                cmd.Parameters.AddWithValue("HinhAnh",hang.hinhAnh);
                cmd.Parameters.AddWithValue("GhiChu",hang.ghiChu);
                cmd.Parameters.AddWithValue("Email",hang.emailNV);
                cmd.ExecuteNonQuery();
                return true;

            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool updateHang(DTO_HANG hang)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateHANG";
                cmd.Parameters.AddWithValue("TenHang",hang.tenHang);
                cmd.Parameters.AddWithValue("SoLuong",hang.soLuong);
                cmd.Parameters.AddWithValue("GiaNhap", hang.giaNhap);
                cmd.Parameters.AddWithValue("GiaBan", hang.giaBan);
                cmd.Parameters.AddWithValue("HinhAnh", hang.hinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", hang.ghiChu);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool deleteHang(int maHang)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteHANG";
                cmd.Parameters.AddWithValue("MaHang", maHang);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static DataTable searchHang(string tenHang)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchHang";
                cmd.Parameters.AddWithValue("TenHang", tenHang);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static DataTable ThongKeHang()
        {
            DBConnected.conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnected.conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ThongKeSp";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public static DataTable ThongKeTonKho()
        {
            DBConnected.conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnected.conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ThongKeTonKho";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
    }
}
