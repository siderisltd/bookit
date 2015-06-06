namespace BookIt.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IBusinessLocation
    {
       int ID { get; set; }

       double Rating { get; set; }

       ICollection<IComment> Comments { get; set; }

       ICollection<IUnit> Units { get; set; }

       ICollection<ICategory> Categories { get; set; }
    }
}
