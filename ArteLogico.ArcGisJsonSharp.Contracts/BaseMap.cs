using System.Collections.Generic;

namespace ArteLogico.ArcGisJsonSharp.Contracts
{
    public class BaseMap
    {
        public List<BaseMapLayer> BaseMapLayers { get; set; }

        public string Title { get; set; }
    }
}