using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Base.Dtos
{
    public class BaseDto
    {
        public BaseDto() { }
        public Guid Id { get; set; }
        public Guid? ConcurrencyToken { get; set; }
    }
}
