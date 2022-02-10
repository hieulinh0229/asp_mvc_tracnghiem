using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.Common;
using TRACNGHIEMONLINE.Models;
using TRACNGHIEMONLINE.Models.DTO;
using TRACNGHIEMONLINE.Models.Enums;
using TRACNGHIEMONLINE.Repositories;

namespace TRACNGHIEMONLINE.Controllers
{
    public class SubjectController : Controller

    {
        public readonly ISubjectRepository subjectRepository;
        public readonly IClassRepository classRepository;
        public readonly ITypeExamRepository examRepository;

        public SubjectController(ISubjectRepository subjectRepository, IClassRepository classRepository, ITypeExamRepository examRepository)
        {
            this.subjectRepository = subjectRepository;
            this.classRepository = classRepository;
            this.examRepository = examRepository;
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
            ViewData["USER"] = user;
            if (  isLogin && user.IsAdmin())
            {
                if(ModelState.IsValid)
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
                    return RedirectToAction("Index", "Subject");
                }
                else
                {
                    return View();

                }
            }
            else
            {
                return Redirect("/login");
            }



        }
        public IActionResult CreateTypeExam()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var user = HttpContext.Session.Get<User>(UserSession.USER);
            var listSub = subjectRepository.GetAll().ToArray();
            Dictionary<int, string> listTypeExs = new Dictionary<int, string>();
            listTypeExs.Add((int)EnumTypExam.BAITAPTULUYEN, EnumTypExam.BAITAPTULUYEN.ToString());
            listTypeExs.Add((int)EnumTypExam.THIHOCKY, EnumTypExam.THIHOCKY.ToString());
            listTypeExs.Add((int)EnumTypExam.KIEMTRAGIUAKY, EnumTypExam.KIEMTRAGIUAKY.ToString());

            ViewData["SUBS"] = listSub;
            ViewData["TYPES"] = listTypeExs;
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
        public IActionResult CreateTypeExam(TypeExamModel model)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var user = HttpContext.Session.Get<User>(UserSession.USER);
            if(!(isLogin && user.IsAdmin()))
            {
                return Redirect("/login");
            }
            if (ModelState.IsValid && isLogin && user.IsAdmin())
            {
                int idSub = model.Id_sub;
                var sub = subjectRepository.GetById(idSub);
                List<Subject> subjects = new List<Subject>();
                subjects.Add(sub);
                var type = new TypeExam()
                {
                    Name = model.Name,
                    Total_questions = model.Total_questions,
                    Time_to_do = model.Time_to_do,
                    Subjects = subjects
                };
                examRepository.Insert(type);

                return RedirectToAction("Index", "Subject");
            }
            else
            {
                return View();
            }

        }
    }
}
