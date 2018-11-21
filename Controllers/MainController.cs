using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormSubmission
{
    public class MainController : Controller
    {
        // renders the Index 
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
        [HttpPost("create")]
        public IActionResult Create(Models.User newUser)
        {
            // checks to see if the validators are cleared, if not fires invalid messages
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else{
                return View("Index");
            }
        }
        [HttpGet("success")]
        public ViewResult Success()
        {
            return View("Success");
        }
    }
}