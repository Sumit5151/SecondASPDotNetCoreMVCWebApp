using Microsoft.AspNetCore.Mvc;
using SecondASPDotNetCoreMVCWebApp.Models;

namespace SecondASPDotNetCoreMVCWebApp.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();
            var users = db.Users.ToList();


            return View(users);

        }
    }
}
