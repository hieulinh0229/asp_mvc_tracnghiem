using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class SudentModels
    {
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(5, ErrorMessage = "Độ dài tên môn học phải ít nhất 5 kí tự")]
        public String USERNAME { get; set; }
        public String EMAIL { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(5, ErrorMessage = "Độ dài tên môn học phải ít nhất 5 kí tự")]
        public String NAME { get; set; }
        [Required(ErrorMessage = "Please chọn name")]
        public String GENDER { get; set; }
        public DateTime BIRTHDAY { get; set; }
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public String PHONE { get; set; }
        [Required(ErrorMessage = "ADDRESS is required.")]
        public String ADDRESS { get; set; }
        [Required(ErrorMessage = "CLASS is required.")]
        public int ID_CLASS { get; set; }
    }
}
