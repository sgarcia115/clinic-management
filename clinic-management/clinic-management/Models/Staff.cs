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
    using System.ComponentModel;
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.MedCheckHeaders = new HashSet<MedCheck>();
        }
        [DisplayName("Staff ID")]
        public string StaffID { get; set; }
        [DisplayName("Staff Lastname")]
        public string StaffLast { get; set; }
        [DisplayName("Staff Firstname")]
        public string StaffFirst { get; set; }
        [DisplayName("Staff Middle Name")]
        public string StaffMid { get; set; }
        [DisplayName("Staff Gender")]
        public string StaffGender { get; set; }
        [DisplayName("Staff Password")]
        public string StaffPassword { get; set; }
        [DisplayName("Staff Joined Date")]
        public Nullable<System.DateTime> StaffJoinedDate { get; set; }
        [DisplayName("Staff User Tye")]
        public Nullable<int> UserTypeID { get; set; }
        [DisplayName("Staff Is Deleted")]
        public string deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedCheck> MedCheckHeaders { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
