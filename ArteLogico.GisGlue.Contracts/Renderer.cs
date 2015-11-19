using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteLogico.GisGlue.Contracts
{
    /// <summary>
    /// http://resources.arcgis.com/en/help/arcgis-rest-api/index.html#//02r30000019t000000
    /// </summary>
    public class Renderer
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the rotation expression.
        /// </summary>
        /// <value>
        /// The rotation expression.
        /// </value>
        public string RotationExpression { get; set; }

        /// <summary>
        /// Gets or sets the type of the rotation.
        /// </summary>
        /// <value>
        /// The type of the rotation.
        /// </value>
        public RotationType RotationType { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public Symbol Symbol { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }
    }
}