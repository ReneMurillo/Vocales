using FinDeSemana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinDeSemana.Controllers
{
    public class FinesController : Controller
    {
        // GET: Fines
        Fin dias = new Fin();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string dia)
        {
            var day = (dia).ToLower();
            var message = dias.VerificarDia(day.Trim());
            ViewBag.Mensaje = message;
            return View();
        }
    }
}