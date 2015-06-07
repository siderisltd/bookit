namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BookIt.Contracts;

    public class Address : DeletableEntity, IDeletableEntity, IAuditInfo
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public virtual City City { get; set; }

        public virtual Street Street { get; set; }

        public string StreetNumber { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }
    }
}
