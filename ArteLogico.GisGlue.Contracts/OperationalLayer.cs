using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteLogico.GisGlue.Contracts
{
    /// <summary>
    /// Operational layers contain business data.
    /// http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/operationalLayer/02qt00000006000000/
    /// </summary>
    public class OperationalLayer
    {
        /// <summary>
        /// Gets or sets the URL of the layer.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the layer.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="OperationalLayer"/> is initially visibile.
        /// </summary>
        /// <value>
        ///   <c>true</c> if visible; otherwise, <c>false</c>.
        /// </value>
        public bool Visibility { get; set; }

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

        // TODO: Finish
    }
}
