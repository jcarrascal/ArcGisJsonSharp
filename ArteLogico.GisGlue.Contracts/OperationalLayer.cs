using System.Collections.Generic;

namespace ArteLogico.GisGlue.Contracts
{
    /// <summary>
    /// Operational layers contain business data.
    /// http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/operationalLayer/02qt00000006000000/
    /// </summary>
    public class OperationalLayer
    {
        /// <summary>
        /// Gets or sets a comma-separated list of allowed operations.
        /// </summary>
        /// <value>
        /// The capabilities.
        /// </value>
        public string Capabilities { get; set; }

        /// <summary>
        /// Gets or sets the character used to delimit columns in a CSV file.
        /// </summary>
        /// <value>
        /// The column delimiter.
        /// </value>
        public string ColumnDelimiter { get; set; }

        /// <summary>
        /// Gets or sets the copyright message.
        /// </summary>
        /// <value>
        /// The copyright.
        /// </value>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the extent.
        /// </summary>
        /// <value>
        /// The extent.
        /// </value>
        public float[][] Extent { get; set; }

        /// <summary>
        /// Gets or sets the image format to be requested to the WMS.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the layer.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>
        /// The item identifier.
        /// </value>
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the layer definition.
        /// </summary>
        /// <value>
        /// The layer definition.
        /// </value>
        public LayerDefinition LayerDefinition { get; set; }

        /// <summary>
        /// Gets or sets the layers.
        /// </summary>
        /// <value>
        /// The layers.
        /// </value>
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// Gets or sets the location information.
        /// </summary>
        /// <value>
        /// The location information.
        /// </value>
        public LocationInfo LocationInfo { get; set; }

        /// <summary>
        /// Gets or sets the map URL.
        /// </summary>
        /// <value>
        /// The map URL.
        /// </value>
        public string MapUrl { get; set; }

        /// <summary>
        /// Gets or sets the maximum height.
        /// </summary>
        /// <value>
        /// The maximum height.
        /// </value>
        public double MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets the maximum scale.
        /// </summary>
        /// <value>
        /// The maximum scale.
        /// </value>
        public int MaxScale { get; set; }

        /// <summary>
        /// Gets or sets the maximum width.
        /// </summary>
        /// <value>
        /// The maximum width.
        /// </value>
        public double MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets the minimum scale.
        /// </summary>
        /// <value>
        /// The minimum scale.
        /// </value>
        public int MinScale { get; set; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        public int Mode { get; set; }

        /// <summary>
        /// Gets or sets the opacity.
        /// </summary>
        /// <value>
        /// The opacity.
        /// </value>
        public float Opacity { get; set; }

        /// <summary>
        /// Gets or sets the popup information.
        /// </summary>
        /// <value>
        /// The popup information.
        /// </value>
        public PopupInfo PopupInfo { get; set; }

        /// <summary>
        /// Gets or sets the spatial references.
        /// </summary>
        /// <value>
        /// The spatial references.
        /// </value>
        public List<int> SpatialReferences { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the URL of the layer.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="OperationalLayer"/> is initially visibile.
        /// </summary>
        /// <value>
        ///   <c>true</c> if visible; otherwise, <c>false</c>.
        /// </value>
        public bool Visibility { get; set; }

        /// <summary>
        /// Gets or sets the visible layers.
        /// </summary>
        /// <value>
        /// The visible layers.
        /// </value>
        public List<string> VisibleLayers { get; set; }
    }
}