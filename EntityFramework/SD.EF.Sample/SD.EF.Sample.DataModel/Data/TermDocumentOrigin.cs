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
    
    public partial class TermDocumentOrigin
    {
        public TermDocumentOrigin()
        {
            this.TermDocumentTypes = new HashSet<TermDocumentType>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<TermDocumentType> TermDocumentTypes { get; set; }
    }
}
