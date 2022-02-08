using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    public class TypeExam {
        public TypeExam()
        {
            this.Subjects = new HashSet<Subject>();
        }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public string Id { get; set; }
    public string Name { get; set; }
    public int Total_questions { get; set; }
    public int Time_to_do { get; set; }
    public virtual ICollection<Subject> Subjects { get; set; }
    }

}
