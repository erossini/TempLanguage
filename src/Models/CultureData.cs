using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Maui.Components.LanguageDropdown.Models
{
    /// <summary>
    /// Class CultureData.
    /// </summary>
    public class CultureData
    {
        /// <summary>
        /// Gets or sets the name of the language.
        /// </summary>
        /// <value>The name of the language.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LanguageName")]
        public string? LanguageName { get; set; }

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>The parent.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Parent")]
        public CultureData? Parent { get; set; }

        /// <summary>
        /// Gets or sets the abbreviation.
        /// </summary>
        /// <value>The abbreviation.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Abbreviation")]
        public string? Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the flag.
        /// </summary>
        /// <value>The flag.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Flag")]
        public string? Flag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is supported.
        /// </summary>
        /// <value><c>null</c> if [is supported] contains no value, <c>true</c> if [is supported]; otherwise, <c>false</c>.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("IsSupported")]
        public bool? IsSupported { get; set; }
    }
}