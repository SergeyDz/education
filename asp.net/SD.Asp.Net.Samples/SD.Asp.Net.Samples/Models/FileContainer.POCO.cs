using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD.Asp.Net.Samples.Models
{
    public partial class FileContainer
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<FileLine> Lines { get; private set; }

        public int LeneCount 
        {
            get {
                if (Lines != null && Lines.Count > 0)
                    return Lines.Count;
                return 0;
            }
        }


    }
}