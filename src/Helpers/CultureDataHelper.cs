using PSC.Maui.Components.LanguageDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PSC.Maui.Components.LanguageDropdown.Helpers
{
    public class CultureDataHelper
    {
        #region Variables

        /// <summary>
        /// The string file name
        /// </summary>
        private const string strFileName = "PSC.Maui.Components.LanguageDropdown.data.json";

        /// <summary>
        /// The countries
        /// </summary>
        private readonly IEnumerable<LanguageModel>? _languages;

        #endregion Variables


        /// <summary>
        /// Initializes a new instance of the <see cref="CountryHelper"/> class.
        /// </summary>
        public CultureDataHelper()
        {
            var json = GetJsonData(strFileName);
            _languages = JsonSerializer.Deserialize<List<LanguageModel>>(json);
        }

        /// <summary>
        /// Gets the languages.
        /// </summary>
        /// <returns>List&lt;Language&gt;.</returns>
        public List<LanguageModel>? GetCultureData()
        {
            return _languages?.ToList();
        }

        /// <summary>
        /// Gets the name of the culture.
        /// </summary>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>System.Nullable&lt;System.String&gt;.</returns>
        public string? GetCultureName(string cultureCode)
        {
            if (cultureCode == null)
                return string.Empty;

            return _languages?.Where(l => l.Abbreviation.ToLower().Equals(cultureCode.ToLower()))?.FirstOrDefault()?.LanguageName;
        }

        /// <summary>
        /// Gets the json data.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>System.String.</returns>
        private string GetJsonData(string path)
        {
            string json = "";
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(path))
            {
                var reader = new StreamReader(stream);
                json = reader.ReadToEnd();
            }
            return json;
        }
    }
}
