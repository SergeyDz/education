using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Web.API.Samples.Mvc.Assemblies;

namespace Web.API.Samples.Mvc.Controllers
{
    public class ResourceController : AsyncController
    {
        public ActionResult GetJs(string fileName)
        {
            string path = Server.MapPath("~/bin");

            foreach (string dll in Directory.GetFiles(path, "*.dll"))
            {
                var assembly = Assembly.LoadFile(dll);
                if (assembly.GetCustomAttributes(typeof (ResourcePoolAttribute), false)
                        .Cast<ResourcePoolAttribute>().Count() > 0 && !string.IsNullOrEmpty(fileName))
                {
                    string resourcePath = string.Format("{1}.Resources.JS.{0}.js", fileName, assembly.GetName().Name);
                    var stream = assembly.GetManifestResourceStream(resourcePath);
                    if (stream != null)
                        return File(stream, "application/x-javascript");
                }
            }

            return HttpNotFound(fileName);
        }
    }
}
