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
    
    public partial class SUBJECTPUBLICKEY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBJECTPUBLICKEY()
        {
            this.X509CERTIFICATE = new HashSet<X509CERTIFICATE>();
        }
    
        public int SubjectPublicKeyID { get; set; }
        public string Public_Key_Algorithm { get; set; }
        public Nullable<int> EncryptionID { get; set; }
        public int RSA_Public_Key { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual ENCRYPTION ENCRYPTION { get; set; }
        public virtual RSAPUBLICKEY RSAPUBLICKEY { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<X509CERTIFICATE> X509CERTIFICATE { get; set; }
    }
}