using Microsoft.AspNetCore.Http;
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
    public class SubjectController : Controller

    {
        public readonly ISubjectRepository subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }
        public IActionResult Index()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            if (isLogin)
            {
                var user = HttpContext.Session.Get<User>(UserSession.USER);
                return View(user);
            }
            else
            {
                return Redirect("/login");
                // return View("Views/Admin/Admin.cshtml");
            }
           
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
        public IActionResult Create(SubjectModel model)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var user = HttpContext.Session.Get<User>(UserSession.USER);
            if (ModelState.IsValid && isLogin && user.IsAdmin())
            {
                bool exitName = subjectRepository.GetAll()
                    .Any(x => x.Subject_name.Equals(model.Subject_name));
                // Check exit name subject
                if (exitName)
                {
                    ViewBag.error = "Đã tồn tại môn học cùng tên";
                }
                else
                {
                    Subject subject = new Subject()
                    {
                        Subject_name = model.Subject_name,
                        Description = model.Description
                    };
                    subjectRepository.Insert(subject);
                }
                return RedirectToAction("Index","Subject");
            }
            else
            {
                return Redirect("/subject/create");
            }

        }
    }
}
