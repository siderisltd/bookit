namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BookIt.Contracts;

    public class Business : IBusiness, ICommentable, IComment, IVote, IRateable, IAuditInfo, IDeletableEntity
    {
        public int ID
        {
            get { throw new NotImplementedException(); }
        }

        public string Content
        {
            get { throw new NotImplementedException(); }
        }

        public int Value
        {
            get { throw new NotImplementedException(); }
        }

        public double Rating
        {
            get { throw new NotImplementedException(); }
        }

        public bool PreserveCreatedOn
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

        public DateTime CreatedOn
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

        public DateTime? ModifiedOn
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

        public ICollection<IBusinessLocation> Locations
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

        public ICollection<IUnit> Units
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

        public ICategory Category
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

        public ICollection<IService> Services
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

        public ICollection<IComment> Comments
        {
            get { throw new NotImplementedException(); }
        }

        public ICollection<IVote> Votes
        {
            set { throw new NotImplementedException(); }
        }

    }
}
