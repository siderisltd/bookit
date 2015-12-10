using BookIt.Data.Models;
using BookIt.Server.Common.Mapping;

namespace BookIt.Server.DataTransferModels.Locations.ViewModels
{
    public class LocationDetailsViewModel : IMapFrom<Location>, IViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
