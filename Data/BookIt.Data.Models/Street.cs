namespace BookIt.Data.Models
{
    using BookIt.Data.Common.Model;

    public class Street: DeletableEntity, IDeletableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
