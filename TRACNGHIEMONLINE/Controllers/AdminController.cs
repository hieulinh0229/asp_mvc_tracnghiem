using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.Common;
using TRACNGHIEMONLINE.Models;
using TRACNGHIEMONLINE.Repositories;

namespace TRACNGHIEMONLINE.Controllers
{
    public class AdminController : Controller
    {
        public readonly IAdminRepository adminRepository;
        public readonly IClassRepository classRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public AdminController(IAdminRepository _adminRepository, IWebHostEnvironment hostEnvironment, IClassRepository classRepository)
        {
            this.adminRepository = _adminRepository;
            this.webHostEnvironment = hostEnvironment;
            this.classRepository = classRepository;
        }
        public IActionResult Index()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var user = HttpContext.Session.Get<User>(UserSession.USER);
            if (isLogin && user.IsAdmin())
            {
                return View(user);
            }
            else
            {
                return Redirect("login");
                // return View("Views/Admin/Admin.cshtml");
            }
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
        
        public IActionResult StudentManagement()
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            Class[] listClass = classRepository.GetAll().ToArray();
            if (isLogin)
            {
                var admin = HttpContext.Session.Get<User>(UserSession.USER);
                ViewData["CLASS"] = listClass;
                return View(admin);
            }
            else
            {
                return Redirect("/login");
                // return View("Views/Admin/Admin.cshtml");
            }
        }
        [HttpPost]
        public IActionResult EditAdmin(User user)
        {
            bool isLogin = HttpContext.Session.Get<bool>(UserSession.ISLOGIN);
            var oldAdmin = adminRepository.GetById(user.ID);
         
            if (isLogin && oldAdmin!= null && oldAdmin.Permission.Permission_name.Equals(EnumPermission.ADMIN))
                {
                    if(user.PICTURE != null)
                    {
                        try
                        {
                            string uniqueFileName = ProcessUploadedFile(user);
                            oldAdmin.Avatar = uniqueFileName;
                        }catch(Exception e)
                        {
                            ViewBag.error = e.Message.ToString();

                        }
                    }
                    oldAdmin.Phone = user.PHONE;
                    oldAdmin.Email = user.EMAIL;
                    oldAdmin.Address = user.ADDRESS;
                    oldAdmin.Name = user.NAME;
                    oldAdmin.Gender = user.GENDER;
                    if(user.PASSWORD!=null)
                    {
                    oldAdmin.Password = Common.Encryptor.MD5Hash(user.PASSWORD);
                    }
                    oldAdmin.Birthday = user.BIRTHDAY;
                   
                try
                {
                    adminRepository.Update(oldAdmin);
                    user.AVATAR = oldAdmin.Avatar;
                    user.PICTURE = null;
                    HttpContext.Session.Set<User>(UserSession.USER, user);

                    return RedirectToAction("detail", "admin");
                }catch
                {
                    ViewBag.error = "Xin vui lòng thử lại ";
                    return RedirectToAction("detail", "admin");
                }
            } else
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
