﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn04
{
    public class UtcAdjustment : IDateTimeOffsetAdjustment
    {
        public DateTimeOffset Adjust(DateTimeOffset value)
        {
            return value.ToUniversalTime();
        }
    }
}
