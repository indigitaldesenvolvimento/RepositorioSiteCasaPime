using System.Web.Mvc;

namespace WebSiteCasaPrime.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Servico()
        {
            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}