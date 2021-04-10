using ASP.NETlow.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETlow.controllers
{
	[Route("blog")]
	public class BlogController : Controller
	{
		// GET: BlogController
		[Route("")]
		public ActionResult Index()
		{
			return View();
		}

		// GET: BlogController/Details/5
		//public ActionResult Details(string id)
		//{
		//	return new ContentResult { Content = $"Simple Blog {id}" };
		//}

		// custom GET
		[Route("{year:int}/{month:int}/{key?}")]
		public ActionResult Post(int year, int month, string key)
		{
			var post = new Post
			{
				Title = "View Post from Controller"
			};
			//ViewBag.Title = "View Post ";
			return View(post);
		}

		//// GET: BlogController/Create
		//public ActionResult Create()
		//{
		//	return View();
		//}

		// POST: BlogController/Create
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

		// GET: BlogController/Edit/5
		//public ActionResult Edit(int id)
		//{
		//	return View();
		//}

		// POST: BlogController/Edit/5
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

		// GET: BlogController/Delete/5
		//public ActionResult Delete(int id)
		//{
		//	return View();
		//}

		// POST: BlogController/Delete/5
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
