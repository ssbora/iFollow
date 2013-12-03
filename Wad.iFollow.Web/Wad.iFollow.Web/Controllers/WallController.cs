﻿using System;
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
            ViewBag.Message = "Settings.";

            return PartialView("_SettingsModal");
        }

        public ActionResult Post()
        {
            ViewBag.Message = "Your posting page.";

            return PartialView("_PostSettings");
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Your profile page.";

            return PartialView("_ProfilePage");
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

        [HttpPost]
        public ActionResult Post(LoginModel model)
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
            return PartialView("_PostSettings", model);
        }

        [HttpPost]
        public ActionResult Profile(LoginModel model)
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
            return PartialView("_ProfilePage", model);
        }

        static void SaveChanges(LoginModel model)
        {
            // Uncommment next line to demonstrate errors in modal
            //throw new Exception("Error test");
        }


    }
}
