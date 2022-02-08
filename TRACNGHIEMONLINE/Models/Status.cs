using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    public class Status
    {
        public Status()
        {
            this.Tests = new HashSet<Test>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_status { get; set; }
        public string Status_name { get; set; }
        public Nullable<System.DateTime> Timestamps { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
