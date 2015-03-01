using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBoilerplate.Mvc.Helper;

namespace MvcBoilerplate.Mvc.Areas.Admin.Controllers
{
    
    public class HomeController : Controller
    {
        [AuthorizeUser(RoleLevel = "Admin")]
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}