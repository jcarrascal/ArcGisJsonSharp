namespace ArteLogico.GisGlue.Contracts
{
    public class LayerDefinition
    {
        /// <summary>
        /// Gets or sets the drawing information.
        /// </summary>
        /// <value>
        /// The drawing information.
        /// </value>
        public DrawingInfo DrawingInfo { get; set; }

        /// <summary>
        /// Gets or sets the maximum scale.
        /// </summary>
        /// <value>
        /// The maximum scale.
        /// </value>
        public long MaxScale { get; set; }

        /// <summary>
        /// Gets or sets the minimum scale.
        /// </summary>
        /// <value>
        /// The minimum scale.
        /// </value>
        public long MinScale { get; set; }
    }
}