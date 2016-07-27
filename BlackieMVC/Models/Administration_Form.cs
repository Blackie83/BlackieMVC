namespace BlackieMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administration_Form
    {
        [Key]
        public int Form_Id { get; set; }

        public string Form_Name { get; set; }

        public string Form_Description { get; set; }

        public string Form_ReportNumberIdentifier { get; set; }

        public bool? Form_Print { get; set; }

        public bool? Form_Email { get; set; }

        public bool? Form_Admin { get; set; }

        public bool? Form_Unit { get; set; }

        public int? Form_CutOffDay { get; set; }

        public bool? Form_Maintenance { get; set; }

        public DateTime? Form_CreatedDate { get; set; }

        public string Form_CreatedBy { get; set; }

        public DateTime? Form_ModifiedDate { get; set; }

        public string Form_ModifiedBy { get; set; }

        public string Form_History { get; set; }

        public bool? Form_IsActive { get; set; }
    }
}
