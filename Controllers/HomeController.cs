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

        [HttpGet]
        public ActionResult BingoBook()
        {
            BingoBook model = new BingoBook();
            return View(model);
        }

        [HttpGet]
        public ActionResult TreasureList()
        {
            BingoBook model = new BingoBook();
            return View("BingoBook", model);
        }

        [HttpGet]
        public ActionResult Schedules()
        {
            BingoBook model = new BingoBook();
            return View("BingoBook", model);
        }

        [HttpGet]
        public ActionResult Members()
        {
            BingoBook model = new BingoBook();
            return View("BingoBook", model);
        }
    }
}
