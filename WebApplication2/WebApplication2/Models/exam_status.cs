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
    
    public partial class exam_status
    {
        public exam_status()
        {
            this.exams = new HashSet<exam>();
        }
    
        public int examstatusid { get; set; }
        public string status { get; set; }
        public System.DateTime createdate { get; set; }
        public System.DateTime modifieddate { get; set; }
    
        public virtual ICollection<exam> exams { get; set; }
    }
}
