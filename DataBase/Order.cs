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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderProduct = new HashSet<OrderProduct>();
        }
    
        public int Id { get; set; }
        public int OrderStatusId { get; set; }
        public System.DateTime OrderData { get; set; }
        public System.DateTime OrderDeliveryDate { get; set; }
        public int PickupPointId { get; set; }
        public string OrderCode { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual OrderPickupPoint OrderPickupPoint { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}