using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    public class Permission
    {
        public Permission()
        {
            this.Students = new HashSet<Student>();
            this.Admins = new HashSet<Admin>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_permission { get; set; }
        public string Permission_name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }

    }
}
