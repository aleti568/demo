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
    
    public partial class subskill
    {
        public int subskillid { get; set; }
        public int skillsid { get; set; }
        public string subskilltitle { get; set; }
        public string subskillcomb { get; set; }
        public string jobadwords { get; set; }
    
        public virtual skill skill { get; set; }
    }
}
