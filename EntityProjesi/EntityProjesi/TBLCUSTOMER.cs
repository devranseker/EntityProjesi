//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjesi
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLCUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCUSTOMER()
        {
            this.TBLSALES = new HashSet<TBLSALES>();
        }
    
        public int CUSTOMERID { get; set; }
        public string CUSTOMERNAME { get; set; }
        public string CUSTOMERSURNAME { get; set; }
        public string CITY { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSALES> TBLSALES { get; set; }
    }
}
