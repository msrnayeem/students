//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentAssignment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Table
    {
        public System.Guid id { get; set; }
        public string Name { get; set; }
        public System.DateTime DOB { get; set; }
        public int ClassId { get; set; }
        public System.DateTime Created_Date { get; set; }
        public System.DateTime Modification_Date { get; set; }
    
        public virtual Class_Table Class_Table { get; set; }
    }
}
