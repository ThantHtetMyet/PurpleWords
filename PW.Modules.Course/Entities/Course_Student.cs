using PW.Modules.Base.Entities.BaseEntities;
using PW.Modules.User.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Course.Entities
{
    [Table("CourseStudent", Schema = "PW")]
    public class Course_Student : AuditEntity
    {
        public Course_Student() { }
        #region Relation with COURSE Table
        [Required]
        public Guid CourseId { get; set; }
        public virtual Course _course { get; set; }
        #endregion
        #region Relation with STUDENT Table
        [Required]
        public Guid StudentId { get; set; }
        public virtual Student _student { get; set; }
        #endregion
    }
}
