using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    /**
     * Điểm sinh viên
     */
    public class Score
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_score { get; set; }
        public int Id_student { get; set; }
        public int Id_code { get; set; }
        public Nullable<System.DateTime> Time_finish { get; set; }
        public double Score_number { get; set; }
        public string Detail { get; set; }
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }

    }
}
