﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Throw(string id) => throw new ApplicationException(id);

        //public IActionResult SomeAction() => View();

        public IActionResult Error404() => View();

        public IActionResult Blog() => View();

        public IActionResult BlogSingle() => View();

        public IActionResult ContactUs() => View();

        public IActionResult ErrorStatus(string Code) => RedirectToAction(nameof(Error404));
    }
}