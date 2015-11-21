namespace BookIt.Server.DataTransferModels.Location.ViewModels
{
    using BookIt.Data.Models;
    using BookIt.Server.Common.Mapping;

    public class LocationDetailsViewModel : IMapFrom<Location>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
