namespace BookIt.Models
{
    using System.Collections.Generic;

    public class Service
    {
        public Service()
        {
            this.Providers = new HashSet<Unit>();
        }

        public int ID { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<Unit> Providers { get; set; }
    }
}
