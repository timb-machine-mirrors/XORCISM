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
    
    public partial class CWEREFERENCE
    {
        public int CWEReferenceID { get; set; }
        public string CWEID { get; set; }
        public int ReferenceID { get; set; }
        public string Reference_Section { get; set; }
        public string LocalReferenceID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual CWE CWE { get; set; }
        public virtual REFERENCE REFERENCE { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
