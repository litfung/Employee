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
    
    public partial class EmployeeDatabase
    {
        public int emp_Id { get; set; }
        public string emp_login { get; set; }
        public string emp_Password { get; set; }
        public Nullable<System.DateTime> emp_CreateDate { get; set; }
        public System.DateTime emp_lastLogin { get; set; }
        public Nullable<bool> emp_IsRemove { get; set; }
        public string emp_FirstName { get; set; }
        public string emp_MiddleName { get; set; }
        public string emp_LastName { get; set; }
        public string emp_CityName { get; set; }
        public string emp_CountryName { get; set; }
        public string emp_ResidentialAddress { get; set; }
        public string emp_ResidentialPostCode { get; set; }
        public bool emp_IsAdmin { get; set; }
    }
}