//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Strzelnica
{
    using System;
    using System.Collections.Generic;
    
    public partial class AMUNICJA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AMUNICJA()
        {
            this.BRONIE = new HashSet<BRONIE>();
        }
    
        public int ID { get; set; }
        public string KALIBER { get; set; }
        public int ILOSC_W_PAKIECIE { get; set; }
        public decimal CENA_PAKIETU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BRONIE> BRONIE { get; set; }
    }
}
