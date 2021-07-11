using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BigDeals.Data.Models
{
	public class Category
	{
		[Key]
		public int CatgoryId { get; set; }

		[Required]
		[MaxLength(50,ErrorMessage ="Please add product category name")]
		public string CategoryName { get; set; }

		[Required]
		public string ImageURL { get; set; }

		[Required]
		public DateTime AddedDate { get; set; } = DateTime.Now;

		// navigation properties
		public IEnumerable<Product> Products { get; set; }
	}
}
