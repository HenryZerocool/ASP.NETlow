using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETlow.Models
{
	public class Post
	{
		[Required]
		[StringLength(100, MinimumLength = 5, ErrorMessage = "title length between 5 and 100")]
		public string Title { get; set; }
		public string Author { get; set; }
		[Required]
		public string Body { get; set; }
		public DateTime Posted { get; set; }
	}
}
