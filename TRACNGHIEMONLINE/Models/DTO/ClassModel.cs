using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class ClassModel
    {
       
        [MinLength(5, ErrorMessage = "Độ dài tên lớp học phải ít nhất 5 kí tự")]
        public string Class_name { get; set; }
      
        [MinLength(5, ErrorMessage = "Độ dài mô tả phải ít nhất 5 kí tự")]
        public string Description { get; set; }
    }
}
