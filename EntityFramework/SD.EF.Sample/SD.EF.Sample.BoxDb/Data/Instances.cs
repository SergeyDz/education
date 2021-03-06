//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SD.EF.Sample.BoxDb.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instances
    {
        public System.Guid InstanceId { get; set; }
        public Nullable<System.DateTime> PendingTimer { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
        public Nullable<long> ServiceDeploymentId { get; set; }
        public string SuspensionExceptionName { get; set; }
        public string SuspensionReason { get; set; }
        public string ActiveBookmarks { get; set; }
        public string CurrentMachine { get; set; }
        public string LastMachine { get; set; }
        public string ExecutionStatus { get; set; }
        public Nullable<bool> IsInitialized { get; set; }
        public Nullable<bool> IsSuspended { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public Nullable<byte> EncodingOption { get; set; }
        public byte[] ReadWritePrimitiveDataProperties { get; set; }
        public byte[] WriteOnlyPrimitiveDataProperties { get; set; }
        public byte[] ReadWriteComplexDataProperties { get; set; }
        public byte[] WriteOnlyComplexDataProperties { get; set; }
    }
}
