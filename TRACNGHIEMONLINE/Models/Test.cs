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
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id_test { get; set; }
        public string Test_name { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> Timestamps { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual Student Student { get; set; }
        public virtual Score Score { get; set; }
        public virtual TypeExam Type { get; set; }
        public virtual Status Status { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
