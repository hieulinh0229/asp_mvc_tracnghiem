using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Controllers
{
    public class LogOutController : Controller
    {
        public ActionResult Index()
        {
            HttpContext.Session.Clear();
            return Redirect("login");
        }
    }
}
