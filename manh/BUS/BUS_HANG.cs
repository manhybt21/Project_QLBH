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
        public static DataTable getHang()
        {
            return DAL_HANG.getHang();
        }
        public static bool insertHang(DTO_HANG hang)
        {
            return DAL_HANG.insertHang(hang);
        }
        public static bool updateHang(DTO_HANG hang) {
            return DAL_HANG.updateHang(hang);
        }
        public static bool deleteHang(int maHang)
        {
            return DAL_HANG.deleteHang(maHang);
        }
        public static DataTable searchHang(string tenHang)
        {
            return DAL_HANG.searchHang(tenHang);
        }
        public static DataTable ThongKeHang()
        {
            return DAL_HANG.ThongKeHang();
        }
        public static DataTable ThongKeTonKho()
        {
            return DAL_HANG.ThongKeTonKho();
        }
    }
}
