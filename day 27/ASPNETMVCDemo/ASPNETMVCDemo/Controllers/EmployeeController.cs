using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public string Display()
        {
            return "Hello MVC ";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
