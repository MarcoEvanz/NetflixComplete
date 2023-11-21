using Netflix2.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
                if (String.IsNullOrEmpty(phim.TenPhim) || phim.TenPhim.Length < 1 || phim.TenPhim.Length > 50)
                    ModelState.AddModelError(String.Empty, "Tên Phim không được để trống và phải có ít nhất 1 ký tự, không quá 50 ký tự");
                if (String.IsNullOrEmpty(phim.URLPhim))
                    ModelState.AddModelError(String.Empty, "Url không được để trống");
                if (String.IsNullOrEmpty(phim.HinhMinhHoa))
                    ModelState.AddModelError(String.Empty, "Hình minh họa không được để trống");
                if (String.IsNullOrEmpty(phim.ThoiLuong))
                    ModelState.AddModelError(String.Empty, "Thời lượng không được để trống");         
                else
                {
                    if (!TimeSpan.TryParse(phim.ThoiLuong, out _))
                    {
                        ModelState.AddModelError("ThoiLuong", "Thời Lượng không hợp lệ. Hãy nhập giá trị kiểu thời gian đúng.");
                    }
                }
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
                var existingEmail = database.KhachHangs.FirstOrDefault(k => k.Email == khachHang.Email);
                if (existingEmail != null)
                {
                    ModelState.AddModelError(String.Empty, "Địa chỉ Email đã được sử dụng, vui lòng chọn địa chỉ Email khác.");
                }
                if (String.IsNullOrEmpty(khachHang.TenDangNhap) || khachHang.TenDangNhap.Length < 1 || !Regex.IsMatch(khachHang.TenDangNhap, "^[a-zA-Z0-9 ]*$"))
                {
                    ModelState.AddModelError(String.Empty, "Tên Đăng Nhập không hợp lệ");
                }

                if (String.IsNullOrEmpty(khachHang.HoTenKH) || khachHang.HoTenKH.Length < 1 )
                {
                    ModelState.AddModelError(String.Empty, "Họ Và Tên không hợp lệ");
                }

                if (String.IsNullOrEmpty(khachHang.Email) || !Regex.IsMatch(khachHang.Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    ModelState.AddModelError(String.Empty, "Email không hợp lệ");
                }

                if (String.IsNullOrEmpty(khachHang.MatKhau))
                {
                    ModelState.AddModelError(String.Empty, "Mật Khẩu không được để trống");
                }

                if (ModelState.IsValid)
                {
                    database.KhachHangs.Add(khachHang);
                    database.SaveChanges();
                    return RedirectToAction("QuanLyUser");
                }
            }

            // Nếu ModelState không hợp lệ, quay lại view để hiển thị lỗi
            return View();
        }
        public ActionResult SuaUser(int Id)
        {
            XemPhimEntities database = new XemPhimEntities();
            KhachHang e = database.KhachHangs.Where(i => i.MaKH == Id).FirstOrDefault();

            if (e != null)
            {
                // Kiểm tra hợp lệ cho email, họ tên và tên đăng nhập
                if (String.IsNullOrEmpty(e.TenDangNhap) || e.TenDangNhap.Length < 1 || !Regex.IsMatch(e.TenDangNhap, "^[a-zA-Z0-9 ]*$"))
                {
                    ModelState.AddModelError(String.Empty, "Tên Đăng Nhập không hợp lệ");
                }

                if (String.IsNullOrEmpty(e.HoTenKH) || e.HoTenKH.Length < 1)
                {
                    ModelState.AddModelError(String.Empty, "Họ Và Tên không hợp lệ");
                }

                if (String.IsNullOrEmpty(e.Email) || !e.Email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                {
                    ModelState.AddModelError(String.Empty, "Email không hợp lệ. Vui lòng nhập lại email");
                }

                return View(e);
            }

            database.Dispose();
            return RedirectToAction("QuanLyUser");
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