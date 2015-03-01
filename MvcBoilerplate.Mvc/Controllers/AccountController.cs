using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using MvcBoilerplate.Model;
using MvcBoilerplate.Mvc.Helper;
using MvcBoilerplate.Service;

namespace MvcBoilerplate.Mvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;

        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDto usr)
        {
            var _usr = AutoMapper.Mapper.Map<UserDto,User>(usr);

            if (_userService.IsRegisteredUser(_usr))
            {
                string roleName = _userService.GetRoleByUser(_usr);
                Sessions.CurrentUser = _usr;
                return RedirectToAction("Index", "Home", new { area = roleName });
            }

            ViewData["Name"] = "wrong password or username";
            return View("Index");
        }

        
        public ActionResult Logout()
        {

               //System.Web.HttpContext.Current.Session["current_user"]=null;

               Sessions.CurrentUser = null;
                return RedirectToAction("Index", "Account");

        }
    }
}