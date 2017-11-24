using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using DynamicMenuMVC.Models;

namespace DynamicMenuMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AngularMenu()
        {
            return View();
        }

        //public ActionResult GetMainMenu()
        //{
        //    //using (var client = new HttpClient())
        //    //{
        //    //    client.BaseAddress = new Uri("http://localhost:59609/api/menu/");

        //    //    //HTTP GET
        //    //    var responseTask = client.GetAsync("menu");
        //    //    responseTask.Wait();

        //    //    var result = responseTask.Result;
        //    //    if (result.IsSuccessStatusCode)
        //    //    {
        //    //       // return View(result.Content);
        //    //        //var serializer = new JavaScriptSerializer();
        //    //        //var menu = serializer.Serialize(result);
        //    //        //return new JsonResult
        //    //        //{
        //    //        //    Data = menu,
        //    //        //    JsonRequestBehavior = JsonRequestBehavior.AllowGet
        //    //        //};
        //    //    }
        //    //}

        //    return View();
           
        //} 
    }
}