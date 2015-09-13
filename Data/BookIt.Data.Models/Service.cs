namespace BookIt.Data.Models
{
    using System.Collections.Generic;

    using BookIt.Data.Common.Model;

    public class Service : DeletableEntity, IDeletableEntity
    {
        public Service()
        {
            this.Providers = new HashSet<StaffUnit>();
        }

        public int Id { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<StaffUnit> Providers { get; set; }
    }
}
