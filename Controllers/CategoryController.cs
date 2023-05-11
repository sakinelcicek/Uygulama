using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ders2.Models;
using Microsoft.AspNetCore.Mvc;
//using ders2.Models;

namespace ders2.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ShopContext veritabani;
        public CategoryController(ShopContext context)
        {
            this.veritabani=context;
        }

        public IActionResult Index()
        {
            var kategoriler=veritabani.Categories.ToList();
            return View(kategoriler);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
         [HttpPost]
        public IActionResult Add(Category kategori)
        {
            veritabani.Categories.Add(kategori);
            veritabani.SaveChanges();
            return RedirectToAction("Index");
        }
          public IActionResult Remove(int id)
        {
            var silinecekKategori=veritabani.Categories.Find(id);
            veritabani.Categories.Remove(silinecekKategori);
            veritabani.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}