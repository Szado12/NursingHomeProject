//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NursingHomeApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int EmployeeId { get; set; }
        public int TreatmentId { get; set; }
        public int PlaceId { get; set; }
        public System.DateTime Term { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Place Place { get; set; }
        public virtual Treatment Treatment { get; set; }
    }
}
