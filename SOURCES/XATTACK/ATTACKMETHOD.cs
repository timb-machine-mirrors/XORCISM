//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XATTACKModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ATTACKMETHOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATTACKMETHOD()
        {
            this.ATTACKMETHODFORATTACKPATTERN = new HashSet<ATTACKMETHODFORATTACKPATTERN>();
            this.ATTACKMETHODREFERENCE = new HashSet<ATTACKMETHODREFERENCE>();
            this.ATTACKMETHODTAG = new HashSet<ATTACKMETHODTAG>();
        }
    
        public int AttackMethodID { get; set; }
        public string AttackMethodGUID { get; set; }
        public string AttackMethodTitle { get; set; }
        public string AttackMethodDescription { get; set; }
        public Nullable<int> SourceID { get; set; }
        public string SourceGUID { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public string VocabularyGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public string CreationObjectGUID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKMETHODFORATTACKPATTERN> ATTACKMETHODFORATTACKPATTERN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKMETHODREFERENCE> ATTACKMETHODREFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKMETHODTAG> ATTACKMETHODTAG { get; set; }
    }
}