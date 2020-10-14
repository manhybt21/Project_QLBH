using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHACH
    {
       public string dienThoai { get; set; }
       public string tenKhach { get; set; }
       public string diaChi { get; set; }
       public string gioiTinh { get; set; }
       public string maNV { get; set; }
       public string emailNV { get; set; }

        public DTO_KHACH(string dienThoai, string tenKhach, string diaChi, string emailNV, string gioiTinh)
        {
            this.dienThoai = dienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.emailNV = emailNV;
        }

        public DTO_KHACH()
        {
        }
    }
}
