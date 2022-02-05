using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.Common;

namespace TRACNGHIEMONLINE.Models
{
    public class LoginModel
    {
        
    
        [Display(Name = "Tài Khoản")]
        public string Username { get; set; }
        [Display(Name = "Mật Khẩu")]
        public string Password { get; set; }

        public User CheckLogin(LoginModel model, List<Admin> admins, List<Student> students)
        {
            model.Password = Common.Encryptor.MD5Hash(model.Password);
            Admin admin = null;
            Student student = null;
           
            if (admins.Count > 0)
            {
                admin = admins.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            }
            if(students.Count > 0)
            {
                student = students.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            }
            if(admin == null && student == null)
            {
                return null;
            }
           
           
            if (admin!= null)
            {
              
                return new User()
                {
                 
                    AVATAR = admin.Avatar,
                    EMAIL = admin.Email,
                    NAME = admin.Name,
                    ISLOGIN = true,
                    PERMISSION = admin.Permission.Id_permission,
                    PERMISSION_NAME = admin.Permission.Permission_name,
                    ID = admin.Id_admin,
                    GENDER = admin.Gender,
                    BIRTHDAY = admin.Birthday,
                    LAST_LOGIN = admin.Last_login,
                    PHONE = admin.Phone,
                    ADDRESS = admin.Address,
                    PASSWORD = admin.Password

                };
            }
            if (student != null)
            {
              
                return new User()
                {
                    AVATAR = student.Avatar,
                    EMAIL = student.Email,
                    NAME = student.Name,
                    ISLOGIN = true,
                    PERMISSION = student.permission.Id_permission,
                    PERMISSION_NAME = student.permission.Permission_name,
                    ID = student.Id_student,
                    GENDER = student.Gender,
                    BIRTHDAY = student.Birthday,
                    LAST_LOGIN = student.last_login,
                    PHONE = student.Phone,
                    ADDRESS = student.Address,
                    PASSWORD = student.Password
                };
            }
            return null;

        
        }
   
     
    
}
}
