//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityexc2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public string OrderNo { get; set; }
        public string ClientNo { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string DelyAddr { get; set; }
        public string SalesManNo { get; set; }
        public string DelyType { get; set; }
        public string BilledYn { get; set; }
        public Nullable<System.DateTime> DelyDate { get; set; }
        public string OrderStatus { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
