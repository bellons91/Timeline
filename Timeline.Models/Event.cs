using System;
using System.Collections.Generic;
using System.Text;

namespace Timeline.Models
{
    /// <summary>
    /// Generic event, not related to a specific person. Examples are the publishing of a book, a war, a specific invention and the release of an album.
    /// </summary>
    public class Event
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public RangeDate Date { get; set; }
    }
}
