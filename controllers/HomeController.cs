using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourse2.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            return Content("Sono la action di home");
        }
    }
}