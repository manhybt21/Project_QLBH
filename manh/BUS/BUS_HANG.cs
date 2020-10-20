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
    public class BUS_HANG
    {
        /// <summary>
        /// Trả về datatable chứa dữ liệu toàn bộ hàng hoá
        /// </summary>
        /// <returns></returns>
        public static DataTable getHang()
        {
            return DAL_HANG.getHang();
        }
        /// <summary>
        /// Thêm hàng hoá
        /// </summary>
        /// <param name="hang"></param>
        /// <returns></returns>
        public static bool insertHang(DTO_HANG hang)
        {
            return DAL_HANG.insertHang(hang);
        }
        /// <summary>
        /// Cập nhật thông tin hàng hoá
        /// </summary>
        /// <param name="hang"></param>
        /// <returns></returns>
        public static bool updateHang(DTO_HANG hang) {
            return DAL_HANG.updateHang(hang);
        }
        /// <summary>
        /// Xoá hàng hoá khỏi csdl
        /// #Yêu cầu quyền quản trị
        /// </summary>
        /// <param name="maHang"></param>
        /// <returns></returns>
        public static bool deleteHang(int maHang)
        {
            return DAL_HANG.deleteHang(maHang);
        }
        /// <summary>
        /// Tìm kiếm hàng hoá theo tên
        /// </summary>
        /// <param name="tenHang"></param>
        /// <returns></returns>
        public static DataTable searchHang(string tenHang)
        {
            return DAL_HANG.searchHang(tenHang);
        }
        /// <summary>
        /// Thống kê hàng hoá
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongKeHang()
        {
            return DAL_HANG.ThongKeHang();
        }
        /// <summary>
        /// Thống kê hàng tồn kho
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongKeTonKho()
        {
            return DAL_HANG.ThongKeTonKho();
        }
    }
}
