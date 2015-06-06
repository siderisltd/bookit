namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Subscription
    {
        public int ID { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public int BusinessID { get; set; }

        public virtual BusinessLocation Business { get; set; }

        public bool SubscribedForEmails { get; set; }
    }
}
