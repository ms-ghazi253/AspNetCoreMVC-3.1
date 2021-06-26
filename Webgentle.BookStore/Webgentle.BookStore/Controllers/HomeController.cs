using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using Dynamitey;
using Webgentle.BookStore.Models;
using Microsoft.Extensions.Configuration;

namespace Webgentle.BookStore.Controllers
{
   
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        [ViewData]
        public string CustomPeroperty { get; set; }
        [ViewData]
        public string Title { get; set; }
        [ViewData]
        public BookModel book { get; set; }
        [Route("~/")]
      
        public ViewResult Index()
        {
            //var obj = new { id = 1, name = "Nitish" };
            //return View("AboutUs",obj);

            //return View("TempView/NitishTemp.cshtml");


            //ViewBag.Title = "webgentle";
            //dynamic Data = new ExpandoObject();
            //Data.Id = 1;
            //Data.Name = "mohammad";
            //ViewBag.Data = Data;
            //ViewBag.Type = new BookModel() { Id = 5, Author = "this is author " };

            //ViewData["property1"] = "nitish kaushik";
            //ViewData["book"] = new BookModel() { Author = "nitish", Id = 1 };

            //Title = "Home Page From Controller";
            //CustomPeroperty = "CustomValue";
            //book = new BookModel() { Id = 1, Title = "Asp.Net Core Tutorial " };

            var result = configuration["AppName"];
            var key1 = configuration["infoObj:key1"];
            var key2 = configuration["infoObj:key2"];
            var key3 = configuration["infoObj:key3:key3obj1"];
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
