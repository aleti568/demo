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
    
    public partial class Person
    {
        public Person()
        {
            this.CurriculumPeoples = new HashSet<CurriculumPeople>();
            this.institutionpeoples = new HashSet<institutionpeople>();
            this.svtables = new HashSet<svtable>();
            this.takers = new HashSet<taker>();
        }
    
        public int personid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string st { get; set; }
        public string zip { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public System.DateTime dob { get; set; }
        public string phonenumber1 { get; set; }
        public string phonenumber1type { get; set; }
        public string phonenumber2 { get; set; }
        public string phonenumber2type { get; set; }
        public string email { get; set; }
        public bool isTaker { get; set; }
        public bool isInstitution { get; set; }
        public bool isSA { get; set; }
        public bool isDeleted { get; set; }
        public bool isCurriculum { get; set; }
        public bool isEmployee { get; set; }
    
        public virtual ICollection<CurriculumPeople> CurriculumPeoples { get; set; }
        public virtual ICollection<institutionpeople> institutionpeoples { get; set; }
        public virtual ICollection<svtable> svtables { get; set; }
        public virtual ICollection<taker> takers { get; set; }
    }
}