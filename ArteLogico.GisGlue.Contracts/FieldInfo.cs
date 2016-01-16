using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteLogico.GisGlue.Contracts
{
    public class FieldInfo
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>The name of the field.</value>
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        /// <value>The format.</value>
        public FieldInfoFormat Format { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is editable.
        /// </summary>
        /// <value><c>true</c> if this instance is editable; otherwise, <c>false</c>.</value>
        [DefaultValue(true)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool IsEditable { get; set; } = true;

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the media infos.
        /// </summary>
        /// <value>The media infos.</value>
        public object[] MediaInfos { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show attachments].
        /// </summary>
        /// <value><c>true</c> if [show attachments]; otherwise, <c>false</c>.</value>
        public bool ShowAttachments { get; set; }

        /// <summary>
        /// Gets or sets the string field option.
        /// </summary>
        /// <value>The string field option.</value>
        public string StringFieldOption { get; set; }

        /// <summary>
        /// Gets or sets the tooltip.
        /// </summary>
        /// <value>The tooltip.</value>
        public string Tooltip { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldInfo"/> is visible.
        /// </summary>
        /// <value><c>true</c> if visible; otherwise, <c>false</c>.</value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Visible { get; set; }
    }
}
