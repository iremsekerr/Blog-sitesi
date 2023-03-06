using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using webproject.Models;

namespace webproject.Controllers
{
    public class AdminController : Controller
    {
        Context liste = new Context();
        Context liste1 = new Context();
        string fileName;
        public IActionResult YaziList()
        {
            var aka = liste.Yazis.ToList();
            var tur = liste.YaziTurus.ToList();

            return View(aka);
        }
        [HttpGet]
        public IActionResult YaziEkle()
        {

            return View();

        }
        [HttpPost]
        public IActionResult YaziEkle(IFormFile resmi, [FromServices] IHostingEnvironment oHostingEnvironment, Yazı a)
        {

            fileName = $"{oHostingEnvironment.WebRootPath}/Images{resmi.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                resmi.CopyTo(fileStream);
                fileStream.Flush();
                int ilk = fileName.IndexOf("/");
                a.resmi = fileName.Substring(ilk);
            }
            liste.Yazis.Add(a);
            liste.SaveChanges();
            return RedirectToAction("YaziList");
        }
        public IActionResult YaziSil(int id)
        {
            var yazi = liste.Yazis.Find(id);
            liste.Yazis.Remove(yazi);
            liste.SaveChanges();
            return RedirectToAction("YaziList");
        }
    }
}
