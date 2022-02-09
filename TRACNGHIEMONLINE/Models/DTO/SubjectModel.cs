using System.ComponentModel.DataAnnotations;
namespace TRACNGHIEMONLINE.Models.DTO
{
    public class SubjectModel
    {
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(5, ErrorMessage = "Độ dài tên môn học phải ít nhất 5 kí tự")]
        public string Subject_name { get; set; }

        [Required(ErrorMessage = "Please enter Description")]
        [MinLength(5, ErrorMessage = "Độ dài mô tả phải ít nhất 5 kí tự")]
        public string Description { get; set; }

    }

}
