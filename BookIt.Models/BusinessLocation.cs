namespace BookIt.Models
{
    using BookIt.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BusinessLocation : IBusinessLocation, ICommentable
    {
        public BusinessLocation()
        {
            this.Comments = new HashSet<IComment>();
            this.Units = new HashSet<IUnit>();
            this.Categories = new HashSet<ICategory>();
        }

        public int ID { get; set; }

        public double Rating { get; set; }

        public virtual ICollection<IComment> Comments { get; set; }

        public virtual ICollection<IUnit> Units { get; set; }

        public virtual ICollection<ICategory> Categories { get; set; }
    }
}
