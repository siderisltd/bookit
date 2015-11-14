namespace BookIt.Data.Common.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using BookIt.Data.Common.Contracts;

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
