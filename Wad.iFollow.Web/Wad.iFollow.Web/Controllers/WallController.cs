using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wad.iFollow.Web.Models;

namespace Wad.iFollow.Web.Controllers
{
    public class WallController : Controller
    {
        //
        // GET: /Main/

        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Your contact page.";

            return PartialView("_SettingsModal");
        }

        [HttpPost]
        public ActionResult Settings(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SaveChanges(model);
                    return Json(new { success = true });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }

            }
            //Something bad happened
            return PartialView("_SettingsModal", model);
        }

        static void SaveChanges(LoginModel model)
        {
            // Uncommment next line to demonstrate errors in modal
            //throw new Exception("Error test");
        }


    }
}
