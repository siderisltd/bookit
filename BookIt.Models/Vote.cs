namespace BookIt.Models
{
    using System.ComponentModel.DataAnnotations;

    using BookIt.Contracts;

    public class Vote : IVote
    {
        public int ID { get; set; }
        [Range(1, 5)]
        public int Value { get; set; }

        public virtual AppUser User { get; set; }
    }
}
