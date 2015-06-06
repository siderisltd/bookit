namespace BookIt.Models
{
    using BookIt.Contracts;
    using System.Collections.Generic;

    public class Comment: IComment
    {
        public Comment()
        {
            this.User = new AppUser();
        }
        public int ID { get; set; }

        public string Content { get; set; }

        public virtual AppUser User { get; set; }
    }
}
