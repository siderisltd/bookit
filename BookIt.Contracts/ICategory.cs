namespace BookIt.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface ICategory
    {
        int ID { get; set; }

        string Name { get; set; }

        ICollection<IService> Services { get; set; }
    }
}
