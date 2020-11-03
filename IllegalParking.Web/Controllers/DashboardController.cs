using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using IllegalParking.Web.Models;
using Microsoft.AspNetCore.Mvc;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace IllegalParking.Web.Controllers
{
    public class DashboardController : Controller
    {
        public CameraViewModel cameraViewModel { get; set; }
        bool x = false;
        public IActionResult Index()
        {
            if(x)
            {
                return RedirectToAction("Save");
            }
            cameraViewModel = new CameraViewModel();
            cameraViewModel.Picture = "a.bmp";
            return View();
        }

        public IActionResult Save()
        {
            x = true;
            return RedirectToAction("Index");
        }

    }
}
