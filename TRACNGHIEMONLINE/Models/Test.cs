using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    public class Test
    {
        public Test()
        {
            this.Questions = new HashSet<Question>();
            this.Scores = new HashSet<Score>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id_test { get; set; }
        public string Test_name { get; set; }
        public int Total_questions { get; set; }
        public int Time_to_do { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> Timestamps { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
        public virtual Status Status { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
