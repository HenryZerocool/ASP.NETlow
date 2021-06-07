using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETlow.Models
{
	public class FormattingServices
	{
		public string AsReadableDate(DateTime date)
		{
			return date.ToString("D");
		}
	}
}
