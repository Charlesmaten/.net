using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSnakeDB.Models;

namespace MVCSnakeDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(SelectSnakeModel mySelectSnakeModel)
        {
            DataSet ds = mySelectSnakeModel.GetAllSnakes();
            ViewBag.Snakelist = ds.Tables[0];
            return View();
        }

    }
}