﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: RangeColorMapping
        public ActionResult RangeColorMapping()
        {
            string[] color1 = { "#FFFF99" };
            string[] color2 = { "#FFA500" };
            string[] color3 = { "#FF4040" };
            List<RangeColorMappingData> chartData = new List<RangeColorMappingData>
            {
                  new RangeColorMappingData { x= "Jan", y= 6.96},
                  new RangeColorMappingData { x= "Feb", y= 8.9},
                  new RangeColorMappingData { x= "Mar", y= 12},
                  new RangeColorMappingData { x= "Apr", y= 17.5},
                  new RangeColorMappingData { x= "May", y= 22.1},
                  new RangeColorMappingData { x= "June", y= 25},
                  new RangeColorMappingData { x= "July", y= 29.4},
                  new RangeColorMappingData { x= "Aug", y= 29.6},
                  new RangeColorMappingData { x= "Sep", y= 25.8},
                  new RangeColorMappingData { x= "Oct", y= 21.1},
                  new RangeColorMappingData { x= "Nov", y= 15.5},
                  new RangeColorMappingData { x= "Dec", y= 9.9}
            };
            ViewBag.dataSource = chartData;
            ViewBag.color1 = color1;
            ViewBag.color2 = color2;
            ViewBag.color3 = color3;
            return View();
        }
        public class RangeColorMappingData
        {
            public string x;
            public double y;
        }
    }
}