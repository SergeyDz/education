using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.API.Samples.Host.Models;

namespace Web.API.Samples.Host.Controllers
{
    public class ProductController : AsyncController
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            Product data = new Product();
            data.Id = 1;
            data.Name = "Test";
            data.Notes = "Description";
            return View(data);
        }

        public ActionResult Detail()
        {
            Product data = new Product();
            data.Id = 1;
            data.Name = "Test";
            data.Notes = "Description";
            return View(data);
        }

    }
}
