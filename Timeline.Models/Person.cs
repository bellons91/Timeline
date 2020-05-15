using System;
using System.Collections.Generic;
using System.Text;

namespace Timeline.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Aka { get; set; }
        public RangeDate BirthDate { get; set; }
        public RangeDate? DeathDate { get; set; }
    }
}
