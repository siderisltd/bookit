namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BookIt.Contracts;

    public class Engagement : DeletableEntity, IDeletableEntity, IAuditInfo
    {
        public int ID { get; set; }

        public int BusinessID { get; set; }

        public bool SubscribedForEmails { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public virtual Location Business { get; set; }
    }
}
