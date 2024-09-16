using PSC.Maui.Components.LanguageDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Maui.Components.LanguageDropdown.Extensions
{
    /// <summary>
    /// Class GroupingExtensions.
    /// </summary>
    public static class GroupingExtensions
    {
        /// <summary>
        /// Converts to groups.
        /// </summary>
        /// <param name="languages">The languages.</param>
        /// <returns>List&lt;LanguageModelGroup&gt;.</returns>
        public static List<LanguageModelGroup> ToGroups(this List<LanguageModel> languages)
        {
            return languages.GroupBy(x => new { x.Parent.LanguageName, x.Parent.Flag })
                        .OrderBy(x => x.Key.LanguageName)
                        .Select(x => new LanguageModelGroup(
                            x.Key.LanguageName,
                            x.Key.Flag,
                            x.OrderBy(l => l.LanguageName).ToList()))
                        .ToList();
        }
    }
}