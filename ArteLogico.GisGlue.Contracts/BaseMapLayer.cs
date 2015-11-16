namespace ArteLogico.GisGlue.Contracts
{
    /// <summary>
    /// A layer that provides geographic context to the map.
    /// http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/baseMapLayer/02qt00000003000000/
    /// </summary>
    public class BaseMapLayer
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the basemap layer appears
        /// on top of all operational layers (true) or beneath all operational
        /// layers (false).
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is reference; otherwise, <c>false</c>.
        /// </value>
        public bool IsReference { get; set; }

        /// <summary>
        /// Gets or sets the degree of opacity applied to the layer, where 0 is
        /// full transparency and 1 is no transparency.
        /// </summary>
        /// <value>
        /// The opacity.
        /// </value>
        public int Opacity { get; set; }

        /// <summary>
        /// Gets or sets the type. When this property is included, the url
        /// property is not required. Acceptable values include: OpenStreetMap
        /// | BingMapsAerial | BingMapsRoad | BingMapsHybrid.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the URL to the layer.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the layer is initially
        /// visible in the web map.
        /// </summary>
        /// <value>
        ///   <c>true</c> if visibility; otherwise, <c>false</c>.
        /// </value>
        public bool Visibility { get; set; }
    }
}