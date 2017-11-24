using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using DynamicMenuMVC.Models;



namespace DynamicMenuMVC.Controllers
{
    public class MenuController : ApiController
    {

        //public HttpResponseMessage GetMainMenu()
        //{
        //    TestDevDbEntities dc = new TestDevDbEntities();
        //    var menu = dc.MainMenus.Select(m => new
        //    {
        //        m.Name,
        //        m.Url,
        //        SubMenu = m.SubMenus.Select(s => new
        //        {
        //            s.SubName,
        //            s.SubUrl
        //        })
        //    }).ToList();

        //    var serializer = new JavaScriptSerializer();
        //     var result = serializer.Serialize(menu);

        //    return Request.CreateResponse(HttpStatusCode.OK, result);
        //}


     

        public JsonResult GetMainMenu()
        {
            TestDevDbEntities dc = new TestDevDbEntities();
            var menu = dc.MainMenus.Select(m => new
            {
                m.Name,
                m.Url,
                SubMenu = m.SubMenus.Select(s => new
                {
                    s.SubName,
                    s.SubUrl
                })
            }).ToList();

            var serializer = new JavaScriptSerializer();
            var result = serializer.Serialize(menu);

            return new JsonResult { Data = menu, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
