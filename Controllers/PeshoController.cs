﻿using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using UserNamespace;

namespace MyApp.Controllers
{
    public class PeshoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PeshoController(ApplicationDbContext db) 
        { 
            this._db = db;
        }
        public IActionResult PeshoHtml()
        {
            List<User> objCategoryList = _db.Users.ToList();
            return View(objCategoryList);
        }
    }
}
