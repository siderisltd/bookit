using BookIt.Server.Common.Mapping;

namespace BookIt.Server.DataTransferModels.Locations.BindingModels 
{
    public class AddLocationBindingModel : IMapFrom<Data.Models.Location>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
