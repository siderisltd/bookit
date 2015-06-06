namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BusinessLocations
    {
        public int ID { get; set; }

        public float Rating { get; set; }

        public virtual ICollection<string> Comments { get; set; }

        public virtual ICollection<Unit> Units { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
