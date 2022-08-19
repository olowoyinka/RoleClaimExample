using Microsoft.AspNetCore.Mvc;

namespace RoleClaimExample.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
