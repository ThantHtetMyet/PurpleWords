using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Base.Entities.Interface
{
    public interface IBaseGrade
    {
        public string Level { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
    }
}
