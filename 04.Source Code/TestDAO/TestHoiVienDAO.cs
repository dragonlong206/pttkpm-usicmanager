using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using DAO;
using DTO;

namespace TestDAO
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestHoiVienDAO
    {
        public TestHoiVienDAO()
        {
            //
            // TODO: Add constructor logic here
            //
            SqlDataAccessHelper.fileAddress = "../../ConnectionString.xml";
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestThemHoiVien1()
        {
            HoiVienDTO hoiVienDTO = new HoiVienDTO();
            hoiVienDTO.HoTen = "Lê Văn Long";
            hoiVienDTO.MSSV = "0712255";
            hoiVienDTO.GioiTinh = 0;

            HoiVienDAO hoiVienDAO = new HoiVienDAO();
            Assert.IsTrue(hoiVienDAO.ThemMoiHoiVien(hoiVienDTO));
        }

        [TestMethod]
        public void TestCapNhatHoiVien1()
        {
            HoiVienDTO hoiVienDTO = new HoiVienDTO();
            hoiVienDTO.ID = 1;
            hoiVienDTO.HoTen = "Nguyễn Bảo Long";
            hoiVienDTO.GioiTinh = 1;

            HoiVienDAO hoiVienDAO = new HoiVienDAO();
            Assert.IsTrue(hoiVienDAO.CapNhatHoiVien(hoiVienDTO));
        }

        [TestMethod]
        public void TestLayDanhSachHoiVien1()
        {
            HoiVienDAO hoiVienDAO = new HoiVienDAO();
            DataTable danhSachHoiVien = hoiVienDAO.LayDanhSachTatCaHoiVien();
            Assert.IsTrue(danhSachHoiVien.Rows.Count > 0);
        }

        [TestMethod]
        public void TestLayDanhSachHoiVienTheoTen1()
        {
            HoiVienDAO hoiVienDAO = new HoiVienDAO();
            DataTable danhSachHoiVien = hoiVienDAO.LayDanhSachHoiVienTheoHoTen("Long");
            Assert.IsTrue(danhSachHoiVien.Rows.Count > 0);
        }

        [TestMethod]
        public void TestLayDanhSachHoiVienTheoMSSV1()
        {
            HoiVienDAO hoiVienDAO = new HoiVienDAO();
            DataTable danhSachHoiVien = hoiVienDAO.LayHoiVienTheoMSSV("0712255");
            Assert.IsTrue(danhSachHoiVien.Rows.Count > 0);
        }

        [TestMethod]
        public void TestXoaHoiVien1()
        {
            HoiVienDAO hoiVienDAO = new HoiVienDAO();
            Assert.IsTrue(hoiVienDAO.XoaHoiVien(1));
        }
    }
}
