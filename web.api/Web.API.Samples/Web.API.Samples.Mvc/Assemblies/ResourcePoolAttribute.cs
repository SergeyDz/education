using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.API.Samples.Mvc.Assemblies
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class ResourcePoolAttribute : Attribute
    {
    }
}
