namespace BookIt.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BookIt.Data.Common.Model;

    public class Business : DeletableEntity, IDeletableEntity, IAuditInfo
    {
        public Business()
        {
            this.Locations = new HashSet<Location>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string OwnerId { get; set; }

        public virtual ApplicationUser Owner { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
