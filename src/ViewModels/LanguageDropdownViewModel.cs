using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PSC.Maui.Components.LanguageDropdown.ViewModels
{
    public partial class LanguageDropdownViewModel : ObservableObject
    {
        #region Observable Properties

        [ObservableProperty] private bool isLoading;
        [ObservableProperty] private bool isDisplayPicker;

        #endregion

        public LanguageDropdownViewModel()
        {
            IsLoading = false;
            IsDisplayPicker = false;
        }
    }
}