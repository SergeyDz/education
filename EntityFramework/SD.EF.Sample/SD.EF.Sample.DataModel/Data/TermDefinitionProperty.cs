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
    
    public partial class TermDefinitionProperty
    {
        public TermDefinitionProperty()
        {
            this.TermPropertyValues = new HashSet<TermPropertyValue>();
        }
    
        public int Id { get; set; }
        public int Definition_Id { get; set; }
        public int Type_Id { get; set; }
        public string Name { get; set; }
        public int ImportanceLevel { get; set; }
    
        public virtual TermDefinition TermDefinition { get; set; }
        public virtual TermDefinitionPropertyImportanceLevel TermDefinitionPropertyImportanceLevel { get; set; }
        public virtual TermDefinitionPropertyType TermDefinitionPropertyType { get; set; }
        public virtual ICollection<TermPropertyValue> TermPropertyValues { get; set; }
    }
}