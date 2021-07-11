using AutoMapper;
using BigDeals.Data.Models;
using BigDeals.Data.ViewModels.Category;
using BigDeals.Error.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BigDeals.Data.Services
{
	public class CategoryService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public CategoryService(AppDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		// add new product category
		public Category AddCategory(CategoryVM category)
		{
			if (StringStartsWithNumber(category.CategoryName)) throw new RecordNameException("Name starts with number", category.CategoryName);

			var productCategory = _mapper.Map<Category>(category);
			_context.Categories.Add(productCategory);
			var result = _context.SaveChanges();

			if (productCategory == null)
			{
				return null;
			}

			return productCategory;
		}

		private bool StringStartsWithNumber(string name)
		{
			if (Regex.IsMatch(name, @"^\d"))
			{
				return true;
			}
			return false;
		}
	}
}
