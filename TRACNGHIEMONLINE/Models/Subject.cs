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
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_subject { get; set; }
        public string Subject_name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
         }
}
