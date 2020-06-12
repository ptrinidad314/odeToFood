using odeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public class GreetingController:Controller
{
   public ActionResult Index() 
   {
        var model = new GreetingViewModel();

        model.Message=ConfigurationManager.AppSettings["message"];

        return View(model);
   }
}