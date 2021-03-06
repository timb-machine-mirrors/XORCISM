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
    
    public partial class FUNCTIONREFERENCE
    {
        public int FunctionReferenceID { get; set; }
        public int FunctionID { get; set; }
        public int ReferenceID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public string FunctionReferenceDescription { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual FUNCTION FUNCTION { get; set; }
        public virtual REFERENCE REFERENCE { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
