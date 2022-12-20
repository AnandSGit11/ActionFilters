using ModelBinding.Models;
using PlayerCustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ModelBinding.Controllers
{

    [PlayerCustomFilter]

    public class PlayerController : Controller
    {
        // GET: Player
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Player player)
        {
            return View();
        }
    }
}