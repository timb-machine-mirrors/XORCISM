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
    
    public partial class PROJECTTASK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROJECTTASK()
        {
            this.PROJECTTASKFINDING = new HashSet<PROJECTTASKFINDING>();
            this.PROJECTTASKPERSON = new HashSet<PROJECTTASKPERSON>();
            this.TIMESHEET = new HashSet<TIMESHEET>();
        }
    
        public int ProjectTaskID { get; set; }
        public int ProjectID { get; set; }
        public string ProjectGUID { get; set; }
        public int TaskID { get; set; }
        public string TaskGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public string ProjectTaskName { get; set; }
        public string ProjectTaskDescription { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual PROJECT PROJECT { get; set; }
        public virtual TASK TASK { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECTTASKFINDING> PROJECTTASKFINDING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECTTASKPERSON> PROJECTTASKPERSON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIMESHEET> TIMESHEET { get; set; }
    }
}
