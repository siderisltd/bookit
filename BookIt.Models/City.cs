namespace BookIt.Models
{
    using BookIt.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class City : DeletableEntity, IDeletableEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
