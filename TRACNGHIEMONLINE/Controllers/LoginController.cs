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
    public class LoginController : Controller
    {
        public readonly IAdminRepository adminRepository;
        public readonly IStudentRepository studentRepository;
        public LoginController(IAdminRepository _adminRepository, IStudentRepository studentRepository)
        {
            this.adminRepository = _adminRepository;
            this.studentRepository = studentRepository;
        }
   
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {

                var listAdmin = adminRepository.GetAll().ToList();
                var listSudent = studentRepository.GetAll().ToList();
                var user = model.CheckLogin(model, listAdmin, listSudent);
                 if (user==null)
                {
                    ViewBag.error = "Tài khoản hoặc mật khẩu không đúng";
                    HttpContext.Session.Clear();

                }
                else
                {
                    HttpContext.Session.Set<bool>(UserSession.ISLOGIN, true);
                    HttpContext.Session.Set<User>(UserSession.USER, user);
                    if (user.IsAdmin())
                    {
                        return RedirectToAction("Index","Admin");

                    }
                    if (user.IsStudent())
                    {  
                        return RedirectToAction("Index", "Students");
                    }      
                }
                           
            }
            else
                ViewBag.error = "Có lỗi xảy ra trong quá trình xử lý, vui lòng thử lại sau.";
            return View();
        }
      

    }
}
