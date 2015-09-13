namespace BookIt.Data.Models
{
    using System;

    using BookIt.Data.Common.Model;

    public class Comment : DeletableEntity, IDeletableEntity, IComment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
