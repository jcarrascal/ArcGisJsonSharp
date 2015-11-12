using System.Collections.Generic;

namespace ArteLogico.ArcGisJsonSharp.Contracts
{
    /// <summary>
    /// A BaseMap provides the geographic context of a web map.
    /// http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/baseMap/02qt00000004000000/
    /// </summary>
    public class BaseMap
    {
        /// <summary>
        /// Gets or sets the base map layers.
        /// </summary>
        /// <value>
        /// The base map layers.
        /// </value>
        public List<BaseMapLayer> BaseMapLayers { get; set; }

        /// <summary>
        /// Gets or sets the title that can be used in a table of contents.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
    }
}