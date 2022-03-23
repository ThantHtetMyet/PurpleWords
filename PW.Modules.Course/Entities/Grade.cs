using PW.Modules.Base.Entities.BaseEntities;
using PW.Modules.Base.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Course.Entities
{
    [Table("Grade", Schema = "PW")]
    public class Grade : AuditEntity, IBaseGrade
    {
        public Grade() { }
        public string Level { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }

        #region Relation with "Course" Table 
        public virtual Course _course { get; set; }
        #endregion
    }
}
