﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class Weather : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}