namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Subscriptions
    {
        public DateTime SubscribedOn { get; set; }

        public DateTime? SubscriptionEnd { get; set; }

        public int BusinessID { get; set; }

        public bool SubscribedForEmails { get; set; }
    }
}
