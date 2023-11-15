using Netflix2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Netflix2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        XemPhimEntities database = new XemPhimEntities();
        // GET: Admin
        //Hiện thông tin các bộ Phim
        public ActionResult QuanLyPhim()
        {
            using (var dbContext = new XemPhimEntities())
            {
                var items = dbContext.Phims.ToList();
                return View(items);
            }
        }

        public ActionResult AddPhim(Phim phim)
        {
            if (ModelState.IsValid)
            {
                if (String.IsNullOrEmpty(phim.TenPhim))
                    ModelState.AddModelError(String.Empty, "Tên Phim không được để trống");
                if (String.IsNullOrEmpty(phim.URLPhim))
                    ModelState.AddModelError(String.Empty, "Url không được để trống");
                if (String.IsNullOrEmpty(phim.HinhMinhHoa))
                    ModelState.AddModelError(String.Empty, "Hình minh họa không được để trống");
                if (String.IsNullOrEmpty(phim.ThoiLuong))
                    ModelState.AddModelError(String.Empty, "Thời Lượng không được để trống");

                if (ModelState.IsValid)
                {
                    database.Phims.Add(phim);
                    database.SaveChanges();
                }
                else
                {
                    return View();
                }
            }
            return RedirectToAction("QuanLyPhim");
        }
        public ActionResult SuaPhim(int Id)
        {
            XemPhimEntities database = new XemPhimEntities();
            Phim e = database.Phims.Where(i => i.IdPhim == Id).FirstOrDefault();

            database.Dispose();
            return View(e);
        }
        public ActionResult LuuPhim(Phim s)
        {
            XemPhimEntities database = new XemPhimEntities();
            Phim e = database.Phims.Where(i => i.IdPhim == s.IdPhim).FirstOrDefault();
            e.TieuDe = s.TieuDe;
            e.ChiTietPhim = s.ChiTietPhim;
            e.TenPhim = s.TenPhim;
            e.URLPhim = s.URLPhim;
            e.NamSanXuat = s.NamSanXuat;
            e.ChiTietPhim = s.ChiTietPhim;
            e.DaoDien = s.DaoDien;
            e.DienVien = s.DienVien;
            e.HinhMinhHoa = s.HinhMinhHoa;
            e.TheLoai = s.TheLoai;
            database.SaveChanges();
            database.Dispose();
            return Redirect("QuanLyPhim");
        }
        public ActionResult XoaPhim(int Id)
        {
            XemPhimEntities database = new XemPhimEntities();
            Phim e = database.Phims.Where(i => i.IdPhim == Id).FirstOrDefault();

            database.Dispose();
            return View(e);
        }
        public ActionResult XacNhanXoaPhim(Phim s)
        {
            XemPhimEntities database = new XemPhimEntities();
            Phim e = database.Phims.Where(i => i.IdPhim == s.IdPhim).FirstOrDefault();

            database.Phims.Remove(e);
            database.SaveChanges();
            database.Dispose();
            return Redirect("QuanLyPhim");
        }
        public ActionResult QuanLyUser()
        {
            using (var dbContext = new XemPhimEntities())
            {
                var items = dbContext.KhachHangs.ToList();

                return View(items);
            }
        }
        public ActionResult AddUser(KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                if (String.IsNullOrEmpty(khachHang.TenDangNhap))
                    ModelState.AddModelError(String.Empty, "Tên Đăng Nhập không được để trống");
                if (String.IsNullOrEmpty(khachHang.HoTenKH))
                    ModelState.AddModelError(String.Empty, "Họ Và Tên không được để trống");
                if (String.IsNullOrEmpty(khachHang.MatKhau))
                    ModelState.AddModelError(String.Empty, "Mật Khẩu không được để trống");
                if (String.IsNullOrEmpty(khachHang.Email))
                    ModelState.AddModelError(String.Empty, "Email không được để trống");

                if (ModelState.IsValid)
                {
                    database.KhachHangs.Add(khachHang);
                    database.SaveChanges();
                }
                else
                {
                    return View();
                }
            }
            return RedirectToAction("QuanLyUser");
        }
        public ActionResult SuaUser(int Id)
        {
            XemPhimEntities database = new XemPhimEntities();
            KhachHang e = database.KhachHangs.Where(i => i.MaKH == Id).FirstOrDefault();

            database.Dispose();
            return View(e);
        }
        public ActionResult LuuUser(KhachHang s)
        {
            XemPhimEntities database = new XemPhimEntities();
            KhachHang e = database.KhachHangs.Where(i => i.MaKH == s.MaKH).FirstOrDefault();
            e.TenDangNhap = s.TenDangNhap;
            e.HoTenKH = s.HoTenKH;
            e.MatKhau = s.MatKhau;
            e.Email = s.Email;

            database.SaveChanges();
            database.Dispose();
            return Redirect("QuanLyUser");
        }
        public ActionResult XoaUser(int Id)
        {
            XemPhimEntities database = new XemPhimEntities();
            KhachHang e = database.KhachHangs.Where(i => i.MaKH == Id).FirstOrDefault();

            database.Dispose();
            return View(e);
        }
        public ActionResult XacNhanXoaUser(KhachHang s)
        {
            XemPhimEntities database = new XemPhimEntities();
            KhachHang e = database.KhachHangs.Where(i => i.MaKH == s.MaKH).FirstOrDefault();

            database.KhachHangs.Remove(e);
            database.SaveChanges();
            database.Dispose();
            return Redirect("QuanLyUser");
        }
    }
}