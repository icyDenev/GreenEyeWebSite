﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LitWebSite.Models;
using LitWebSite.Data;

namespace LitWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new SensorDBContext())
            {
                return this.View(context.SensorsData.ToList());
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Data()
        {
            using (var context = new SensorDBContext())
            {
                return this.View(context.SensorsData.ToList());
            }
        }

        public IActionResult GreenEye()
        {
            return View();
        }

        public IActionResult CanSat()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
