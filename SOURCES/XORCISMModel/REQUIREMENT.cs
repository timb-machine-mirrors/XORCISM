//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class REQUIREMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REQUIREMENT()
        {
            this.ASSURANCEREQUIREMENT = new HashSet<ASSURANCEREQUIREMENT>();
            this.PERFORMANCEREQUIREMENT = new HashSet<PERFORMANCEREQUIREMENT>();
            this.REQUIREMENTCATEGORY = new HashSet<REQUIREMENTCATEGORY>();
            this.REQUIREMENTDESCRIPTION1 = new HashSet<REQUIREMENTDESCRIPTION>();
            this.REQUIREMENTMAPPING = new HashSet<REQUIREMENTMAPPING>();
            this.REQUIREMENTMAPPING1 = new HashSet<REQUIREMENTMAPPING>();
            this.SECURITYREQUIREMENT = new HashSet<SECURITYREQUIREMENT>();
        }
    
        public int RequirementID { get; set; }
        public string RequirementGUID { get; set; }
        public string RequirementTitle { get; set; }
        public string RequirementDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSURANCEREQUIREMENT> ASSURANCEREQUIREMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFORMANCEREQUIREMENT> PERFORMANCEREQUIREMENT { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUIREMENTCATEGORY> REQUIREMENTCATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUIREMENTDESCRIPTION> REQUIREMENTDESCRIPTION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUIREMENTMAPPING> REQUIREMENTMAPPING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUIREMENTMAPPING> REQUIREMENTMAPPING1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYREQUIREMENT> SECURITYREQUIREMENT { get; set; }
    }
}
