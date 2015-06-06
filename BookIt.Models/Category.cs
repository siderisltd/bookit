namespace BookIt.Models
{
    using BookIt.Contracts;
    using System.Collections.Generic;
    
    public class Category : ICategory
    {
        public Category()
        {
            this.Services = new HashSet<IService>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<IService> Services { get; set; }
    }
}
