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
    
    public partial class VOCABULARYVERSION
    {
        public int VocabularyVersionID { get; set; }
        public string VocabularyVersionGUID { get; set; }
        public int VocabularyID { get; set; }
        public string VocabularyGUID { get; set; }
        public int VersionID { get; set; }
        public string ChangeLog { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual VERSION VERSION { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
