using AutoMapper;
using BigDeals.Data.Models;
using BigDeals.Data.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigDeals.Data.Profiles
{
	public class CategoryProfile:Profile
	{
		public CategoryProfile()
		{
			CreateMap<CategoryVM, Category>();
		}
	}
}
