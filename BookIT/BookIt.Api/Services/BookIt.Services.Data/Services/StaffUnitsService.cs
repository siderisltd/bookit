namespace BookIt.Services.Data.Services
{
    using BookIt.Data.Common.Contracts;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Services.Data.Services.master;

    public class StaffUnitsService : DataService<StaffUnit>, IStaffUnitsService, IDataService<StaffUnit>
    {
        private readonly IRepository<StaffUnit> data;

        public StaffUnitsService(IRepository<StaffUnit> data)
            :base(data)
        {
        }
    }
}
