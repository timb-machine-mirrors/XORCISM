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
    
    public partial class SECURITYPROGRAMPROJECT
    {
        public int SecurityProgramProjectID { get; set; }
        public Nullable<int> SecurityProgramID { get; set; }
        public string SecurityProgramGUID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string ProjectGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        public virtual PROJECT PROJECT { get; set; }
        public virtual SECURITYPROGRAM SECURITYPROGRAM { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}