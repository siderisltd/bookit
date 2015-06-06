namespace BookIt.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IBookitInfo
    {
        DateTime CreatedOn { get; set; }

        bool PreserveCreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
