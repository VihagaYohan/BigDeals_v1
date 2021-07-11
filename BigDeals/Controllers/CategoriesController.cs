using BigDeals.Data.Models;
using BigDeals.Data.Services;
using BigDeals.Data.ViewModels.Category;
using BigDeals.Error.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigDeals.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly CategoryService _service;
		public CategoriesController(CategoryService service)
		{
			_service = service;
		}

		[HttpPost]
		public IActionResult AddCategories([FromBody] CategoryVM categoryVM)
		{
			try
			{
				throw new Exception("this will handle by middleware");
				var result = _service.AddCategory(categoryVM);
				if (result == null)
				{
					return BadRequest();
				}
				else
				{
					return Created(nameof(AddCategories), result); ;
				}
			}
			catch (RecordNameException ex)
			{
				return BadRequest($"{ex.Message}, Category name: {ex.RecordName}");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
