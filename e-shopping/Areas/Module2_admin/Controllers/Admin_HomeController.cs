﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace e_shopping.Areas.Module2_admin.Controllers
{
    public class Admin_HomeController : Controller
    {

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login()
        {
            return View();    
        }


    }
}
