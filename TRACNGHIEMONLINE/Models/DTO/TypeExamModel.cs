using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class TypeExamModel
    {
        [MinLength(5, ErrorMessage = "Độ dài tên lớp học phải ít nhất 5 kí tự")]
        public string Name { get; set; }
        [Range(1,50, ErrorMessage = "tổng số câu lớn hơn 1 bé hơn 50")]
        public int Total_questions { get; set; }
        [Range(1, 50, ErrorMessage = "Thời gian lớn hơn 1 bé hơn 50")]
        public int Time_to_do { get; set; }
        public List<int> Id_sub { get; set; }
    }
}
