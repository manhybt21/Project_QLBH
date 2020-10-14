using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NHANVIEN
    {

        public int ID { get; set; }
        public string MaNV { get; set; }
        public string Email { get; set; }
        public string tenNV { get; set; }
        public string diaChi { get; set; }
        public int vaiTro { get; set; }
        public int tinhTrang { get; set; }
        public string matKhau { get; set; }
        //public DTO_NHANVIEN(int id, string maNV, string Email, string tenNV, string diachi, bool vaiTro, string tinhtrang, string matKhau)
        //{
        //    this.ID = id;
        //    this.MaNV = maNV;
        //    this.Email = Email;
        //    this.tenNV = tenNV;
        //    this.diaChi = diachi;
        //    this.vaiTro = vaiTro;
        //    this.tinhTrang = tinhtrang;
        //    this.matKhau = matKhau;
        //}

        public DTO_NHANVIEN()
        {
        }

        public DTO_NHANVIEN(string emaiNV, string tenNV, string diaChiNV, int role, int tinhTrang)
        {
            this.Email = emaiNV;
            this.tenNV = tenNV;
            this.diaChi = diaChiNV;
            this.vaiTro = role;
            this.tinhTrang = tinhTrang;
        }
    }
}
