//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COS_WebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_details
    {
        public int id_order { get; set; }
        public int id_products { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public System.DateTime createdAt { get; set; }
        public Nullable<System.DateTime> deletedAt { get; set; }
    
        public virtual order order { get; set; }
        public virtual product product { get; set; }
    }
}
