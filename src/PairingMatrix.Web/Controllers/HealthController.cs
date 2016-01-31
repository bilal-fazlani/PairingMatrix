using Microsoft.AspNet.Mvc;

namespace PairingMatrix.Web.Controllers
{
    public class HealthController : Controller
    {
        public IActionResult Index()
        {
            return Content("OK");
        }
    }
}