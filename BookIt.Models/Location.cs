namespace BookIt.Models
{
    using System.Collections.Generic;
    using BookIt.Contracts;

    public class Location : Rateable, IDeletableEntity, IAuditInfo, ICommentable, IRateable
    {
        public Location()
            : base()
        {
            this.Categories = new HashSet<Category>();
            this.Units = new HashSet<WorkingUnit>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int AddressID { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<WorkingUnit> Units { get; set; }
    }
}
