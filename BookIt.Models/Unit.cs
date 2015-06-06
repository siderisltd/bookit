namespace BookIt.Models
{
    using BookIt.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Unit : IUnit, IDeletableEntity
    {
        public Unit()
        {
            this.ServicesProvided = new HashSet<Service>();
            this.Schedule = new HashSet<DateTime>();
            this.Votes = new HashSet<Vote>();
        }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        public int Experience { get; set; }

        public float Rating { get; set; }

        public string Biography { get; set; }

        public bool IsDeleted
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? DeletedOn
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual ICollection<Service> ServicesProvided { get; set; }

        public virtual ICollection<DateTime> Schedule { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
