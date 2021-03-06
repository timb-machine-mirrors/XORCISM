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
    
    public partial class EVENTSIGNATURE
    {
        public int EventSignatureID { get; set; }
        public string EventSignatureGUID { get; set; }
        public int EventID { get; set; }
        public string EventGUID { get; set; }
        public int SignatureID { get; set; }
        public string SignatureGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> total_packets_collected { get; set; }
        public Nullable<int> total_bytes_collected { get; set; }
        public string data_flow_direction { get; set; }
        public Nullable<System.DateTimeOffset> connection_start_datetime { get; set; }
        public Nullable<System.DateTimeOffset> connection_end_datetime { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual COLLECTIONMETHOD COLLECTIONMETHOD { get; set; }
        public virtual EVENT EVENT { get; set; }
        public virtual SIGNATURE SIGNATURE { get; set; }
    }
}
