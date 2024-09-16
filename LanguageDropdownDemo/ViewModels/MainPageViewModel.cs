using CommunityToolkit.Mvvm.ComponentModel;
using PSC.Maui.Components.LanguageDropdown.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LanguageDropdownDemo.ViewModels
{
    public partial class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        LanguageModel? _item;
        public LanguageModel? LanguageItem
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }

        bool _isDisplayPickerControl;
        public bool IsDisplayPickerControl
        {
            get { return _isDisplayPickerControl; }
            set
            {
                _isDisplayPickerControl = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
        }

        ~MainPageViewModel() {}

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
