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
        public List<Answer> Answers { set; get; }
         public string Answer { get; set; }
         public string Content { get; set; }
        public String imageContent { get; set; }
    }
}
