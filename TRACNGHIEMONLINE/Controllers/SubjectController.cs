using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        public readonly IQuestionRepository questionRepository;
        public readonly IClassRepository classRepository;
        public readonly ITypeExamRepository examRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public SubjectController(ISubjectRepository subjectRepository, IClassRepository classRepository, ITypeExamRepository examRepository, 
            IWebHostEnvironment webHostEnvironment, IQuestionRepository questionRepository)
        {
            this.subjectRepository = subjectRepository;
            this.classRepository = classRepository;
            this.examRepository = examRepository;
            this.webHostEnvironment = webHostEnvironment;
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
            var user = HttpContext.Session.Get<User>(UserSession.USER);
            var classes = classRepository.GetAll().ToArray();
            var types = examRepository.GetAll().ToArray();
            ViewData["CLASS"] = classes;
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
                        var listClass = classRepository.GetAll().Where(x => model.Id_Class.Contains(x.Id_class)).ToList();
                        Subject subject = new Subject()
                        {
                            Subject_name = model.Subject_name,
                            Description = model.Description,
                            Classes = listClass
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
            var listSub = subjectRepository.GetAll().ToArray();
            Dictionary<int, string> listTypeExs = new Dictionary<int, string>();
            listTypeExs.Add((int)EnumTypExam.BAITAPTULUYEN, EnumTypExam.BAITAPTULUYEN.ToString());
            listTypeExs.Add((int)EnumTypExam.THIHOCKY, EnumTypExam.THIHOCKY.ToString());
            listTypeExs.Add((int)EnumTypExam.KIEMTRAGIUAKY, EnumTypExam.KIEMTRAGIUAKY.ToString());
            ViewData["USER"] = user;
            ViewData["SUBS"] = listSub;
            ViewData["TYPES"] = listTypeExs;
            if (!(isLogin && user.IsAdmin()))
            {
                return Redirect("/login");
            } else
            {
                if (ModelState.IsValid && isLogin && user.IsAdmin())
                {
                    List<int> idSubs = model.Id_sub;
                    List<Subject> subs = subjectRepository.GetAll().Where(x => idSubs.Contains(x.Id_subject)).ToList();
                    List<Subject> subjects = subs.Where(x => x.Subject_name.Equals(model.Name)).ToList(); ;

                    if (subjects.Count > 0)
                    {
                        string mes = String.Join(",", subjects.Select(x => x.Subject_name).ToList());
                        ViewBag.error = "Đã tồn kỳ thi ở môn học " + mes;
                        return View();
                    }
                    var type = new TypeExam()
                    {
                        Name = model.Name,
                        Total_questions = model.Total_questions,
                        Time_to_do = model.Time_to_do,
                        Subjects = subs
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
        public IActionResult CreateQuestion()
            {
                bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
                var user = HttpContext.Session.Get<User>(UserSession.USER);
                var listSub = subjectRepository.GetAll().ToArray();
                
                ViewData["SUBS"] = listSub;
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
        public IActionResult CreateQuestion(QuestionModel model)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var user = HttpContext.Session.Get<User>(UserSession.USER);
            var listSub = subjectRepository.GetAll().ToArray();
            if (!(isLogin && user.IsAdmin()))
            {
                return Redirect("/login");
            }
            ViewData["USER"] = user;
            ViewData["SUBS"] = listSub;
            string uniqueFileName = ProcessUploadedFile(model);
            if (ModelState.IsValid && isLogin && user.IsAdmin())

            {
                var idSub = model.Id_Subject;
                var sub = subjectRepository.GetById(idSub);
                if(sub!= null)
                {
                    var question = new Question()
                    {
                        Content = model.Content,
                        Answer_a = model.Answer_a,
                        Answer_b = model.Answer_b,
                        Answer_c = model.Answer_c,
                        Answer_d = model.Answer_d,
                        Correct_answer = model.Correct_answer,
                        Img_content = uniqueFileName,
                        Subject = sub
                    };
                    questionRepository.Insert(question);
                    return RedirectToAction("Index", "Subject");
                }
            }
                return View();
        }

        private string ProcessUploadedFile(QuestionModel model)
        {
            string uniqueFileName = null;

            if (model.PICTURE != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PICTURE.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.PICTURE.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}

                