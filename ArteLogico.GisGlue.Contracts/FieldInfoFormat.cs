using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteLogico.GisGlue.Contracts
{
    public class FieldInfoFormat
    {
        /// <summary>
        /// Gets or sets a value indicating whether [digit separator].
        /// </summary>
        /// <value><c>true</c> if [digit separator]; otherwise, <c>false</c>.</value>
        public bool DigitSeparator { get; set; }

        /// <summary>
        /// Gets or sets the places.
        /// </summary>
        /// <value>The places.</value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Places { get; set; }
    }
}
