//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mysoap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeliveryPoints
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MapsUrl { get; set; }
        public string LocationAddress { get; set; }
        public string StartHours { get; set; }
        public string EndHours { get; set; }
        public byte DeliverySunday { get; set; }
        public byte DeliveryMonday { get; set; }
        public byte DeliveryTuesday { get; set; }
        public byte DeliveryWednesday { get; set; }
        public byte DeliveryThursday { get; set; }
        public byte DeliveryFriday { get; set; }
        public byte DeliverySaturday { get; set; }
    }
}