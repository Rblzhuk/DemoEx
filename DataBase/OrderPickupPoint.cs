//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaptchaInWpf.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderPickupPoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderPickupPoint()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public decimal PointIndex { get; set; }
        public string LocationName { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}