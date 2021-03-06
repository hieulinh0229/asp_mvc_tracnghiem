using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models
{
    public class Admin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_admin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address{ get; set; }
        public System.DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> Last_login { get; set; }
        public Nullable<System.DateTime> Timestamps { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
