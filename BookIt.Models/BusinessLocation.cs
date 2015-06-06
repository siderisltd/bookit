namespace BookIt.Models
{
    using BookIt.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BusinessLocation : ICommentable
    {
        public BusinessLocation()
        {
            this.Comments = new HashSet<IComment>();
            this.Units = new HashSet<Unit>();
            this.Categories = new HashSet<Category>();
        }

        public int ID { get; set; }

        public double Rating { get; set; }

        public virtual ICollection<IComment> Comments { get; set; }

        public virtual ICollection<Unit> Units { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
