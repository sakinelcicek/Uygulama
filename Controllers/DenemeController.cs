using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using ders2.Models;

namespace ders2.Controllers
{
    public class DenemeController : Controller
    {
        public DenemeController()
        {
        }

        public IActionResult Index()
        {
            string isimler="";
            List<string>Liste=new List<string>();
            Liste.Add("Sakin");
            Liste.Add("ahmet");
            Liste.Add("Erdem");
            Liste.Add("furkan");
            Liste.Remove("erdem");
            int index=Liste.IndexOf("Sakin");
            Liste[index]="Sakin elçiçek";
            foreach (var x in Liste)
            {
                isimler+=x+"-";
            }

            return View();
        }
    }
}