using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourse2.controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return Content("im index");
        }
        public IActionResult Detail(string id){
            return Content($"im detail. ho ricevuto l'id {id}");
        }
    }
}