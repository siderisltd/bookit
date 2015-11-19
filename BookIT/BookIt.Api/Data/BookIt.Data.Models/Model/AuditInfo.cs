using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookIt.Data.Models.Contracts;

namespace BookIt.Data.Models.Model
{
    public class AuditInfo : IAuditInfo
    {
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Specifies whether or not the CreatedOn property should be automatically set.
        /// </summary>
        [NotMapped]
        public bool PreserveCreatedOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }
    }
}
