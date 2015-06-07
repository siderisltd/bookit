namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BookIt.Contracts;

    public class Business : DeletableEntity, IDeletableEntity, IAuditInfo
    {
        public Business()
        {
            this.Locations = new HashSet<Location>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string OwnerID { get; set; }

        public virtual AppUser Owner { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
