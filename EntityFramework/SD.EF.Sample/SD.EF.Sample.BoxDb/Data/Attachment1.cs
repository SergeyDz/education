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
    
    public partial class Attachment1
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int MimeTypeId { get; set; }
        public byte[] Content { get; set; }
        public int SizeBytes { get; set; }
        public int RequestId { get; set; }
        public int AttachmentTypeId { get; set; }
        public int IsDraft { get; set; }
        public string StateCode { get; set; }
    
        public virtual Dictionary Dictionary { get; set; }
        public virtual MimeType MimeType { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Request Request { get; set; }
    }
}
