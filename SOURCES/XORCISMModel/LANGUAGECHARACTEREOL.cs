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
    
    public partial class LANGUAGECHARACTEREOL
    {
        public int LanguageCharacterEOLID { get; set; }
        public int LanguageID { get; set; }
        public int CharacterID { get; set; }
        public Nullable<int> ordinal_position { get; set; }
    
        public virtual CHARACTER CHARACTER { get; set; }
        public virtual LANGUAGE LANGUAGE { get; set; }
    }
}
