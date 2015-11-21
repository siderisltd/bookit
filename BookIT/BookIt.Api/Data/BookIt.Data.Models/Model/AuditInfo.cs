using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookIt.Data.Models.Contracts;

namespace BookIt.Data.Models.Model
{
    public class AuditInfo : IAuditInfo
    {
        public AuditInfo()
        {
            this.CreatedOn = DateTime.Now;
        }

        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        //TODO:Remove???
        /// <summary>
        /// Specifies whether or not the CreatedOn property should be automatically set.
        /// </summary>
        [NotMapped]
        public bool PreserveCreatedOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }
    }
}
