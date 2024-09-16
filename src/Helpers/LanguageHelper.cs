using Microsoft.Maui.Platform;
using PSC.Maui.Components.LanguageDropdown.Extensions;
using PSC.Maui.Components.LanguageDropdown.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Maui.Components.LanguageDropdown.Helpers
{
    /// <summary>
    /// Class LanguageHelper. This class cannot be inherited.
    /// </summary>
    public sealed class LanguageHelper
    {
        private static readonly LanguageHelper _instance = new LanguageHelper();
        private CultureDataHelper cultureDataHelper = new CultureDataHelper();
        private List<LanguageModel>? _cultures;

        private readonly CultureCountryOverrides? CultureCountryOverrides = new CultureCountryOverrides();
        private const string DefaultOverrides = "en=en-US,zh=zh-CN,zh-CHT=zh-CN,zh-HANT=zh-CN,fy=fy,";

        private static readonly string[] _existingFlags =
        {
            "ad", "ae", "af", "ag", "ai", "al", "am", "an", "ao", "ar", "as", "at", "au", "aw", "ax", "az", "ba", "bb", "bd", "be", "bf",
            "bg", "bh", "bi", "bj", "bm", "bn", "bo", "br", "bs", "bt", "bv", "bw", "by", "bz", "ca", "cc", "cd", "cf", "cg", "ch", "ci",
            "ck", "cl", "cm", "cn", "co", "cr", "cs", "cu", "cv", "cx", "cy", "cz", "de", "dj", "dk", "dm", "do", "dz", "ec", "ee", "eg",
            "eh", "er", "es", "et", "fi", "fj", "fk", "fm", "fo", "fr", "fy", "ga", "gb", "gd", "ge", "gf", "gh", "gi", "gl", "gm",
            "gn", "gp", "gq", "gr", "gs", "gt", "gu", "gw", "gy", "hk", "hm", "hn", "hr", "ht", "hu", "id", "ie", "il", "in", "io", "iq",
            "ir", "is", "it", "jm", "jo", "jp", "ke", "kg", "kh", "ki", "km", "kn", "kp", "kr", "kw", "ky", "kz", "la", "lb", "lc", "li",
            "lk", "lr", "ls", "lt", "lu", "lv", "ly", "ma", "mc", "md", "me", "mg", "mh", "mk", "ml", "mm", "mn", "mo", "mp", "mq", "mr",
            "ms", "mt", "mu", "mv", "mw", "mx", "my", "mz", "na", "nc", "ne", "nf", "ng", "ni", "nl", "no", "np", "nr", "nu", "nz", "om",
            "pa", "pe", "pf", "pg", "ph", "pk", "pl", "pm", "pn", "pr", "ps", "pt", "pw", "py", "qa", "re", "ro", "rs", "ru", "rw", "sa",
            "sb", "sc", "sd", "se", "sg", "sh", "si", "sj", "sk", "sl", "sm", "sn", "so", "sr", "st", "sv", "sy", "sz", "tc", "td", "tf",
            "tg", "th", "tj", "tk", "tl", "tm", "tn", "to", "tr", "tt", "tv", "tw", "tz", "ua", "ug", "um", "us", "uy", "uz", "va", "vc",
            "ve", "vg", "vi", "vn", "vu", "wf", "ws", "ye", "yt", "za", "zm", "zw"
        };

        /// <summary>
        /// Prevents a default instance of the <see cref="LanguageHelper"/> class from being created.
        /// </summary>
        private LanguageHelper()
        {
        }

        /// <summary>
        /// Initializes static members of the <see cref="LanguageHelper"/> class.
        /// </summary>
        static LanguageHelper()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static LanguageHelper Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Gets the name of the culture.
        /// </summary>
        /// <param name="IetfLanguageTag">The ietf language tag.</param>
        /// <param name="displayName">The display name.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetCultureName(string IetfLanguageTag, string displayName)
        {
            if (DeviceInfo.Platform != DevicePlatform.iOS && DeviceInfo.Platform != DevicePlatform.macOS && DeviceInfo.Platform != DevicePlatform.MacCatalyst)
                return displayName;

            return cultureDataHelper.GetCultureName(IetfLanguageTag);
        }

        /// <summary>
        /// Gets the flag by abbreviation.
        /// </summary>
        /// <param name="abbreviation">The abbreviation.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetFlagByAbbreviation(string abbreviation)
        {
            return _cultures?.Where(c => c.Abbreviation.ToLower().Equals(abbreviation.ToLower()))?.FirstOrDefault()?.Flag;
        }

        /// <summary>
        /// Gets the language name by abbreviation.
        /// </summary>
        /// <param name="abbreviation">The abbreviation.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetLanguageNameByAbbreviation(string abbreviation)
        {
            return _cultures?.Where(c => c.Abbreviation.ToLower().Equals(abbreviation.ToLower()))?.FirstOrDefault()?.LanguageName;
        }

        /// <summary>
        /// Sets the cultures.
        /// </summary>
        public void SetCultures()
        {
            _cultures = new List<LanguageModel>();

            var _availableCultures = CultureInfo.GetCultures(CultureTypes.AllCultures)
                        .Where(culture => !CultureInfo.InvariantCulture.Equals(culture))
                        .OrderBy(culture => culture.DisplayName)
                        .ToArray();

            foreach (var culture in _availableCultures)
            {
                if (string.IsNullOrEmpty(culture.Name))
                    continue;

                LanguageModel item = new()
                {
                    Abbreviation = culture.IetfLanguageTag,
                    LanguageName = GetCultureName(culture.IetfLanguageTag, culture.DisplayName),
                    Flag = $"f_{GetFlag(culture)}.png",
                };

                if (culture.Parent != null && !string.IsNullOrEmpty(culture.Parent.IetfLanguageTag))
                    item.Parent = new LanguageModel()
                    {
                        Abbreviation = culture.Parent.IetfLanguageTag,
                        LanguageName = GetCultureName(culture.Parent.IetfLanguageTag, culture.Parent.DisplayName),
                        Flag = $"f_{GetFlag(culture.Parent)}.png"
                    };
                else
                    item.Parent = new LanguageModel()
                    {
                        Abbreviation = item.Abbreviation,
                        LanguageName = item.LanguageName,
                        Flag = item.Flag
                    };

                _cultures.Add(item);
            }
        }

        /// <summary>
        /// Gets the language available.
        /// </summary>
        /// <returns>List&lt;LanguageModel&gt;.</returns>
        public List<LanguageModel> GetLanguageAvailable()
        {
            if (_cultures == null)
                SetCultures();

            return _cultures;
        }

        /// <summary>
        /// Gets the flag.
        /// </summary>
        /// <param name="culture">The culture.</param>
        /// <returns>System.String.</returns>
        public string GetFlag(CultureInfo culture)
        {
            return ConvertCultureIntoAbbreviation(culture, 0);
        }

        /// <summary>
        /// Converts the culture into abbreviation.
        /// </summary>
        /// <param name="culture">The culture.</param>
        /// <param name="recursionCounter">The recursion counter.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        private string? ConvertCultureIntoAbbreviation(CultureInfo culture, int recursionCounter = 0)
        {
            var cultureName = culture.Name;

            var countryOverride = CultureCountryOverrides[culture];
            if (countryOverride != null)
            {
                culture = countryOverride;
                cultureName = culture.Name;
            }

            var cultureParts = cultureName.Split('-');
            if (!cultureParts.Any())
                return null;

            var key = cultureParts.Last();

            if (Array.BinarySearch(_existingFlags, key, StringComparer.OrdinalIgnoreCase) < 0)
            {
                var bestMatch = culture.GetDescendants()
                    .Select(item => ConvertCultureIntoAbbreviation(item, recursionCounter))
                    .FirstOrDefault(item => item != null);

                if (bestMatch is null && recursionCounter < 3 && !culture.IsNeutralCulture)
                {
                    return ConvertCultureIntoAbbreviation(culture.Parent, recursionCounter + 1);
                }

                return bestMatch;
            }

            var resourcePath = string.Format(CultureInfo.InvariantCulture, @"{0}", key);
            return resourcePath.ToLower();
        }
    }
}