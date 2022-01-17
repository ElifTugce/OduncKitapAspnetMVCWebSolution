using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OduncKitapAspnetMVCWebSolution_BLL.Managers;

namespace OduncKitapAspnetMVCWebSolution_UI.Controllers
{
    public class PartialsController : Controller
    {

        //GLOBAL ALAN
        KitapManager myKitapManager = new KitapManager();

        //Partial kısmi görünüm anlamına gelmektedir.
        //Controller içinde partiallar oluşturulabilir.
        //Tüm partialları tek bir yerden yönetmek amacıyla PartialsController oluşturduk.
        //Mevcutta var olan controllerların içinde de partial oluşturulabilir.
        public PartialViewResult MenuPartialResult()
        {
            int toplamKitapSayisi = myKitapManager.TumAktifKitaplariGetir().Count();
            TempData["ToplamKitapSayisi"] = toplamKitapSayisi;
            // Umut'un viewbag dene
            return PartialView("_PartialMenu");
        }

    }
}