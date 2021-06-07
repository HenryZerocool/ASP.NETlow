using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETlow.Models;

namespace ASP.NETlow.ViewComponents
{
	public class MonthlySpecialsViewComponent : ViewComponent
	{
		public readonly BlogDataContext db;
		public MonthlySpecialsViewComponent(BlogDataContext db)
		{
			this.db = db;
		}
		public IViewComponentResult Invoke()
		{
			var specials = db.MonthlySpecials.ToArray();
			return View(specials);
		}
	}
}
