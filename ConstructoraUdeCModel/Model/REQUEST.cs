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
    
    public partial class REQUEST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REQUEST()
        {
            this.PAYMENT = new HashSet<PAYMENT>();
        }
    
        public int ID { get; set; }
        public System.DateTime REQUEST_DATE { get; set; }
        public int OFFER { get; set; }
        public int CUSTOMER { get; set; }
        public string PROPERTY { get; set; }
        public int STATUSREQUEST { get; set; }
    
        public virtual CUSTOMER CUSTOMER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAYMENT> PAYMENT { get; set; }
        public virtual PROPERTY PROPERTY1 { get; set; }
        public virtual STATUSREQUEST STATUSREQUEST1 { get; set; }
    }
}
