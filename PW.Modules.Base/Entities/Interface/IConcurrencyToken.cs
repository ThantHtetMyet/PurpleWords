﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.Base.Entities.Interface
{
    public interface IConcurrencyToken
    {
        Guid? ConcurrencyToken { get; set; }
    }
}
