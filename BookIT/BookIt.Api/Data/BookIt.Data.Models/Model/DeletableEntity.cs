using System;
using System.ComponentModel.DataAnnotations;
using BookIt.Data.Models.Contracts;

namespace BookIt.Data.Models.Model
{
    public abstract class DeletableEntity : AuditInfo, IDeletableEntity
    {
        [Display(Name = "Deleted?")]
        [Editable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Date of deletion")]
        [Editable(false)]
        [DataType(DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }
    }
}
