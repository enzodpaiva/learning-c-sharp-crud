using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcFit.Controllers
{
    public class PlanController : Controller
    {
        // GET: Plano
        public ActionResult Index()
        {
            return View();
        }
        [Route("editPlanos/{id:regex(\\d{2})}/{nome}")]
        public ActionResult Edit(int id, string nome)
        {
            return Content("id:" + id + "<br>nome:" + nome);
        }
    }
}