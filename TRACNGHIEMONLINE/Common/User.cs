using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Common
{
    public class User
    {

        public bool ISLOGIN { get; set; } = false;
        public int ID { get; set; }
        public int PERMISSION { get; set; }
       
        public String PERMISSION_NAME { get; set; }
        public String USERNAME { get; set; }
        public String EMAIL { get; set; }
        public string AVATAR { get; set; }
        public IFormFile PICTURE { get; set; }
        public String NAME { get; set; }
        public String GENDER { get; set; }
        public DateTime BIRTHDAY { get; set; }
        public String PHONE { get; set; }
        public String ADDRESS { get; set; }
        public String PASSWORD { get; set; }
        public Nullable<DateTime>  LAST_LOGIN { get; set; }
        public bool IsLogin()
        {
                if (ISLOGIN)
                    return true;
                return false;
          
        }
    
        public bool IsAdmin()
        {
          
         if (ISLOGIN && PERMISSION_NAME.Equals(EnumPermission.ADMIN.ToString()))
                    return true;
            return false;

        }
        public bool IsStudent()
        {
          if (ISLOGIN && PERMISSION.Equals(EnumPermission.STUDENT.ToString()))
                    return true;
                return false;
        }
      
    }
}
