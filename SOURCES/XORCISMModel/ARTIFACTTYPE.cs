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
    
    public partial class ARTIFACTTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTIFACTTYPE()
        {
            this.ARTIFACT = new HashSet<ARTIFACT>();
        }
    
        public int ArtifactTypeID { get; set; }
        public string ArtifactTypeGUID { get; set; }
        public string ArtifactTypeName { get; set; }
        public string ArtifactTypeDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> ImportanceID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTIFACT> ARTIFACT { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual IMPORTANCE IMPORTANCE { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
