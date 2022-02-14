using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class ExamModel
    {
        public int Id_Question { get; set; }
        public int Id_Sub { get; set; }
        public int Id_Type { get; set; }
        public string Content { get; set; }
        public string Answer_a { get; set; }
        public bool a { get; set; }
        public string Answer_b { get; set; }
        public bool b { get; set; }
        public string Answer_c { get; set; }
        public bool c { get; set; }
        public string Answer_d { get; set; }
        public bool d { get; set; }
        public String imageContent { get; set; }
    }
}
