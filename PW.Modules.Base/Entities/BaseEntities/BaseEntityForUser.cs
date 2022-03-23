using PW.Modules.Base.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Base.Entities.BaseEntities
{
    public abstract class BaseEntityForUser : ISingleKey<Guid>, IDeletable, IConcurrencyToken
    {
        protected BaseEntityForUser() { }
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? ConcurrencyToken { get; set; }
        public string LastLogInDate { get; set; }
        public string LastLogInIp { get; set; }

    }
}
