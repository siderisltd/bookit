namespace BookIt.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IUnit
    {
        int ID { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

        char Gender { get; set; }

        int Experience { get; set; }

        float Rating { get; set; }

        string Biography { get; set; }
    }
}
