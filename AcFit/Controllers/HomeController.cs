using AcFit.Models;
using AcFit.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcFit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Client usuario = new Client()
            {
                Id = 1,
                Nome = "Enzo"
            };

            var lstPlanos = new List<Plan>()
            {
                new Models.Plan() {Id=1, Nome="Plano 1", Valor = 100 },
                new Models.Plan() {Id=2, Nome="Plano 2", Valor = 200 }
            };

            PlanClientViewModel model = new PlanClientViewModel();

            model.Usuario = usuario;
            model.Planos = lstPlanos;

            //ViewData["nomeUser"] = "Chaves";
            //ViewBag.nomeUser = "Chapolin";
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}