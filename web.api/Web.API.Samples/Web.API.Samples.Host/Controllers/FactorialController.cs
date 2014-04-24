using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.API.Samples.Host.Models;

namespace Web.API.Samples.Host.Controllers
{
    public class FactorialController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public FactorialResult Get(int id)
        {
            FactorialResult result = new FactorialResult();

            Stopwatch watch = new Stopwatch();
            result.StartTime = DateTime.UtcNow;
            result.N = id;
            watch.Start();

            float fact = 1;

            if (id > 1)
            {
                for (int k = 2; k <= id; k++)
                {
                    fact = fact*k;
                }
            }

            result.EndTime = DateTime.UtcNow;
            watch.Stop();
            result.Elapsed = watch.ElapsedMilliseconds;
            result.F = fact;

            return result;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}