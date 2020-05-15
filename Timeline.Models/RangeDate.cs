using System;

namespace Timeline.Models
{
    /// <summary>
    /// This class represents a generic date. Since some events have not a specific date (for example, Julius Caesar was born between 101 and 100 a.C.), there is a delta for every field.
    /// So, given a central date (01/01/-101), he was born with DeltaYear = 1 (so including -101 and -100
    /// </summary>
    public class RangeDate
    {
        public short Year { get; set; }
        public ushort Month { get; set; }
        public ushort Day { get; set; }

        public ushort DeltaYear { get; set; }
        public ushort DeltaMonth { get; set; }

        public ushort DeltaDay { get; set; }

    }
}
