using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.Common;
using TRACNGHIEMONLINE.Models;
using TRACNGHIEMONLINE.Models.DTO;
using TRACNGHIEMONLINE.Repositories;

namespace TRACNGHIEMONLINE.Controllers
{
    public class ClassController : Controller
    {
        public readonly IClassRepository classRepository;

        public ClassController(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        public IActionResult Create()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var user = HttpContext.Session.Get<User>(UserSession.USER);
            if (isLogin && user.IsAdmin())
            {
                ViewData["USER"] = user;
                return View();
            }
            else
            {
                return Redirect("/login");
                // return View("Views/Admin/Admin.cshtml");
            }

        }
        [HttpPost]
        public IActionResult Create(ClassModel model)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var user = HttpContext.Session.Get<User>(UserSession.USER);
            if (ModelState.IsValid && isLogin && user.IsAdmin())
            {
                bool exitName = classRepository.GetAll()
                    .Any(x => x.Class_name.Equals(model.Class_name));
                // Check exit name class
                if (exitName)
                {
                    ViewBag.error = "Đã tồn tại lớp cùng tên";
                }
                else
                {
                    Class subject = new Class()
                    {
                        Class_name = model.Class_name,
                        Description = model.Description
                    };
                    classRepository.Insert(subject);
                }
                return RedirectToAction("Index", "Subject");
            }
            else
            {
                return Redirect("/subject/create");
            }

        }
    }
}
