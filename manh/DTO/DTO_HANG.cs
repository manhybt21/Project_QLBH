using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HANG
    {
        public int maHang { get; set; }
        public string tenHang { get; set; }
        public int soLuong { get; set; }
        public float giaNhap { get; set; }
        public float giaBan { get; set; }
        public string hinhAnh { get; set; }
        public string ghiChu { get; set; }
        public string emailNV { get; set; }

        public DTO_HANG(string tenHang, int soLuong, float giaNhap, float giaBan, string hinhAnh, string ghiChu, string emailNV)
        {
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.giaNhap = giaNhap;
            this.giaBan = giaBan;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            this.emailNV = emailNV;
        }

        public DTO_HANG()
        {
        }
    }
}
