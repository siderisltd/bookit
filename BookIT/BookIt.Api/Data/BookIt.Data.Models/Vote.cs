using BookIt.Data.Models.Contracts;
using BookIt.Data.Models.Model;

namespace BookIt.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Vote : DeletableEntity, IDeletableEntity, IVote
    {
        public int Id { get; set; }

        [Range(1, 5)]
        public int Value { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
