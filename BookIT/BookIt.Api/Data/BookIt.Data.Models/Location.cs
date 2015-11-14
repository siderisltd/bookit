namespace BookIt.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using BookIt.Data.Common.Contracts;
    using BookIt.Data.Common.Model;

    public class Location : Rateable, IDeletableEntity, IAuditInfo, ICommentable, IRateable
    {
        private ICollection<Category> categories;

        private ICollection<StaffUnit> staff;

        public Location()
        {
            this.categories = new HashSet<Category>();
            this.staff = new HashSet<StaffUnit>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(400)]
        public string Description { get; set; }

        public virtual ICollection<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }

        public virtual ICollection<StaffUnit> Staff
        {
            get { return this.staff; }
            set { this.staff = value; }
        }
    }
}
