//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSD_Project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MsFlowerType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MsFlowerType()
        {
            this.MsFlowers = new HashSet<MsFlower>();
        }
    
        public int FlowerTypeID { get; set; }
        public string FlowerTypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MsFlower> MsFlowers { get; set; }
    }
}
