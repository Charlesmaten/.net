using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;

using MVCSnakeDB.Models;

namespace MVCSnakeDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(SelectSnakeModel myselectsnakemodel)
        {
            DataSet ds = myselectsnakemodel.GetAllSnakes();
            ViewBag.Snakelist = ds.Tables[0];
            return View();
        }

        [HttpPost]
        public ActionResult Index(SelectSnakeAndOwnerModel myselectsnakeandownermodel)
        {
            try
            {
                int id = Convert.ToInt32(Request["SnakeID"]);
                DataSet ds = myselectsnakeandownermodel.GetSnakeWithOwner(id);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    ViewData["message"] = "Snake " + id + " with owner";
                }
                else
                {
                    ViewData["message"] = "No snake with id = " + id;
                }
                ViewBag.Snakeandownerlist = ds.Tables[0];
                return View("../SnakeAndOwner/Index");
            }
            catch (Exception ex)
            {
                SelectSnakeModel myselectsnakemodel = new SelectSnakeModel();
                DataSet ds = myselectsnakemodel.GetAllSnakes();
                ViewBag.Snakelist = ds.Tables[0];
                return View();
            }
        }

    }
}