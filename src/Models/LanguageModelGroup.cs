using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Maui.Components.LanguageDropdown.Models
{
    /// <summary>
    /// Class LanguageModelGroup.
    /// Implements the <see cref="System.Collections.Generic.List{Models.LanguageModel}" />
    /// </summary>
    /// <seealso cref="System.Collections.Generic.List{Models.LanguageModel}" />
    public class LanguageModelGroup : List<LanguageModel>
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }
        /// <summary>
        /// Gets the flag.
        /// </summary>
        /// <value>The flag.</value>
        public string Flag { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageModelGroup"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="flag">The flag.</param>
        /// <param name="languages">The languages.</param>
        public LanguageModelGroup(string name, string flag, List<LanguageModel> languages) : base(languages)
        {
            Name = name;
            Flag = flag;
        }
    }
}