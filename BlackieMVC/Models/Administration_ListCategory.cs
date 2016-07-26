using System;
using System.Collections.Generic;

namespace BlackieMVC.Models
{
  public class Administration_ListCategory
  {
    public int Id { get; set; }
    public Administration_Form Form_Form_Id { get; set; }
    public int Parent { get; set; }
    public string Name { get; set; }
    public bool LinkedCategory { get; set; }
    public Administration_ListCategoryLinked ListCategoryLinked_Category_Id { get; set; }
    public Administration_List List_LinkedParent_Id { get; set; }
    public Administration_List List_LinkedChild_Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string ModifiedBy { get; set; }
    public string History { get; set; }
    public bool IsActive { get; set; }

    public virtual List<Administration_List> List { get; set; }
  }
}