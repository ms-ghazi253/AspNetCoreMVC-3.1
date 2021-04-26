﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using Dynamitey;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var obj = new { id = 1, name = "Nitish" };
            //return View("AboutUs",obj);

            //return View("TempView/NitishTemp.cshtml");

          
            ViewBag.Title = "webgentle";
            dynamic Data = new ExpandoObject();
            Data.Id = 1;
            Data.Name = "mohammad";
            ViewBag.Data = Data;
            ViewBag.Type = new BookModel() { Id = 5, Author = "this is author " };

            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
