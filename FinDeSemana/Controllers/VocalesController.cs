using FinDeSemana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinDeSemana.Controllers
{
    public class VocalesController : Controller
    {
        // GET: Vocales
        Vocal word = new Vocal();
        public ActionResult Vocal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Vocal(string palabra)
        {
            var newWord = palabra.ToLower();
            ViewBag.Mensaje = word.ContarVocales(palabra);
            return View();
        }
    }
}