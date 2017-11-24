using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using DynamicMenuMVC.Models;

namespace DynamicMenuMVC
{
    public class HomeController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public JsonResult GetMainMenu()
        {
            TestDevDbEntities dc = new TestDevDbEntities();
            var menu = dc.MainMenus.Select(m => new {
                m.Name,
                m.Url,
                SubMenu = m.SubMenus.Select(s => new {
                    s.SubName,
                    s.SubUrl
                })
            });
            return new JsonResult
            {
                Data = menu,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}