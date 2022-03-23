using PW.Modules.Base.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Base.Entities.BaseEntities
{
    public abstract class AuditEntityForUser : BaseEntityForUser, IAuditEntityForUser<Guid>
    {
        protected AuditEntityForUser() { }

        public string CreatedByUser { get; set; }
        public Guid? CreatedByUserId { get; set; }
        public string CreatedByClient { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string UpdatedByUser { get; set; }
        public Guid? UpdateByUserId { get; set; }
        public string UpdatedByClient { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public virtual void ClearAudit() { }
    }
}
