﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Controllers
{
    public class Welcome : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }
    }
}
