//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OduncKitapAspnetMVCWebSolution_BLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yazarlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yazarlar()
        {
            this.Kitaplar = new HashSet<Kitaplar>();
        }
    
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public bool SilindiMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitaplar> Kitaplar { get; set; }
    }
}
