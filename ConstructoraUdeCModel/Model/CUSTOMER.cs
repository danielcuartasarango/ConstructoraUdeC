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
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.FINANCIAL_INFORMATION = new HashSet<FINANCIAL_INFORMATION>();
            this.REQUEST = new HashSet<REQUEST>();
        }
    
        public int ID { get; set; }
        public string DOCUMENT { get; set; }
        public string NAME { get; set; }
        public string LASTNAME { get; set; }
        public System.DateTime BIRTHDATE { get; set; }
        public string PHOTO { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
    
        public virtual CITY CITY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINANCIAL_INFORMATION> FINANCIAL_INFORMATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUEST> REQUEST { get; set; }
    }
}
