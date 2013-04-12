using System.Web.Mvc;

namespace DurandalAuthenticationTemplate.Controllers
{
    [Authorize]
    public class DurandalController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
