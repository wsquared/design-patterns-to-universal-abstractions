using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn04
{
    public class CompositeDateTimeOffsetAdjustment : IDateTimeOffsetAdjustment
    {
        private readonly IReadOnlyCollection<IDateTimeOffsetAdjustment> adjustments;

        public CompositeDateTimeOffsetAdjustment(
            params IDateTimeOffsetAdjustment[] adjustments)
        {
            this.adjustments = adjustments;
        }

        public DateTimeOffset Adjust(DateTimeOffset value)
        {
            var acc = value; 
            foreach (var adjustment in adjustments)
            {
                acc = adjustment.Adjust(value);
            }

            return acc;
        }
    }
}
