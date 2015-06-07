namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using BookIt.Contracts;

    public class Comment: IComment
    {
        public int ID { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public string UserID { get; set; }

        public virtual AppUser User { get; set; }
    }
}
