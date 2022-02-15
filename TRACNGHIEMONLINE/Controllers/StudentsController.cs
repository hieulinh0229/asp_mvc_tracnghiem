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
        public readonly ITestRepository testRepository;
        public StudentsController(
            IAdminRepository _adminRepository,
            IWebHostEnvironment hostEnvironment
            , IClassRepository classRepository,
            ISubjectRepository subjectRepository,
             ITypeExamRepository examRepository,
             IStudentRepository studentRepository,
             IQuestionRepository questionRepository,
             ITestRepository testRepository)
        {
            this.adminRepository = _adminRepository;
            this.webHostEnvironment = hostEnvironment;
            this.classRepository = classRepository;
            this.subjectRepository = subjectRepository;
            this.examRepository = examRepository;
            this.studentRepository = studentRepository;
            this.questionRepository = questionRepository;
            this.testRepository = testRepository;
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
                                Password = Common.Encryptor.MD5Hash("1"),
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
                   
                    List<Models.DTO.Question> Questions = new List<Models.DTO.Question>();
                    for (int i = 0; i < randomNumberList.Count; i++)
                    {
                        Models.Question item = randomNumberList[i];
                        var ques = new Models.DTO.Question {
                            Index = i +1,
                            ID = item.Id_question,
                            QuestionText = item.Content,
                            CorrectAnswer = item.Correct_answer,
                            ImageAnswer = item.Img_content };
                        ques.Answers.Add(new Answer() { ID = "A", AnswerText = item.Answer_a });
                        ques.Answers.Add(new Answer() { ID = "B", AnswerText = item.Answer_b });
                        ques.Answers.Add(new Answer() { ID = "C", AnswerText = item.Answer_c });
                        ques.Answers.Add(new Answer() { ID = "D", AnswerText = item.Answer_d });
                        Questions.Add(ques);
                    };
                    var evalVM = new Evaluation() { 
                        Questions = Questions,
                        Id_Sub = subId,
                        Id_Type = typeExId
                    };
                    return View(evalVM);
                  
                }
                else
                {
                    ViewBag.error = " Không thể tạo đề kiểm tra";
                    return RedirectToAction("index", "Students");
                }
            }
            else
            {
                return Redirect("/login");
                // return View("Views/Admin/Admin.cshtml");
            }
        }
        [HttpPost]
        public IActionResult Test(Evaluation model)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            if (isLogin )
            {
                var user = HttpContext.Session.Get<User>(UserSession.USER);
                if (ModelState.IsValid)
                {
                   
                    var sub = subjectRepository.GetById(model.Id_Sub);
                    var typeEx = examRepository.GetById(model.Id_Type);
                    var student = studentRepository.GetById(model.Id_Type);
                    var listIdQues = model.Questions.Select(x => x.ID).ToList();
                    var listQues = sub.Questions.Where(x => listIdQues.Contains(x.Id_question)).ToList();
                    int countCorrect = model.Questions.Where(x => x.CorrectAnswer.Equals(x.SelectedAnswer)).ToList().Count;
                    int countQ = model.Questions.Count;
                    decimal SC = countCorrect / countQ * 100;
                    var test = new Test()
                    {
                        Test_name = typeEx.Name,
                        Timestamps = DateTime.Now,
                        Student = student,
                        Type = typeEx,
                        Subject = sub,
                        Questions = listQues,
                        Score = Math.Round(SC, 0),
                        Status = Math.Round(SC, 0) >=5
                    };

                    testRepository.Insert(test);
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
