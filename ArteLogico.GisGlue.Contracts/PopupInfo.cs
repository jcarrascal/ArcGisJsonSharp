using Newtonsoft.Json;

namespace ArteLogico.GisGlue.Contracts
{
    public class PopupInfo
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the field infos.
        /// </summary>
        /// <value>The field infos.</value>
        public FieldInfo[] FieldInfos { get; set; }

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
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
    }
}
