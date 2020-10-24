using System;
using System.Diagnostics.Eventing.Reader;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;

namespace TestDangNhap
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDangNhap001()
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN();
            nv.Email = " ";
            nv.matKhau = "123456";
            bool result = BUS_NHANVIEN.DangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestDangNhap002()
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN();
            nv.Email = "admin@gmail.com";
            nv.matKhau = " ";
            bool result = BUS_NHANVIEN.DangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestDangNhap003()
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN();
            nv.Email = "admin@gmail.com";
            nv.matKhau = "654321";
            bool result = BUS_NHANVIEN.DangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestDangNhap004()
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN();
            nv.Email = "admin@gmail.com";
            nv.matKhau = "123456";
            bool result = BUS_NHANVIEN.DangNhap(nv);
            Assert.IsTrue(result);
        }
    }
}
