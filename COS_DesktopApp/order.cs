//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COS_DesktopApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            this.order_details = new HashSet<order_details>();
        }
    
        public int id { get; set; }
        public int id_user { get; set; }
        public decimal totalprice { get; set; }
        public System.DateTime createdAt { get; set; }
        public Nullable<System.DateTime> deletedAt { get; set; }
    
        public virtual account account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_details> order_details { get; set; }
    }
}
