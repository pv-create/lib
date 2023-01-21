using lib.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lib.Controllers;

public class AdminController : Controller
{
    ApplicationDbContext _context;
    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }
     
    
    public JsonResult Index()
    {
        var check = _context.Users.Select(All=>new {All.Id, All.Email, All.PhoneNumber});
        ViewBag.Users = _context.Users.ToList();
        return Json(check);
    }
}