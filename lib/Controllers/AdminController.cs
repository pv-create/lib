using Microsoft.AspNetCore.Mvc;

namespace lib.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}