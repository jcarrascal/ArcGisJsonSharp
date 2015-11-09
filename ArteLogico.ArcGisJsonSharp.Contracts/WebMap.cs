using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteLogico.ArcGisJsonSharp.Contracts
{
    public class WebMap
    {
        public List<object> OperationalLayers { get; private set; } = new List<object>();

        public BaseMap BaseMap { get; set; }

        public string Version { get; set; } = "1.6";
    }
}
