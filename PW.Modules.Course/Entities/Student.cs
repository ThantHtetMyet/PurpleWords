using PW.Modules.Base.Entities.BaseEntities;
using PW.Modules.Course.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.User.Entities
{
    [Table("Student", Schema = "PW")]
    public class Student : AuditEntityForUser
    {
        public Student() { }
        [MaxLength(50)]
        public string FName { get; set; }
        [MaxLength(20)]
        public string LName { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(20)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }

        #region Relation with "COURSE-STUDENT" Table
        public virtual ICollection<Course_Student> _course_students { get; set; }
        #endregion
    }
}
