//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalNetwork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int invoice_id { get; set; }
        public string uid { get; set; }
        public int traffic { get; set; }
        public decimal amount { get; set; }
        public System.DateTime payment_date { get; set; }
        public string status { get; set; }
    
        public virtual User User { get; set; }
    }
}
