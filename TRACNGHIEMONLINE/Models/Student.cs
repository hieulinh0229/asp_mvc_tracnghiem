using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    public class Student
    {
        public Student()
        {
            this.Tests = new HashSet<Test>();
            this.Class = new HashSet<Class>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_student { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public string time_remaining { get; set; }
        public Nullable<System.DateTime> last_login { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual Permission permission { get; set; }
        public virtual ICollection<Class> Class { get; set; }
    }
}
