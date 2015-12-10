using System;

namespace BookIt.Data.Models.Contracts
{
    public interface IBookItEntity
    {
        int Id { get; set; }

        DateTime CreatedOn { get; set; }

        bool PreserveCreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }

        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
