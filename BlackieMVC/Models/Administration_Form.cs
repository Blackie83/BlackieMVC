using System;

namespace BlackieMVC.Models
{
  public class Administration_Form
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ReportNumberIdentifier { get; set; }
    public bool Print { get; set; }
    public bool Email { get; set; }
    public bool Admin { get; set; }
    public bool Unit { get; set; }
    public int CutOffDay { get; set; }
    public bool Maintenance { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string ModifiedBy { get; set; }
    public string History { get; set; }
    public bool IsActive { get; set; }
  }
}