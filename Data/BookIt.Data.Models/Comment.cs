namespace BookIt.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using BookIt.Data.Common.Model;
    using BookIt.Data.Common.Contracts;

    public class Comment : DeletableEntity, IDeletableEntity, IComment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(400)]
        public string Content { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
