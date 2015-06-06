namespace BookIt.Models
{
    using System.Collections.Generic;
    
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
