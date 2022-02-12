using Microsoft.AspNetCore.Hosting;
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
    public class StudentsController : Controller
    {
        public readonly IClassRepository classRepository;
        public readonly IStudentRepository studentRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public StudentsController( IWebHostEnvironment hostEnvironment, IClassRepository classRepository, IStudentRepository studentRepository)
        {
          
            this.webHostEnvironment = hostEnvironment;
            this.classRepository = classRepository;
            this.studentRepository = studentRepository;
        }
        public IActionResult Index()
        {
            return View();
        } 
        
        public IActionResult Create()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            Class[] listClass = classRepository.GetAll().ToArray();
            if (isLogin)
            {
                var admin = HttpContext.Session.Get<User>(UserSession.USER);
                ViewData["CLASS"] = listClass;
                ViewData["ADMIN"] = admin;
                return View();
            }
            else
            {
                return Redirect("/login");
                // return View("Views/Admin/Admin.cshtml");
            }
        }
        [HttpPost]
        public IActionResult Create(SudentModels models)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            Class[] listClass = classRepository.GetAll().ToArray();
            var user = HttpContext.Session.Get<User>(UserSession.USER);
                if (isLogin && user != null && user.IsAdmin() && listClass.Length > 0)
                {
                    if (ModelState.IsValid)
                    {
                        var clas = classRepository.GetAll().Where(x => models.ID_CLASS.Contains(x.Id_class)).ToList();
                            var student = new Student()
                            {
                                Username = models.USERNAME,
                                Name = models.NAME,
                                Password = Common.Encryptor.MD5Hash("@1"),
                                Phone = models.PHONE,
                                Birthday = models.BIRTHDAY,
                                Address = models.ADDRESS,
                                Email = models.EMAIL,
                                Class = clas
                            };
                            studentRepository.Insert(student);
                        return RedirectToAction("StudentManagement", "Admin");
                    }
                }
                   
            return Redirect("/login");
               
        }
    }
}
