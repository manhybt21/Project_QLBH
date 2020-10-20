using DAL;
using DTO;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace BUS
{
    public class BUS_NHANVIEN
    {
        /// <summary>
        /// Mã hoá password về dạng Hash
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encrypdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encrypdata.Append(encrypt[i].ToString("x2"));
            }
            return encrypdata.ToString();
        }
        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public static bool DangNhap(DTO_NHANVIEN nv)
        {
            return DAL_NHANVIEN.DangNhap(nv);
        }
        /// <summary>
        /// Quên mật khẩu
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool QuenMatKhau(string email)
        {
            return DAL_NHANVIEN.QuenMatKhau(email);
        }
        /// <summary>
        /// Tạo mật khẩu mới
        /// </summary>
        /// <param name="email"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public static bool TaoMatKhauMoi(string email, string newPassword)
        {
            return DAL_NHANVIEN.TaoMatKhauMoi(email, newPassword);
        }
        /// <summary>
        /// Lấy vai trò nhân viên sau khi login thành công
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static DataTable LayVaiTroNV(string email)
        {
            return DAL_NHANVIEN.VaiTroNhanVien(email);
        }
        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        /// <param name="email"></param>
        /// <param name="matKhauCu"></param>
        /// <param name="matKhauMoi"></param>
        /// <returns></returns>
        public static bool DoimatKhau(string email,string matKhauCu,string matKhauMoi)
        {
            return DAL_NHANVIEN.UpdateMatKhau(email, matKhauCu, matKhauMoi);
        }
        /// <summary>
        /// Lấy toàn bộ thông tin nhân viên
        /// </summary>
        /// <returns></returns>
        public static DataTable getNhanVien()
        {
            return DAL_NHANVIEN.getNhanVien();
        }
        /// <summary>
        /// Thêm nhân viên mới, mật khẩu sẽ được tạo mới mặc định (Random)
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public static bool insertNhanVien(DTO_NHANVIEN nv)
        {
            return DAL_NHANVIEN.InsertNhanVien(nv);
        }
        /// <summary>
        /// Cập nhật thông tin nhân viên
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public static bool updateNhanVien(DTO_NHANVIEN nv)
        {
            return DAL_NHANVIEN.UpdateNhanVien(nv);
        }
        /// <summary>
        /// Xoá tài khoản nhân viên
        /// #Yêu cầu quyền quản trị
        /// </summary>
        /// <param name="tenDangNhap"></param>
        /// <returns></returns>
        public static bool deleteNhanVien(string tenDangNhap)
        {
            return DAL_NHANVIEN.DeleteNhanVien(tenDangNhap);
        }
        /// <summary>
        /// Tìm kiếm thông tin nhân viên bằng tên nhân viên
        /// </summary>
        /// <param name="tenNhanVien"></param>
        /// <returns></returns>
        public static DataTable SearchNhanVien(string tenNhanVien)
        {
            return DAL_NHANVIEN.SearchNhanVien(tenNhanVien);
        }
    }
}
