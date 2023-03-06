using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webproject.Models;

namespace webproject.Controllers
{
    public class AnaSayfaController : Controller
    {
        Context liste = new Context();
        public IActionResult AnaSayfa()
        {

            var yazilar = liste.Yazis.ToList();

            
            return View(yazilar);
            
        }

        public IActionResult Getir(int id)
        {
           
            var modal = liste.Yazis.Where(x => x.Yid == id).ToList();

            ViewBag.modal = modal;
            return View(modal);

        }
    }
}
