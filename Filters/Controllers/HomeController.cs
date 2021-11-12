using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filters.Infrastructute;

namespace Filters.Controllers
{
    [Message("This is the controller-scoped filter",Order = 10)]
    public class HomeController : Controller
    {
        [Message("This is the First Action-Scoped Filter", Order = 1)]
        [Message("This is the Second Action-Scoped Filter", Order = -1)]
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the home controller");
        }
        public ViewResult GenerateException(int? id) 
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            else if (id > 10)
                throw new ArgumentOutOfRangeException(nameof(id));
            else return View("Message", $"This value is {id}");                                 
            
        }
    }
}
