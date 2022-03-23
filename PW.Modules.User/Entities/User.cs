using PW.Modules.Base.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.User.Entities
{
    [Table("User", Schema = "PW")]
    public class User : AuditEntity
    {
        public User() { }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string EncodedPassword { get; set; }
    }
}
