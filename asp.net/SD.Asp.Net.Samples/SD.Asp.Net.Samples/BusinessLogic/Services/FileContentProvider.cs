using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SD.Asp.Net.Samples.BusinessLogic.Services
{
    public class FileContentProvider
    {
        private string _path = string.Empty;

        public FileContentProvider(string path)
        {
            _path =  path;
        }

        public List<string> ReadLine()
        {
            List<string> result = new List<string>();
            using (StreamReader reader = new StreamReader(_path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    result.Add(line);
                }
            }

            return result;
        }

        public async Task<List<string>> ReadLineAsync()
        {
            List<string> result = new List<string>();
            using (StreamReader reader = new StreamReader(_path))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    result.Add(line);
                }
            }

            return result;
        }

        public List<string> Read()
        {
            using (StreamReader reader = new StreamReader(_path))
            {
                return reader.ReadToEnd().Split('\n').ToList();
            }
        }

        public async Task<List<string>> ReadAsync()
        {
            string content;
            using (StreamReader reader = new StreamReader(_path))
            {
                content = await reader.ReadToEndAsync();            
            }

            return content.Split('\n').ToList();
        }
    }
}