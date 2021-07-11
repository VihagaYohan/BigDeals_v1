using BigDeals.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigDeals.Data.ViewModels.Category
{
	public class CategoryVM
	{
		public int CatgoryId { get; set; }
		public string CategoryName { get; set; }
		public string ImageURL { get; set; }
		public DateTime AddedDate { get; set; }

		// navigation properties
		//public IEnumerable<Product> Products { get; set; }

	}
}
