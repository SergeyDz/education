using SD.Asp.Net.Samples.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD.Asp.Net.Samples.Models
{
    public partial class FileContainer
    {
        private readonly FileContentProvider _fileContentProvider = null;

        protected FileContainer(string path)
        {
            this.Lines = new List<FileLine>();
            this.Path = path;
            _fileContentProvider = new FileContentProvider(this.Path);
        }

        public static FileContainer Create(string path)
        {
            return new FileContainer(path);
        }
    }
}