using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using DTO;
namespace DAL
{
    public class DAL_NHANVIEN 
    {
     
        public static bool DangNhap(DTO_NHANVIEN nv)
        {
            try {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DangNhap";
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("matkhau", nv.matKhau);
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) {
                    return true;                
                }
            }
            catch (Exception) { 
                
            }
            finally
            {
                DBConnected.conn.Close();
            }
            return false;
        }
        public static bool QuenMatKhau(string email)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_QuenMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception) { }
            finally
            {
                DBConnected.conn.Close();
            }
            return false;
        }
        public static bool TaoMatKhauMoi(string email, string newPassword)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("newPassword", newPassword);
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception) { }
            finally
            {
                DBConnected.conn.Close();
            }
            return false;
        }
        public static DataTable VaiTroNhanVien(string email)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_VaiTroNV";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Connection = DBConnected.conn;
                cmd.ExecuteNonQuery();
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }   
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool UpdateMatKhau(string email,string matKhauCu,string matKhauMoi)
        {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ChangePassWord";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("oldPassword",matKhauCu);
                cmd.Parameters.AddWithValue("newPassword", matKhauMoi);
                cmd.ExecuteNonQuery();
                    return true;
            }
            catch (Exception) { }
            finally
            {
                DBConnected.conn.Close();
            }
            return false;
        }
        public static DataTable getNhanVien()
        {
            try {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachNhanVien";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool InsertNhanVien(DTO_NHANVIEN nv) {
            try {
               DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = DBConnected.conn;
                cmd.CommandText = "sp_InsertNHANVIEN";
                cmd.Parameters.AddWithValue("Email", nv.Email);
                cmd.Parameters.AddWithValue("HoVaTen", nv.tenNV);
                cmd.Parameters.AddWithValue("DiaChi", nv.diaChi);
                cmd.Parameters.AddWithValue("VaiTro", nv.vaiTro);
                cmd.Parameters.AddWithValue("TinhTrang", nv.tinhTrang);
                cmd.ExecuteNonQuery();
                return true;
                }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool UpdateNhanVien(DTO_NHANVIEN nv) {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateNHANVIEN";
                cmd.Parameters.AddWithValue("HoVaTen", nv.tenNV);
                cmd.Parameters.AddWithValue("Email", nv.Email);
                cmd.Parameters.AddWithValue("DiaChi", nv.diaChi);
                cmd.Parameters.AddWithValue("VaiTro", nv.vaiTro);
                cmd.Parameters.AddWithValue("TinhTrang", nv.tinhTrang);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static bool DeleteNhanVien(string email) {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnected.conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteNHANVIEN";
                cmd.Parameters.AddWithValue("email", email);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                DBConnected.conn.Close();
            }
        }
        public static DataTable SearchNhanVien(string tenNhanVien) {
            try
            {
                DBConnected.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = DBConnected.conn;
                cmd.CommandText = "sp_SearchNhanVien";
                cmd.Parameters.AddWithValue("tenNv", tenNhanVien);
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
