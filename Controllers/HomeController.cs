using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using NBKSite.Models.Home;

namespace NBKSite.Controllers
{
    public class HomeController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Index()
        {
            Index model = new Index();
            return View(model);
        }
    }
}
