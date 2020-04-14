using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]

        public ViewResult Home()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}