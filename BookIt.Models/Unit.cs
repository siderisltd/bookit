namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Unit
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        public int Experience { get; set; }

        public float Rating { get; set; }

        public string Biography { get; set; }

        public virtual ICollection<Service> ServicesProvided { get; set; }

        public virtual ICollection<DateTime> Schedule { get; set; }
    }
}
