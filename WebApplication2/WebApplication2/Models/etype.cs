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
    
    public partial class etype
    {
        public etype()
        {
            this.exams = new HashSet<exam>();
        }
    
        public int etypeid { get; set; }
        public string description { get; set; }
        public Nullable<int> exk1ID { get; set; }
        public Nullable<int> exk2ID { get; set; }
        public Nullable<int> exk3ID { get; set; }
    
        public virtual ICollection<exam> exams { get; set; }
        public virtual ExK1 ExK1 { get; set; }
        public virtual ExK2 ExK2 { get; set; }
        public virtual ExK3 ExK3 { get; set; }
    }
}
