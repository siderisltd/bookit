namespace BookIt.Data.Models
{
    using System.Collections.Generic;

    using BookIt.Data.Common.Model;

    public class Location : Rateable, IDeletableEntity, IAuditInfo, ICommentable, IRateable
    {
        public Location()
            : base()
        {
            this.Categories = new HashSet<Category>();
            this.Staff = new HashSet<StaffUnit>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<StaffUnit> Staff { get; set; }
    }
}
