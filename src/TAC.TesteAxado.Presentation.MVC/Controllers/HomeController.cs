using System.Web.Mvc;

namespace TAC.TesteAxado.Presentation.MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}