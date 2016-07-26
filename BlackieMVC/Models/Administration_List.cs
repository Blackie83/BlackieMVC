using System;

namespace BlackieMVC.Models
{
  public class Administration_List
  {
    public int Id { get; set; }
    public virtual Administration_ListCategory ListCategory_Category_Id { get; set; }
    public int Parent { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string ModifiedBy { get; set; }
    public string History { get; set; }
    public bool IsActive { get; set; }
  }
}