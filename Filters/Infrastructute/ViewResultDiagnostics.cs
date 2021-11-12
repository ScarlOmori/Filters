using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Infrastructute
{
    public class ViewResultDiagnostics : IActionFilter
    {
        private IFilterDiagnostics diagnostics;
        public ViewResultDiagnostics(IFilterDiagnostics diagn)
        {
            diagnostics = diagn;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            ViewResult vr;
            if ((vr = context.Result as ViewResult) != null) 
            {
                diagnostics.AddMessage($"View name: {vr.ViewName}");
                diagnostics.AddMessage($@"Model type: 
                {vr.ViewData.Model.GetType().Name}");
            }
        }

        public void OnActionExecuting(ActionExecutingContext context) { }
    }
}
