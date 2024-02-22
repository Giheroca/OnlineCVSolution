﻿using Microsoft.AspNetCore.Mvc;
using OnlineCV.Models;

namespace OnlineCV.Controllers
{
	public class ContactController : Controller
	{
		// GET: ContactController
		public ActionResult Index()
		{
			return View();
		}

		//POST: ContactController/Send
		public ActionResult Send(ContactRequest contactRequest)
		{
			return View(contactRequest);
		}

		// GET: ContactController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: ContactController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: ContactController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ContactController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: ContactController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ContactController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: ContactController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
