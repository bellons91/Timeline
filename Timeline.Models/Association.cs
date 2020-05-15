using System;
using System.Collections.Generic;
using System.Text;

namespace Timeline.Models
{
    /// <summary>
    /// Generic class for associations, like a parliament, a rock band and so on.
    /// </summary>
    public class Association
    {
        public string What { get; set; }
        public RangeDate StartDate { get; set; }
        public RangeDate? EndDate { get; set; }
    }
}
