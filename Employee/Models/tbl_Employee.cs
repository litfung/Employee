//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Employee
    {
        public tbl_Employee()
        {
            this.tbl_EmployeeDetails = new HashSet<tbl_EmployeeDetails>();
        }
    
        public int emp_Id { get; set; }
        public string emp_Login { get; set; }
        public string emp_Password { get; set; }
        public Nullable<System.DateTime> emp_CreateDate { get; set; }
        public Nullable<System.DateTime> emp_LastLogin { get; set; }
        public Nullable<bool> emp_IsRemove { get; set; }
    
        public virtual ICollection<tbl_EmployeeDetails> tbl_EmployeeDetails { get; set; }
    }
}
