using BigDeals.Data.ViewModels.Error;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BigDeals.Error
{
	public static class ExceptionMiddlewareExtensions
	{
		public static void ConfigureBuildInExceptionHandler(this IApplicationBuilder app)
		{
			app.UseExceptionHandler(appError =>
			{
				appError.Run(async context =>
				{
					context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
					context.Response.ContentType = "application/json";

					var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
					var contextRequest = context.Features.Get<IHttpRequestFeature>();

					if (contextFeature != null)
					{
						await context.Response.WriteAsync(new ErrorVM()
						{
							StatusCode = context.Response.StatusCode,
							Messasge = contextFeature.Error.Message,
							Path = contextRequest.Path
						}.ToString());
					}
				});
			});
		}
	}
}
