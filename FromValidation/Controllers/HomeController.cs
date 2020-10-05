using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FromValidation.Models;

namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        
        [HttpGet("")]       //type of request
        public IActionResult Index()
        {
            return View("Index");
        }


        [HttpPost("success")]
        public IActionResult CreateUser(User FromForm)
        {
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return Index();
            
            }
        }
    }
}
