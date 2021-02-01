namespace BDAT1007_Group7_A1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobPosting
    {
        [Key]
        [Column("Job Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Job_Id { get; set; }

        [StringLength(8060)]
        public string Title { get; set; }

        [StringLength(8060)]
        public string Company { get; set; }

        [StringLength(8060)]
        public string City { get; set; }

        [StringLength(8060)]
        public string Province { get; set; }

        [Column("Days posted")]
        public int? Days_posted { get; set; }

        public string URL { get; set; }
    }
}
