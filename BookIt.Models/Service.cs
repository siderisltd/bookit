namespace BookIt.Models
{
    using System.Collections.Generic;
    using BookIt.Contracts;

    public class Service : DeletableEntity, IDeletableEntity
    {
        public Service()
        {
            this.Providers = new HashSet<WorkingUnit>();
        }

        public int ID { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<WorkingUnit> Providers { get; set; }
    }
}
