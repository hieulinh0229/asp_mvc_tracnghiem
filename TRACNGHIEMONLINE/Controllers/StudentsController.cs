using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
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
                var classes = studentRepository.GetById(user.ID).Class;

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
                    var clas = classRepository.GetById(models.ID_CLASS);
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
        public IActionResult Test(int subId,int typeExId)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            if (isLogin)
            {
                
                var user = HttpContext.Session.Get<User>(UserSession.USER);
                var sub = subjectRepository.GetById(subId);
                var typeEx = examRepository.GetById(typeExId);

                var listSub = subjectRepository.GetAll().ToArray();
                var listQuestion = sub.Questions.ToList();
                ViewData["SUBS"] = sub;
                ViewData["TYPE"] = typeEx;
                ViewData["USER"] = user;

                if (sub != null && typeEx != null && listQuestion.Count> 0)
                {
                    var numberQuestion = typeEx.Total_questions;
                    if(typeEx.Total_questions  > listQuestion.Count)
                    {
                        ViewBag.error = " Không thể tạo đề kiểm tra";
                        return View();
                    }
                    var randomNumberList = GetRandomElements(listQuestion, numberQuestion);
                    List<ExamModel> listExams = new List<ExamModel>();
                    foreach (var item in randomNumberList)
                    {
                        var listAs = new List<Answer>();
                        listAs.Add(new Answer() { ID = 1, AnswerText = item.Answer_a });
                        listAs.Add(new Answer() { ID = 2, AnswerText = item.Answer_b });
                        listAs.Add(new Answer() { ID = 3, AnswerText = item.Answer_c });
                        listAs.Add(new Answer() { ID = 4, AnswerText = item.Answer_d });
                        var ex = new ExamModel()
                        {
                            Id_Question = item.Id_question,
                            Id_Sub = subId,
                            Answers = listAs,
                            Content = item.Content,
                            imageContent = item.Img_content,
                            Id_Type = typeExId
                        };
                        listExams.Add(ex);

                    };
                  
                    var model = new TestModel()
                    {
                        subId = subId,
                        typeExId = typeExId,
                        listExams = listExams
                    };
                    return View(model);
                }
                else
                {
                    ViewBag.error = " Không thể tạo đề kiểm tra";
                    return View();
                }
            }
            else
            {
                return Redirect("/login");
                // return View("Views/Admin/Admin.cshtml");
            }
        }
        [HttpPost]
        public IActionResult Test(TestModel model)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            if (isLogin )
            {
                var user = HttpContext.Session.Get<User>(UserSession.USER);
                if (ModelState.IsValid)
                {
                    var subId = model.subId;
                    var typeExId = model.typeExId;

                    var sub = subjectRepository.GetById(subId);
                    var typeEx = examRepository.GetById(typeExId);
                  
                    if(sub!=null && typeEx!= null)
                    {
                        
                    }
                }
                return RedirectToAction("index","Students");
            }
            else
            {
                return Redirect("/login");
                // return View("Views/Admin/Admin.cshtml");
            }
        }
        public  List<T> GetRandomElements<T>(IEnumerable<T> list, int elementsCount)
        {
            return list.OrderBy(x => Guid.NewGuid()).Take(elementsCount).ToList();
        }
        public IActionResult Detail()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            if (isLogin)
            {
                var admin = HttpContext.Session.Get<User>(UserSession.USER);
                return View(admin);
            }
            else
            {
                return Redirect("/login");
                // return View("Views/Admin/Admin.cshtml");
            }
        }
        [HttpPost]
        public IActionResult EditUser(User user)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var oldUser = studentRepository.GetById(user.ID);

            if (isLogin && oldUser != null && oldUser.permission.Permission_name.Equals(EnumPermission.STUDENT.ToString()))
            {
                if (user.PICTURE != null)
                {
                    try
                    {
                        string uniqueFileName = ProcessUploadedFile(user);
                        oldUser.Avatar = uniqueFileName;
                    }
                    catch (Exception e)
                    {
                        ViewBag.error = e.Message.ToString();

                    }
                }
                oldUser.Phone = user.PHONE;
                oldUser.Email = user.EMAIL;
                oldUser.Address = user.ADDRESS;
                oldUser.Name = user.NAME;
                oldUser.Gender = user.GENDER;
                if (user.PASSWORD != null)
                {
                    oldUser.Password = Common.Encryptor.MD5Hash(user.PASSWORD);
                }
                oldUser.Birthday = user.BIRTHDAY;

                try
                {
                    studentRepository.Update(oldUser);
                    user.AVATAR = oldUser.Avatar;
                    user.PICTURE = null;
                    HttpContext.Session.Set<User>(UserSession.USER, user);

                    return RedirectToAction("detail", "students");
                }
                catch
                {
                    ViewBag.error = "Xin vui lòng thử lại ";
                    return RedirectToAction("detail", "students");
                }
            }
            else
            {
                return Redirect("/login");
            }
        }
        private string ProcessUploadedFile(User model)
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
