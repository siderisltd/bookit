namespace BookIt.Data.Common.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }

        bool PreserveCreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
