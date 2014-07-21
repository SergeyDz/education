using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD.Asp.Net.Samples.Models
{
    public class FileLine
    {
        public int LineNumber { get; set; }
        public string Text { get; set; }
        public int Length 
        { 
            get {
                if (!string.IsNullOrEmpty(Text))
                    return Text.Length;
                return 0;
            } 
        }   
    }
}