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
    
    public partial class CurriculumPeople
    {
        public int curriculumpeopleID { get; set; }
        public int CurriculumID { get; set; }
        public int PersonID { get; set; }
    
        public virtual curriculum curriculum { get; set; }
        public virtual Person Person { get; set; }
    }
}
