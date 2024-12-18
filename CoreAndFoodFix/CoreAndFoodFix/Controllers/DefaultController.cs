﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFoodFix.Controllers
{
	public class DefaultController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CategoryDetails(int id)
		{
			ViewBag.x = id;
			return View();
		}
	}
}
