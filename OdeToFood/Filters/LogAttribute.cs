using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Filters
{
	public class LogAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			base.OnActionExecuting(context);
		}
		public override void OnActionExecuted(ActionExecutedContext context)
		{
			base.OnActionExecuted(context);
		}
		public override void OnResultExecuting(ResultExecutingContext context)
		{
			base.OnResultExecuting(context);
		}
		public override void OnResultExecuted(ResultExecutedContext context)
		{
			base.OnResultExecuted(context);
		}
	}
}