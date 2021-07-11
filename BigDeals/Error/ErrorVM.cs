using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BigDeals.Data.ViewModels.Error
{
	public class ErrorVM
	{
		public int StatusCode { get; set; }
		public string Messasge { get; set; }
		public string  Path { get; set; }

		public override string ToString()
		{
			return JsonSerializer.Serialize(this);
		}
	}
}
