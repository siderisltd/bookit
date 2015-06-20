namespace BookIt.Models
{
    using System.Collections.Generic;

    using BookIt.Contracts;

    public class Category : DeletableEntity, IDeletableEntity
    {
        public Category()
        {
            this.Services = new HashSet<Service>();
            this.Locations = new HashSet<Location>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
