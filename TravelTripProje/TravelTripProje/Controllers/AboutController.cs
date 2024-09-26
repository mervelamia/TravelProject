using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;
namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context(); //Context sınıfında c isimli nesne türettik.
                                   //C nesnesi yardımıyla da contexte bağlı olan sınıflara ulaşıp hakkımızda tablosunu listeledik.  
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}