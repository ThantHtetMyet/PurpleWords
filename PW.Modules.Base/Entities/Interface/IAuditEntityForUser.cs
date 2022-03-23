using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Base.Entities.Interface
{
    public interface IAuditEntityForUser<TKey> where TKey : struct
    {
        DateTimeOffset CreateDate { get; set; }
        DateTimeOffset UpdateDate { get; set; }
        string CreatedByUser { get; set; }
        string UpdatedByUser { get; set; }
        TKey? CreatedByUserId { get; set; }
        TKey? UpdateByUserId { get; set; }
        string CreatedByClient { get; set; }
        string UpdatedByClient { get; set; }
    }
}
