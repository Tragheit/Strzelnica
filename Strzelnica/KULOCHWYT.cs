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
    
    public partial class KULOCHWYT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KULOCHWYT()
        {
            this.STANOWISKA = new HashSet<STANOWISKA>();
        }
    
        public int ID { get; set; }
        public string NAZWA { get; set; }
        public string MATERIAL { get; set; }
        public string POZYCJA { get; set; }
        public string MOBILNOSC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STANOWISKA> STANOWISKA { get; set; }
    }
}