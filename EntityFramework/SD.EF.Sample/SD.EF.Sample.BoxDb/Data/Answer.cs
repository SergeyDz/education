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
    
    public partial class Answer
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int RequestId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerOptionId { get; set; }
        public string AnswerText { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual AnswerOption AnswerOption { get; set; }
        public virtual Question Question { get; set; }
        public virtual Request Request { get; set; }
    }
}