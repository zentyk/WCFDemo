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
    
    public partial class Orders
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Products { get; set; }
        public int CantProducts { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public byte Delivered { get; set; }
        public int DeliveryLocation { get; set; }
        public byte Canceled { get; set; }
        public byte SucessPayment { get; set; }
        public byte Status { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
    }
}
