using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteLogico.GisGlue.Contracts
{
    public class BookmarkExtent
    {
        /// <summary>
        /// Gets or sets the spatial reference.
        /// </summary>
        /// <value>
        /// The spatial reference.
        /// </value>
        public SpatialReference SpatialReference { get; set; }

        /// <summary>
        /// Gets or sets the xmax.
        /// </summary>
        /// <value>
        /// The xmax.
        /// </value>
        public double Xmax { get; set; }

        /// <summary>
        /// Gets or sets the xmin.
        /// </summary>
        /// <value>
        /// The xmin.
        /// </value>
        public double Xmin { get; set; }

        /// <summary>
        /// Gets or sets the ymax.
        /// </summary>
        /// <value>
        /// The ymax.
        /// </value>
        public double Ymax { get; set; }

        /// <summary>
        /// Gets or sets the ymin.
        /// </summary>
        /// <value>
        /// The ymin.
        /// </value>
        public double Ymin { get; set; }
    }
}