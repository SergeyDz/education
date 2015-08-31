using SD.Asp.Net.Samples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SD.Asp.Net.Samples.Controllers
{
    public class SampleAPIController : ApiController
    {
        private static readonly string _testFilePath;

        public static string GetBasePath()
        {
            if (System.Web.HttpContext.Current == null) return AppDomain.CurrentDomain.BaseDirectory;
            else return AppDomain.CurrentDomain.BaseDirectory;
        }

        static SampleAPIController()
        {
            _testFilePath = GetBasePath() + @"/Content/Uells_Voyna_mirov.fb2";  
            FileContainer file = FileContainer.Create(_testFilePath);
            file.Read();
            HttpRuntime.Cache.Insert("ProbeFileText", file.Lines.Select(p => p.Text).ToList<string>());
        }
        // GET api/sampleapi
        public IEnumerable<string> Get()
        {
            return HttpRuntime.Cache["ProbeFileText"] as IEnumerable<string>;
        }

        // GET api/sampleapi/5
        public string Get(int id)
        {
            return (HttpRuntime.Cache["ProbeFileText"] as List<string>)[id];
        }

        // POST api/sampleapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/sampleapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/sampleapi/5
        public void Delete(int id)
        {
        }
    }
}
