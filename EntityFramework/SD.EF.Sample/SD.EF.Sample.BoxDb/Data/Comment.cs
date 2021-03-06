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
    
    public partial class Comment
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RequestId { get; set; }
        public Nullable<int> CommentTypeId { get; set; }
        public string ActivityCode { get; set; }
        public string ActivityName { get; set; }
    
        public virtual Request1 Request1 { get; set; }
        public virtual CommentType2 CommentType2 { get; set; }
    }
}
