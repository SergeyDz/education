using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SD.Asp.Net.Samples.Models
{
    public partial class FileContainer
    {
        public void ReadLine()
        {
            var lines =  _fileContentProvider.ReadLine();
            ProcessLines(lines);
        }

        public async Task ReadLineAsync()
        {
            var lines = await _fileContentProvider.ReadLineAsync();
            ProcessLines(lines);
        }

        public void Read()
        {
            var lines = _fileContentProvider.Read();
            ProcessLines(lines);
        }

        public async Task ReadAsync()
        {
            var lines = await _fileContentProvider.ReadAsync();
            ProcessLines(lines);
        }

        private void ProcessLines(List<string> lines)
        {
            int i = 0;

            foreach (var line in lines)
            {
                Lines.Add(new FileLine()
                {
                    Text = line,
                    LineNumber = i
                });

                i++;
            }
        }
    }
}