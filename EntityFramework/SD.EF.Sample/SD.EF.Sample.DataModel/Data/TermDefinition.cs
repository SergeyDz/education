//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SD.EF.Sample.DataModel.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TermDefinition
    {
        public TermDefinition()
        {
            this.TermDefinitionProperties = new HashSet<TermDefinitionProperty>();
            this.Terms = new HashSet<Term>();
        }
    
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortForm { get; set; }
        public string LongForm { get; set; }
        public bool Required { get; set; }
        public bool Default { get; set; }
        public bool KeyTerm { get; set; }
    
        public virtual TermCategory TermCategory { get; set; }
        public virtual ICollection<TermDefinitionProperty> TermDefinitionProperties { get; set; }
        public virtual ICollection<Term> Terms { get; set; }
    }
}
