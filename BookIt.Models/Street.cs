namespace BookIt.Models
{
    using BookIt.Contracts;

    public class Street: DeletableEntity, IDeletableEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
