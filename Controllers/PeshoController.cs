using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class PeshoController : Controller
    {
        public IActionResult PeshoHtml()
        {
            return View();
        }
    }
}
