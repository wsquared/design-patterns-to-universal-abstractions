﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn04
{
    public interface IDateTimeOffsetAdjustment
    {
        DateTimeOffset Adjust(DateTimeOffset value);
    }
}
