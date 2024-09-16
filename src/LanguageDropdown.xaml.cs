using CommunityToolkit.Maui.Views;
using PSC.Maui.Components.LanguageDropdown.Models;
using PSC.Maui.Components.LanguageDropdown.ViewModels;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PSC.Maui.Components.LanguageDropdown;

public partial class LanguageDropdown : Border
{
    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
        defaultValue: Color.FromArgb("#dcdcdc"),
        propertyName: nameof(BorderColor),
        returnType: typeof(Color),
        declaringType: typeof(LanguageDropdown),
        defaultBindingMode: BindingMode.TwoWay);

    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(
        propertyName: nameof(SelectedItem),
        returnType: typeof(object),
        declaringType: typeof(LanguageDropdown),
        propertyChanged: CurrentItemPropertyChanged,
        defaultBindingMode: BindingMode.TwoWay);

    public static readonly BindableProperty IsDisplayPickerControlProperty = BindableProperty.Create(
        propertyName: nameof(IsDisplayPickerControl),
        returnType: typeof(bool),
        declaringType: typeof(LanguageDropdown),
        propertyChanged: IsDisplayPickerControlPropertyChanged,
        defaultBindingMode: BindingMode.TwoWay);

    public static readonly BindableProperty IsLoadingProperty = BindableProperty.Create(
       propertyName: nameof(IsLoading),
       returnType: typeof(bool),
       declaringType: typeof(LanguageDropdown),
       defaultBindingMode: BindingMode.OneWay);

    public static readonly BindableProperty ItemSourceProperty = BindableProperty.Create(
        propertyName: nameof(ItemSource),
        returnType: typeof(IEnumerable),
        declaringType: typeof(LanguageDropdown),
        defaultBindingMode: BindingMode.OneWay);

    public static readonly BindableProperty OpenPickerCommandProperty = BindableProperty.Create(
       propertyName: nameof(OpenPickerCommand),
       returnType: typeof(ICommand),
       declaringType: typeof(LanguageDropdown),
       defaultBindingMode: BindingMode.TwoWay);

    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
        propertyName: nameof(Placeholder),
        returnType: typeof(string),
        declaringType: typeof(LanguageDropdown),
        propertyChanged: PlaceholderPropertyChanged,
        defaultBindingMode: BindingMode.OneWay);

    public LanguageDropdown()
    {
        InitializeComponent();
    }

    public event EventHandler<EventArgs> OpenPickerEvent;

    public Color BorderColor
    {
        get => (Color)GetValue(BorderColorProperty);
        set => SetValue(BorderColorProperty, value);
    }

    public object SelectedItem
    {
        get => (object)GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }

    public string DisplayMember { get; set; } = "LanguageName";

    public string ImageDisplayMember { get; set; } = "Flag";

    public bool IsDisplayPickerControl
    {
        get => (bool)GetValue(IsDisplayPickerControlProperty);
        set => SetValue(IsDisplayPickerControlProperty, value);
    }

    public bool IsLoading
    {
        get => (bool)GetValue(IsLoadingProperty);
        set => SetValue(IsLoadingProperty, value);
    }

    public IEnumerable ItemSource
    {
        get => (IEnumerable)GetValue(ItemSourceProperty);
        set => SetValue(ItemSourceProperty, value);
    }

    public DataTemplate ItemTemplate { get; set; }

    public ICommand OpenPickerCommand
    {
        get => (ICommand)GetValue(OpenPickerCommandProperty);
        set => SetValue(OpenPickerCommandProperty, value);
    }

    public double PickerHeightRequest { get; set; }

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    private static void CurrentItemPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (LanguageDropdown)bindable;

        if (newValue != null)
        {
            if (!string.IsNullOrWhiteSpace(controls.DisplayMember))
                controls.lblDropDown.Text = newValue.GetType().GetProperty(controls.DisplayMember).GetValue(newValue, null).ToString();
            if (!string.IsNullOrWhiteSpace(controls.ImageDisplayMember))
                controls.imgDropDown.Source = newValue.GetType().GetProperty(controls.ImageDisplayMember).GetValue(newValue, null).ToString();
        }

        controls.IsLoading = false;
    }

    private static async void IsDisplayPickerControlPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (LanguageDropdown)bindable;

        if (newValue != null)
        {
            if ((bool)newValue)
            {
                var pickerControlView = new LanguagePicker();
                var response = await Application.Current.MainPage.ShowPopupAsync(new LanguagePicker(), new CancellationToken());
                if (response != null)
                    controls.SelectedItem = response;

                controls.IsDisplayPickerControl = false;
            }
        }
    }

    private static void PlaceholderPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (LanguageDropdown)bindable;

        if (controls.SelectedItem == null)
        {
            if (newValue != null)
            {
                controls.lblDropDown.Text = newValue.ToString();
            }
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        IsLoading = true;

        OpenPickerCommand?.Execute(null);
        OpenPickerEvent?.Invoke(sender, e);

        IsDisplayPickerControl = true;
    }
}