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
    
    public partial class key2
    {
        public key2()
        {
            this.examitems = new HashSet<examitem>();
        }
    
        public int key2id { get; set; }
        public Nullable<int> exk2ID { get; set; }
        public string Dodareatitle { get; set; }
        public string dodobjectivenumvalue { get; set; }
    
        public virtual ICollection<examitem> examitems { get; set; }
        public virtual ExK2 ExK2 { get; set; }
    }
}