﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class LayoutEstateAgent : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
