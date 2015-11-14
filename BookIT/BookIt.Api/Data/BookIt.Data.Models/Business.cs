namespace BookIt.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using BookIt.Data.Common.Contracts;
    using BookIt.Data.Common.Model;

    public class Business : DeletableEntity, IDeletableEntity, IAuditInfo
    {
        private ICollection<Location> locations;

        public Business()
        {
            this.locations = new HashSet<Location>();
        }

        public int Id { get; set; }

        [Index]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string OwnerId { get; set; }

        public virtual ApplicationUser Owner { get; set; }

        public virtual ICollection<Location> Locations
        {
            get { return this.locations; }
            set { this.locations = value; }
        }
    }
}
