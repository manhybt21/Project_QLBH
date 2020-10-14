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
        public static DataTable getKhach()
        {
            return DAL_KHACH.getKhach();
        }
        public static bool insertKhach(DTO_KHACH khach)
        {
            return DAL_KHACH.insertKhach(khach);
        }
        public static bool updateKhach(DTO_KHACH khach)
        {
            return DAL_KHACH.updateKhach(khach);
        }
        public static bool deleteKhach(string soDienThoai)
        {
            return DAL_KHACH.deleteKhach(soDienThoai);
        }
        public static DataTable searchKhach(string tenKhach)
        {
            return DAL_KHACH.searchKhach(tenKhach);
        }
    }
}
