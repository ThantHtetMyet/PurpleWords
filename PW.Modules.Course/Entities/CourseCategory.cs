using PW.Modules.Base.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Course.Entities
{
    [Table("CourseCategory", Schema = "PW")]
    public class CourseCategory : AuditEntity
    {
        public CourseCategory() { }
        [MaxLength(20)]
        public string Type { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }

        #region Relation with "Course" Table
        public virtual Course _course { get; set; }
        #endregion
    }
}
