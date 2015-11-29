using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteLogico.GisGlue.Contracts
{
    public class Color
    {
        /// <summary>
        /// Gets or sets the Alpha channel. A value of 255 means full
        /// transparency while a value of 0 means full opacity.
        /// </summary>
        /// <value>
        /// The alpha channel.
        /// </value>
        public byte A { get; set; }

        /// <summary>
        /// Gets or sets the Blue component from 0 to 255.
        /// </summary>
        /// <value>
        /// The blue component.
        /// </value>
        public byte B { get; set; }

        /// <summary>
        /// Gets or sets the Green component from 0 to 255.
        /// </summary>
        /// <value>
        /// The green component.
        /// </value>
        public byte G { get; set; }

        /// <summary>
        /// Gets or sets the Red component from 0 to 255.
        /// </summary>
        /// <value>
        /// The red value.
        /// </value>
        public byte R { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string state = string.Format(" [{0}, {1}, {2}, {3}]", this.R, this.G, this.B, this.A);
            return base.ToString() + state;
        }
    }
}