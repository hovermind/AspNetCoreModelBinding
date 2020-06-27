using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.MVC.Models;

namespace ModelBinding.MVC.Controllers
{
	public class FooController : Controller
	{
		// GET: FooController
		public ActionResult Index()
		{
			return View();
		}


		// GET: FooController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: FooController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(FooInputModel fooInputModel)
		{
			if (ModelState.IsValid)
			{
				// perform EF core task here i.e. _context.Add(hoverInputModel);await _context.SaveChangesAsync();

				return RedirectToAction(nameof(Index));
			}

			return View(fooInputModel);
		}
	}
}
