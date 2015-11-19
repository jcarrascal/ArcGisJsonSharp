using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteLogico.GisGlue.Contracts
{
    public class Bookmark
    {
        /// <summary>
        /// Gets or sets the extent.
        /// </summary>
        /// <value>
        /// The extent.
        /// </value>
        public BookmarkExtent Extent { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}