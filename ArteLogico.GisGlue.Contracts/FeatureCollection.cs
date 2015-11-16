using System.Collections.Generic;

namespace ArteLogico.GisGlue.Contracts
{
    public class FeatureCollection
    {
        /// <summary>
        /// Gets or sets the layers.
        /// </summary>
        /// <value>
        /// The layers.
        /// </value>
        public List<Layer> Layers { get; set; } = new List<Layer>();

        /// <summary>
        /// Gets or sets a value indicating whether to show the legend.
        /// </summary>
        /// <value>
        /// <c>true</c> if the legend should be shown; otherwise, <c>false</c>.
        /// </value>
        public bool ShowLegend { get; set; } = true;
    }
}