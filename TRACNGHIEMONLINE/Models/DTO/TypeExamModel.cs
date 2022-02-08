using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class TypeExamModel
    { 
        public string Name { get; set; }
        public int Total_questions { get; set; }
        public int Time_to_do { get; set; }
        public int Id_sub { get; set; }
    }
}
