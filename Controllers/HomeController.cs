using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController
    {
        [HttpGet("")]

        public string Index()
        {
            return "Hello, Welcome to my portfolio.";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return " This is my portfolio";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my contact information";
        }
    }
}