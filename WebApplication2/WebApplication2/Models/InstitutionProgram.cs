//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InstitutionProgram
    {
        public int InstitutionProgramID { get; set; }
        public Nullable<int> InstitutionID { get; set; }
        public Nullable<int> ProgramID { get; set; }
    
        public virtual institution institution { get; set; }
        public virtual program program { get; set; }
    }
}
