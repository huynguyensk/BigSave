using Microsoft.AspNetCore.Mvc;

namespace BigSave.Web.Controllers
{
    public class CouponController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}