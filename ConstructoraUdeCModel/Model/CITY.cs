//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConstructoraUdeCModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CITY()
        {
            this.CUSTOMER = new HashSet<CUSTOMER>();
            this.PROJECT = new HashSet<PROJECT>();
            this.SEC_USER = new HashSet<SEC_USER>();
        }
    
        public int ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public int COUNTRY { get; set; }
    
        public virtual COUNTRY COUNTRY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER> CUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECT> PROJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEC_USER> SEC_USER { get; set; }
    }
}
