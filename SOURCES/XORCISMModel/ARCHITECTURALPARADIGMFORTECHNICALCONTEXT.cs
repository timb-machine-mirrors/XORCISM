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
    
    public partial class ARCHITECTURALPARADIGMFORTECHNICALCONTEXT
    {
        public int TechnicalContextArchitecturalParadigmID { get; set; }
        public int ArchitecturalParadigmID { get; set; }
        public int TechnicalContextID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual ARCHITECTURALPARADIGM ARCHITECTURALPARADIGM { get; set; }
        public virtual TECHNICALCONTEXT TECHNICALCONTEXT { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
