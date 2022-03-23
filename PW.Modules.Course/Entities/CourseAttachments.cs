using PW.Modules.Base.Entities.BaseEntities;
using PW.Modules.Course.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Course.Entities
{

    [Table("CourseAttachments", Schema = "PW")]
    public class CourseAttachments : AuditEntity
    {
        public CourseAttachments() { }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string ImageType { get; set; }
        [MaxLength(50)]
        public string ImagePath { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [MaxLength(200)]
        public string EncodedData { get; set; }

    }
}
