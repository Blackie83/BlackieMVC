using System;

namespace BlackieMVC.Models
{
  public class Administration_Facility
  {
    public int Id { get; set; }
    public string FacilityName { get; set; }
    public string FacilityCode { get; set; }
    public Administration_FacilityType FacilityType_Type_Id { get; set; }
    public string ImpiloUnitId { get; set; }
    public string ImpiloCountryId { get; set; }
    public string IMEDSConnectionString { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string ModifiedBy { get; set; }
    public string History { get; set; }
    public bool IsActive { get; set; }
  }
}