using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class QuestionModel
    {
     
        public string Content { get; set; }
        public string Answer_a { get; set; }
        public string Answer_b { get; set; }
        public string Answer_c { get; set; }
        public string Answer_d { get; set; }
        public string Correct_answer { get; set; }
        public int Id_Subject { get; set; }
        public IFormFile PICTURE { get; set; }
    }
}
