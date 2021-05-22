using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASP.NETlow.Models
{
	public class Post
	{
		public long Id { get; set; }
		private string _key;
		public string Key
		{
			get
			{
				if (_key == null)
				{
					_key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
				}
				return _key;
			}
			set { _key = value; }
		}
		[Display(Name = "Post Title")]
		[DataType(DataType.Text)]
		[Required]
		[StringLength(100, MinimumLength = 5, ErrorMessage = "title length between 5 and 100")]
		public string Title { get; set; }
		public string Author { get; set; }
		[Required]
		public string Body { get; set; }
		public DateTime Posted { get; set; }
	}
}
