using Microsoft.AspNetCore.Mvc;

namespace lib.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}