using BookIt.Data.Models.Contracts;
using BookIt.Data.Models.Model;

namespace BookIt.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment : BookItEntity, IDeletableEntity, IComment, IBookItEntity
    {
        //public int Id { get; set; }

        [Required]
        [MaxLength(400)]
        public string Content { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
