using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    /**
     * Môn học
     */
    public class Subject
    {
        public Subject()
        {
            this.Questions = new HashSet<Question>();
            this.Tests = new HashSet<Test>();
            this.TypeExams = new HashSet<TypeExam>();
            this.Classes = new HashSet<Class>();

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_subject { get; set; }
        public string Subject_name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<TypeExam> TypeExams { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
