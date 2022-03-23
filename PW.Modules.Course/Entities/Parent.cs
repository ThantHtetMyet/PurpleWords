using PW.Modules.Base.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PW.Modules.User.Entities
{
    [Table("Parent", Schema = "PW")]
    public class Parent : AuditEntityForUser
    {
        public Parent() { }
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

        #region Relation with "STUDENT" Table
        public ICollection<Student> _student { set; get; }
        #endregion
    }
}
