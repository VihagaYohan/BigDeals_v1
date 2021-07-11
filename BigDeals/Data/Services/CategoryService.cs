using AutoMapper;
using BigDeals.Data.Models;
using BigDeals.Data.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigDeals.Data.Services
{
	public class CategoryService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public CategoryService(AppDbContext context,IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		// add new product category
		public Category AddCategory(CategoryVM category) 
		{
			var productCategory = _mapper.Map<Category>(category); 
			 _context.Categories.Add(productCategory);
			var result = _context.SaveChanges();

			if (productCategory == null) 
			{
				return null;
			}
			
			return productCategory;
		}
	}
}
