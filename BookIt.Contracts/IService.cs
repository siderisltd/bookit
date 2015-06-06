namespace BookIt.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IService
    {
       int ID { get; set; }

       int Duration { get; set; }

       decimal Price { get; set; }

       int CategoryID { get; set; }

       ICategory Category { get; set; }

       ICollection<IUnit> Providers { get; set; }
    }
}
