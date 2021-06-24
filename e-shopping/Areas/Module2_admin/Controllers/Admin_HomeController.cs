using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_shopping.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_shopping.Areas.Module2_admin.Controllers
{
    public class Admin_HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(Admin adm)
        {
            db.Admins.Add(adm);
            db.SaveChanges();
            return View();    
        }


    }
}
