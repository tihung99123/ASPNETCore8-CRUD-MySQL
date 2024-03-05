using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly DatabaseContext _db;
        public SinhVienController(DatabaseContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<SinhVienModel> listObj = _db.SinhVien;
            return View(listObj);
        }
        // GET
        public IActionResult Create() 
        { 
            return View();
        }
        // POST
        [HttpPost]
        public IActionResult Create(SinhVienModel obj)
        {
            _db.SinhVien.Add(obj);
            _db.SaveChanges();
            return Redirect("Index");
        }
        // GET
        public IActionResult Edit(int? maSinhVien)
        {
            if (maSinhVien == null || maSinhVien == 0)
            {
                return NotFound();
            }
            var obj_SinhVien = _db.SinhVien.SingleOrDefault(u => u.MaSinhVien == maSinhVien);
            if (obj_SinhVien == null)
            {
                return NotFound();
            }
            return View(obj_SinhVien);
        }
        // POST
        [HttpPost]
        public IActionResult Edit(SinhVienModel obj)
        {
            _db.SinhVien.Update(obj);
            _db.SaveChanges();
            return Redirect("Index");
        }
        // GET
        public IActionResult Delete(int? maSinhVien)
        {
            if (maSinhVien == null || maSinhVien == 0)
            {
                return NotFound();
            }
            var obj_SinhVien = _db.SinhVien.SingleOrDefault(u => u.MaSinhVien == maSinhVien);
            if (obj_SinhVien == null)
            {
                return NotFound();
            }
            _db.Remove(obj_SinhVien);
            _db.SaveChanges();
            return Redirect("Index");
        }


    }
}
