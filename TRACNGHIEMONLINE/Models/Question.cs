using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    public class Question
    {
        public Question()
        {
            this.Tests = new HashSet<Test>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_question { get; set; }
        public string Img_content { get; set; }
        public string Content { get; set; }
        public string Answer_a { get; set; }
        public string Answer_b { get; set; }
        public string Answer_c { get; set; }
        public string Answer_d { get; set; }
        public string Correct_answer { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
