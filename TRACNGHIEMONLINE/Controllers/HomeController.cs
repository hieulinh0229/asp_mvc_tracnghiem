using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.Common;
using TRACNGHIEMONLINE.Models;
using TRACNGHIEMONLINE.Repositories;
using Enum = TRACNGHIEMONLINE.Models.EnumPermission;

namespace TRACNGHIEMONLINE.Controllers
{
    public class HomeController : Controller
    {
        public readonly IAdminRepository repository;
        public HomeController(IAdminRepository _adminRepository)
        {
            this.repository = _adminRepository;
        }

        public IActionResult Index()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            if (isLogin)
            {
                bool isAdmin = HttpContext.Session.Get<int>(UserSession.PERMISSION) == 1;
                bool isSudent = HttpContext.Session.Get<int>(UserSession.PERMISSION) == 2;
            }
            else
            {
                return Redirect("Login");
            }
            return View();
          
        }
    }
}
