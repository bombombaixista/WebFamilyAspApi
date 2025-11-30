using Microsoft.AspNetCore.Mvc;

namespace WebFamilyAspApi.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
