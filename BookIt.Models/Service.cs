namespace BookIt.Models
{
    using BookIt.Contracts;
    using System.Collections.Generic;

    public class Service : IDeletableEntity
    {
        public Service()
        {
            this.Providers = new HashSet<IUnit>();
        }

        public int ID { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public bool IsDeleted
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public System.DateTime? DeletedOn
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public ICollection<IUnit> Providers { get; set; }

    }
}
