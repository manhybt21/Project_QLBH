using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_KHACH
    {
        /// <summary>
        /// Lấy toàn bộ thông tin khách hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable getKhach()
        {
            return DAL_KHACH.getKhach();
        }
        /// <summary>
        /// Thêm khách hàng mới
        /// </summary>
        /// <param name="khach"></param>
        /// <returns></returns>
        public static bool insertKhach(DTO_KHACH khach)
        {
            return DAL_KHACH.insertKhach(khach);
        }
        /// <summary>
        /// Cập nhật thông tin khách hàng
        /// </summary>
        /// <param name="khach"></param>
        /// <returns></returns>
        public static bool updateKhach(DTO_KHACH khach)
        {
            return DAL_KHACH.updateKhach(khach);
        }
        /// <summary>
        /// Xoá khách hàng có số điện thoại nhập vào
        /// #Yêu cầu quyền quản trị
        /// </summary>
        /// <param name="soDienThoai"></param>
        /// <returns></returns>
        public static bool deleteKhach(string soDienThoai)
        {
            return DAL_KHACH.deleteKhach(soDienThoai);
        }
        /// <summary>
        /// Tìm kiếm khách hàng bằng tên khách
        /// </summary>
        /// <param name="tenKhach"></param>
        /// <returns></returns>
        public static DataTable searchKhach(string tenKhach)
        {
            return DAL_KHACH.searchKhach(tenKhach);
        }
    }
}
