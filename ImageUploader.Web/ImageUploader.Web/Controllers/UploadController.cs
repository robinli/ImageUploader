﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageUploader.Web.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Basic()
        {
            return View();
        }
    }
}