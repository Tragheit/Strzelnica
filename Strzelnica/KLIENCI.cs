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
    
    public partial class KLIENCI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KLIENCI()
        {
            this.WYPOZYCZENIA = new HashSet<WYPOZYCZENIA>();
        }
    
        public int ID { get; set; }
        public string IMIE { get; set; }
        public string NAZWISKO { get; set; }
        public Nullable<int> ID_KARNETU { get; set; }
        public int WIEK { get; set; }
    
        public virtual KARNETY KARNETY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WYPOZYCZENIA> WYPOZYCZENIA { get; set; }
    }
}
