using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigDeals.Data.Models
{
	public class Product
	{
		private int _stockCount = 0;
		private DateTime _addedDate = DateTime.Now;

		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int StockCount
		{
			get
			{
				return _stockCount;
			}
			set
			{
				if (value <= 0)
				{
					_stockCount = 0;
				}
			}
		}
		public bool Status { get; set; }
		public DateTime AddedDate
		{
			get
			{
				return _addedDate;
			}
			set
			{
				_addedDate = DateTime.Now;
			}
		}

		// navigation properties
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
