using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ders2.Models;

namespace ders2.Controllers;

public class Urun
{
    public int ID { get; set; }
    public string? urunAd { get; set; }
    public int stokAdedi { get; set; }
}
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {

        return View();
    }
 public IActionResult Deneme2()
    {
        return View();
    }
    public IActionResult UrunListesi()
    {
        List<Urun> UrunListesiModeli = new List<Urun>();
        Urun u1 = new Urun();
        u1.ID = 1;
        u1.urunAd = "Bilgisayar";
        u1.stokAdedi = 5;
        Urun u2 = new Urun();
        u2.ID = 2;
        u2.urunAd = "Telefon";
        u2.stokAdedi = 55;
        Urun u3 = new Urun();
        u3.ID = 3;
        u3.urunAd = "Tablet";
        u3.stokAdedi = 28;

        Urun u4 = new Urun();
        u4.ID = 4;
        u4.urunAd = "TOGG";
        u4.stokAdedi = 200000;

        UrunListesiModeli.Add(u1);
        UrunListesiModeli.Add(u2);
        UrunListesiModeli.Add(u3);
        UrunListesiModeli.Add(u4);

        return View(UrunListesiModeli);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
   
}


