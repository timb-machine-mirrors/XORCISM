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
    
    public partial class SCRIPT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCRIPT()
        {
            this.CODE = new HashSet<CODE>();
            this.SCRIPTDESCRIPTION1 = new HashSet<SCRIPTDESCRIPTION>();
            this.SCRIPTVERSION = new HashSet<SCRIPTVERSION>();
            this.BUILDINFORMATION = new HashSet<BUILDINFORMATION>();
        }
    
        public int ScriptID { get; set; }
        public int CommandsID { get; set; }
        public int CommandID { get; set; }
        public string CommandArgumentValue { get; set; }
        public string ScriptName { get; set; }
        public string ScriptDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CODE> CODE { get; set; }
        public virtual COMMAND COMMAND { get; set; }
        public virtual COMMANDS COMMANDS { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCRIPTDESCRIPTION> SCRIPTDESCRIPTION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCRIPTVERSION> SCRIPTVERSION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUILDINFORMATION> BUILDINFORMATION { get; set; }
    }
}
