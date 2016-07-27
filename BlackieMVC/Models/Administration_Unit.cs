namespace BlackieMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administration_Unit
    {
        [Key]
        public int Unit_Id { get; set; }

        public string Unit_Name { get; set; }

        public string Unit_Description { get; set; }

        public DateTime? Unit_CreatedDate { get; set; }

        public string Unit_CreatedBy { get; set; }

        public DateTime? Unit_ModifiedDate { get; set; }

        public string Unit_ModifiedBy { get; set; }

        public string Unit_History { get; set; }

        public bool? Unit_IsActive { get; set; }
    }
}
