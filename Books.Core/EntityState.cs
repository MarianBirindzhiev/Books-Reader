﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core
{
    public enum EntityState // value type defined by a set of named constants of the underlying integral numeric type. 
    {
        Unchanged,
        Added,
        Changed,
        Deleted

    }
}
