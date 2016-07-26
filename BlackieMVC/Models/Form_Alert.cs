using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackieMVC.Models
{
  class Form_Alert
  {
    public int Id { get; set; }
    public Administration_Facility Facility_To_Id { get; set; }
    public Administration_Facility Facility_From_Id { get; set; }
    public string ReportNumber { get; set; }
    public DateTime Date { get; set; }
    public string Originator { get; set; }
    public Administration_Unit Unit_From_Id { get; set; }
    public Administration_Unit Unit_To_Id { get; set; }
    public string Description { get; set; }
    public string ActionTaken { get; set; }
    public Administration_List List_Level1_Id { get; set; }
    public Administration_List List_Level2_Id { get; set; }
    public int NumberOfInstances { get; set; }
    public Administration_List List_Status_Id { get; set; }
    public DateTime StatusDate { get; set; }
    public string StatusRejectedReason { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string ModifiedBy { get; set; }
    public string History { get; set; }
    public bool Archived { get; set; }
  }
}
