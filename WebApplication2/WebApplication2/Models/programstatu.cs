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
    
    public partial class programstatu
    {
        public programstatu()
        {
            this.programs = new HashSet<program>();
        }
    
        public int programstatusid { get; set; }
        public string value { get; set; }
    
        public virtual ICollection<program> programs { get; set; }
    }
}