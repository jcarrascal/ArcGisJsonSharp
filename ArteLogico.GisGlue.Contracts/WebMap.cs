using System.Collections.Generic;

namespace ArteLogico.GisGlue.Contracts
{
    /// <summary>
    /// A Web Map is a JSON representation of the information required to display a map.
    /// http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html
    /// </summary>
    public class WebMap
    {
        public List<OperationalLayer> OperationalLayers { get; private set; } = new List<OperationalLayer>();

        public BaseMap BaseMap { get; set; }

        public string Version { get; set; } = "1.6";
    }
}