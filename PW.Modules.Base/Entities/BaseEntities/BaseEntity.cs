using PW.Modules.Base.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Base.Entities.BaseEntities
{
    public abstract class BaseEntity : ISingleKey<Guid>, IDeletable, IConcurrencyToken
    {
        protected BaseEntity() { }

        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? ConcurrencyToken { get; set; }
        public bool IsNotStored { get; }

    }
}
