using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using UserNamespace;

namespace MyApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UsersController(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IActionResult AllUsers()
        {
            List<User> objCategoryList = _db.Users.ToList();
            return View(objCategoryList);
        }
    }
}
