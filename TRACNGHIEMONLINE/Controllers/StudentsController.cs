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
        public readonly IAdminRepository adminRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public readonly ISubjectRepository subjectRepository;
        public readonly IQuestionRepository questionRepository;
        public readonly ITypeExamRepository examRepository;
        public StudentsController(IAdminRepository _adminRepository,
            IWebHostEnvironment hostEnvironment
            , IClassRepository classRepository,
            ISubjectRepository subjectRepository,
             ITypeExamRepository examRepository,
             IStudentRepository studentRepository,
             IQuestionRepository questionRepository)
        {
            this.adminRepository = _adminRepository;
            this.webHostEnvironment = hostEnvironment;
            this.classRepository = classRepository;
            this.subjectRepository = subjectRepository;
            this.examRepository = examRepository;
            this.studentRepository = studentRepository;
            this.questionRepository = questionRepository;
        }
        public IActionResult Index()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            if (isLogin)
            {
                var user = HttpContext.Session.Get<User>(UserSession.USER);
                var listSub = subjectRepository.GetAll().ToArray();
                var classes = classRepository.GetAll().ToArray();
                var types = examRepository.GetAll().ToArray();
                ViewData["CLASS"] = classes;
                ViewData["SUBS"] = listSub;


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
                                Gender = models.GENDER,
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
