using PW.Modules.Base.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PW.Modules.Course.Entities
{
    [Table("Course", Schema = "PW")]
    public class Course : AuditEntity
    {
        public Course() { }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Details { get; set; }
        public DateTimeOffset CourseStartDate { get; set; }
        public DateTimeOffset CourseEndEnd { get; set; }
        public double Fee { get; set; }

        #region Relation with "CourseCategory" Table 
        [ForeignKey("CourseCategory")]
        public Guid CourseCategoryId { get; set; }
        public virtual CourseCategory _courseCategory { get; set; }
        #endregion

        #region Relation with "Grade" Table 
        [ForeignKey("GradeId")]
        public Guid GradeId { get; set; }
        public virtual Grade _grade { get; set; }
        #endregion

        #region Relation with "CourseAttachment" Table
        public virtual ICollection<CourseAttachments> _courseAttachments { get; set; }
        #endregion

        #region Relation with "COURSE-STUDENT" Table
        public virtual ICollection<Course_Student> _course_students { get; set; }
        #endregion
    }
}
