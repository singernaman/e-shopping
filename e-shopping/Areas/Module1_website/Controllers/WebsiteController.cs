using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_shopping.Areas.Module1_website.Controllers
{
    public class WebsiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
