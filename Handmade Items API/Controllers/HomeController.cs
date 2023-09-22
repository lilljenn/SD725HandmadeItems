using Handmade_Items_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Handmade_Items_API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult getZipCode()
        {
            
            ViewBag.Message = "The cost for shipping in your area is ";
           
            return PartialView();
        }
        public ActionResult getLaborCost()
        {
            
            ViewBag.Message = "The amount of time taken to create your item is ";

            return PartialView();
        }
        public ActionResult getPrice()
        {

            ViewBag.Message = "The price of this item is ";

            return PartialView();
        }
        public ActionResult getNameAndDescription()
        {

            ViewBag.Message = "You have selected: ";

            return PartialView();
        }
        public ActionResult getColor()
        {

            ViewBag.Message = "The color you have chosen is ";

            return PartialView();
        }
        public ActionResult getSize()
        {

            ViewBag.Message = "The size you have selected is ";

            return PartialView();
        }
        public ActionResult getID()
        {

            ViewBag.Message = "The product ID number is ";

            return PartialView();
        }
    }
}
