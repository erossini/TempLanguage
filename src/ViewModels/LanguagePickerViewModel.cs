using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui;
using PSC.Maui.Components.LanguageDropdown.Extensions;
using PSC.Maui.Components.LanguageDropdown.Helpers;
using PSC.Maui.Components.LanguageDropdown.Models;
using PSC.Maui.Components.LanguageDropdown.Resources.Localizations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PSC.Maui.Components.LanguageDropdown.ViewModels
{
    public partial class LanguagePickerViewModel : ObservableObject
    {
        #region Observable Properties

        [ObservableProperty] private ObservableCollection<LanguageModelGroup>? availableCulturesGroups;
        [ObservableProperty] private ObservableCollection<LanguageModelGroup>? filteredCulturesGroups;
        [ObservableProperty] private ObservableCollection<LanguageModel>? availableCultures;
        [ObservableProperty] private ObservableCollection<LanguageModel>? recentCultures;
        [ObservableProperty] private ObservableCollection<LanguageModel>? supportedCultures;
        [ObservableProperty] private LanguageModel? selectedLanguage;
        [ObservableProperty] private string? flagTest;
        [ObservableProperty] private string? selectFilter;

        [ObservableProperty] private bool isEmpty;
        [ObservableProperty] private bool isLoading;
        [ObservableProperty] private bool showGroups;
        [ObservableProperty] private bool showOnlySupported;

        [ObservableProperty] private ObservableCollection<FilterModel>? filters;

        #endregion
        #region Constants

        private string[] StarCultureList = { "en-GB", "de-DE", "fr-FR", "it-IT", "pt-PT", "es-ES" };
        private string[] RecentCultureList = { "en-GB" };

        #endregion
        #region Variables

        private LanguageHelper? languageHelper;

        #endregion

        public LanguagePickerViewModel()
        {
            languageHelper = LanguageHelper.Instance;

            IsEmpty = true;
            isLoading = false;

            Filters = new ObservableCollection<FilterModel>() {
                new FilterModel() { Name = Strings.AllLanguages, Value = "All" },
                new FilterModel() { Name = Strings.Supported, Value = "Supported" },
                new FilterModel() { Name = Strings.Recently, Value = "Recent" }
            };

            RecentCultures = new ObservableCollection<LanguageModel>();
            SupportedCultures = new ObservableCollection<LanguageModel>();

            AvailableCulturesGroups = new ObservableCollection<LanguageModelGroup>(GetLanguages());
            FilteredCulturesGroups = AvailableCulturesGroups;

            ShowGroups = true;
            ShowOnlySupported = false;
        }

        /// <summary>
        /// Filters the items.
        /// </summary>
        /// <param name="filter">The filter.</param>
        public void FilterItems(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                FilteredCulturesGroups = new ObservableCollection<LanguageModelGroup>(availableCulturesGroups);
            }
            else
            {
                var filters = languageHelper.GetLanguageAvailable()
                                            .Where(item => item.LanguageName.ToLower().Contains(filter.ToLower()) ||
                                                   item.Abbreviation.ToLower().Contains(filter.ToLower())).ToList();
                FilteredCulturesGroups = new ObservableCollection<LanguageModelGroup>(filters.ToGroups());
            }
        }

        /// <summary>
        /// Gets the languages.
        /// </summary>
        /// <returns>List&lt;LanguageModelGroup&gt;.</returns>
        public List<LanguageModelGroup> GetLanguages()
        {
            List<LanguageModel> rtn = languageHelper.GetLanguageAvailable();
            List<LanguageModel> recents = new List<LanguageModel>();

            foreach (var item in StarCultureList)
                rtn.Where(l => l.Abbreviation == item).FirstOrDefault().IsSupported = true;

            foreach (var item in RecentCultureList)
                recents.Add(rtn.Where(l => l.Abbreviation == item).First());

            AvailableCultures = new ObservableCollection<LanguageModel>(rtn);
            List<LanguageModelGroup> groups = rtn.ToGroups();

            RecentCultures = new ObservableCollection<LanguageModel>(recents);
            SupportedCultures = new ObservableCollection<LanguageModel>(AvailableCultures.Where(c => c.IsSupported).ToList());

            return groups;
        }
    }
}