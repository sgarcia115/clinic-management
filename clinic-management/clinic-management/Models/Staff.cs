//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clinic_management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.MedCheckHeaders = new HashSet<MedCheck>();
        }
    
        public string StaffID { get; set; }
        public string StaffLast { get; set; }
        public string StaffFirst { get; set; }
        public string StaffMid { get; set; }
        public string StaffGender { get; set; }
        public string StaffPassword { get; set; }
        public string StaffJoinedDate { get; set; }
        public Nullable<int> UserTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedCheck> MedCheckHeaders { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
