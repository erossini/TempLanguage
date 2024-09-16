# Language Dropdown from MAUI
A component for [MAUI](https://puresourcecode.com/tag/maui/) is to display a dropdown with languages. Include all the flags in SVG format and functions to get all language data.
The Language Dropdown for MAUI is available on [NuGet](https://www.nuget.org/packages/PSC.Maui.Components.LanguageDropdown/) as a package to use in your non-commercial applications. If you would like to use it for commercial use, please send me a message.

For more information about this component, please see my post on [PureSourceCode](https://puresourcecode.com/dotnet/maui/language-dropdown-for-maui/).

## Usage

First, the package has to be added to your project. You can install it with this command from the dotnet CLI

```
dotnet add package PSC.Maui.Components.LanguageDropdown --version 8.0.0
```

or with the NuGet command

```
Install-Package PSC.Maui.Components.LanguageDropdown -Version 8.0.0
```

Then, the component has to be registered in your application. The component requires the `CommunityToolkit.Maui` and must be added in the `MauiProgram.cs` after that.

```csharp
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseLanguageDropdown()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
    	builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
```

Now, you can use the component in the application.

### How to add the component

In your `MAUI` `ContentView` or `ContentPage`. the reference to the component must be added like in the following example:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    x:Class="LanguageDropdownDemo.MainPage"
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:components="clr-namespace:PSC.Maui.Components.LanguageDropdown;assembly=PSC.Maui.Components.LanguageDropdown"
    xmlns:local="clr-namespace:LanguageDropdownDemo.ViewModels">

    <ScrollView>
        <VerticalStackLayout Padding="30,0" Spacing="25">
		<components:LanguageDropdown
			x:Name="ldd"
                        BorderColor="Gray"
			IsDisplayPickerControl="{Binding IsDisplayPickerControl}"
			Placeholder="This is a test"
			SelectedItem="{Binding LanguageItem}" />

                <Image
                    HeightRequest="50"
                    Source="f_gb.png"
                    WidthRequest="50" />

                 <Image
                     HeightRequest="50"
                     Source="{Binding LanguageItem.Flag}"
                     WidthRequest="50" />
                 <Label HorizontalTextAlignment="Center" Text="{Binding LanguageItem.LanguageName}" />
        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
```

The code above shows the following screenshot

![image](https://github.com/user-attachments/assets/a98d6611-d40f-4f78-9647-931f0b130e85)

## Properties

| Name                   | Type          | Description                                                                  |
|------------------------|---------------|------------------------------------------------------------------------------|
| BorderColor            | Color         | Gets or sets the color or the border of the component                        |
| IsDisplayPickerControl | bool          | Gets or sets if the list of languages is displayed                           |
| Placeholder            | string        | Gets or sets the text to display as a placeholder until no selection is made |
| SelectedItem           | LanguageModel | Gets or sets the selected value                                              |

## Languages and flags

| Culture Name                                | Abbreviation | Flag     | Parent   |
|---------------------------------------------|--------------|----------|----------|
| Afar                                        | aa           | f_dj     |          |
| Afar (Djibouti)                             | aa-DJ        | f_dj     | aa       |
| Afar (Eritrea)                              | aa-ER        | f_er     | aa       |
| Afar (Ethiopia)                             | aa-ET        | f_et     | aa       |
| Afrikaans                                   | af           | f_na     |          |
| Afrikaans (Namibia)                         | af-NA        | f_na     | af       |
| Afrikaans (South Africa)                    | af-ZA        | f_za     | af       |
| Aghem                                       | agq          | f_cm     |          |
| Aghem (Cameroon)                            | agq-CM       | f_cm     | agq      |
| Akan                                        | ak           | f_gh     |          |
| Akan (Ghana)                                | ak-GH        | f_gh     | ak       |
| Albanian                                    | sq           | f_al     |          |
| Albanian (Albania)                          | sq-AL        | f_al     | sq       |
| Albanian (Kosovo)                           | sq-XK        | f_al     | sq       |
| Albanian (North Macedonia)                  | sq-MK        | f_mk     | sq       |
| Amharic                                     | am           | f_et     |          |
| Amharic (Ethiopia)                          | am-ET        | f_et     | am       |
| Arabic                                      | ar           | f_ae     |          |
| Arabic (Algeria)                            | ar-DZ        | f_dz     | ar       |
| Arabic (Bahrain)                            | ar-BH        | f_bh     | ar       |
| Arabic (Chad)                               | ar-TD        | f_td     | ar       |
| Arabic (Comoros)                            | ar-KM        | f_km     | ar       |
| Arabic (Djibouti)                           | ar-DJ        | f_dj     | ar       |
| Arabic (Egypt)                              | ar-EG        | f_eg     | ar       |
| Arabic (Eritrea)                            | ar-ER        | f_er     | ar       |
| Arabic (Iraq)                               | ar-IQ        | f_iq     | ar       |
| Arabic (Israel)                             | ar-IL        | f_il     | ar       |
| Arabic (Jordan)                             | ar-JO        | f_jo     | ar       |
| Arabic (Kuwait)                             | ar-KW        | f_kw     | ar       |
| Arabic (Lebanon)                            | ar-LB        | f_lb     | ar       |
| Arabic (Libya)                              | ar-LY        | f_ly     | ar       |
| Arabic (Mauritania)                         | ar-MR        | f_mr     | ar       |
| Arabic (Morocco)                            | ar-MA        | f_ma     | ar       |
| Arabic (Oman)                               | ar-OM        | f_om     | ar       |
| Arabic (Palestinian Territories)            | ar-PS        | f_ps     | ar       |
| Arabic (Qatar)                              | ar-QA        | f_qa     | ar       |
| Arabic (Saudi Arabia)                       | ar-SA        | f_sa     | ar       |
| Arabic (Somalia)                            | ar-SO        | f_so     | ar       |
| Arabic (South Sudan)                        | ar-SS        | f_ae     | ar       |
| Arabic (Sudan)                              | ar-SD        | f_sd     | ar       |
| Arabic (Syria)                              | ar-SY        | f_sy     | ar       |
| Arabic (Tunisia)                            | ar-TN        | f_tn     | ar       |
| Arabic (United Arab Emirates)               | ar-AE        | f_ae     | ar       |
| Arabic (World)                              | ar-001       | f_ae     | ar       |
| Arabic (Yemen)                              | ar-YE        | f_ye     | ar       |
| Armenian                                    | hy           | f_am     |          |
| Armenian (Armenia)                          | hy-AM        | f_am     | hy       |
| Assamese                                    | as           | f_in     |          |
| Assamese (India)                            | as-IN        | f_in     | as       |
| Asturian                                    | ast          | f_es     |          |
| Asturian (Spain)                            | ast-ES       | f_es     | ast      |
| Asu                                         | asa          | f_tz     |          |
| Asu (Tanzania)                              | asa-TZ       | f_tz     | asa      |
| Azerbaijani                                 | az           | f_az     |          |
| Azerbaijani (Cyrillic, Azerbaijan)          | az-Cyrl-AZ   | f_az     | az-Cyrl  |
| Azerbaijani (Cyrillic)                      | az-Cyrl      | f_az     | az       |
| Azerbaijani (Latin, Azerbaijan)             | az-Latn-AZ   | f_az     | az-Latn  |
| Azerbaijani (Latin)                         | az-Latn      | f_az     | az       |
| Bafia                                       | ksf          | f_cm     |          |
| Bafia (Cameroon)                            | ksf-CM       | f_cm     | ksf      |
| Bambara                                     | bm           | f_ml     |          |
| Bambara (Mali)                              | bm-ML        | f_ml     | bm       |
| Bangla                                      | bn           | f_bd     |          |
| Bangla (Bangladesh)                         | bn-BD        | f_bd     | bn       |
| Bangla (India)                              | bn-IN        | f_in     | bn       |
| Basaa                                       | bas          | f_cm     |          |
| Basaa (Cameroon)                            | bas-CM       | f_cm     | bas      |
| Bashkir                                     | ba           | f_ru     |          |
| Bashkir (Russia)                            | ba-RU        | f_ru     | ba       |
| Basque                                      | eu           | f_es     |          |
| Basque (Spain)                              | eu-ES        | f_es     | eu       |
| Belarusian                                  | be           | f_by     |          |
| Belarusian (Belarus)                        | be-BY        | f_by     | be       |
| Bemba                                       | bem          | f_zm     |          |
| Bemba (Zambia)                              | bem-ZM       | f_zm     | bem      |
| Bena                                        | bez          | f_tz     |          |
| Bena (Tanzania)                             | bez-TZ       | f_tz     | bez      |
| Bini                                        | bin          | f_ng     |          |
| Bini (Nigeria)                              | bin-NG       | f_ng     | bin      |
| Blin                                        | byn          | f_er     |          |
| Blin (Eritrea)                              | byn-ER       | f_er     | byn      |
| Bodo                                        | brx          | f_in     |          |
| Bodo (India)                                | brx-IN       | f_in     | brx      |
| Bosnian                                     | bs           | f_ba     |          |
| Bosnian (Cyrillic, Bosnia & Herzegovina)    | bs-Cyrl-BA   | f_ba     | bs-Cyrl  |
| Bosnian (Cyrillic)                          | bs-Cyrl      | f_ba     | bs       |
| Bosnian (Latin, Bosnia & Herzegovina)       | bs-Latn-BA   | f_ba     | bs-Latn  |
| Bosnian (Latin)                             | bs-Latn      | f_ba     | bs       |
| Breton                                      | br           | f_fr     |          |
| Breton (France)                             | br-FR        | f_fr     | br       |
| Bulgarian                                   | bg           | f_bg     |          |
| Bulgarian (Bulgaria)                        | bg-BG        | f_bg     | bg       |
| Burmese                                     | my           | f_mm     |          |
| Burmese (Myanmar [Burma])                   | my-MM        | f_mm     | my       |
| Catalan                                     | ca           | f_ad     |          |
| Catalan (Andorra)                           | ca-AD        | f_ad     | ca       |
| Catalan (France)                            | ca-FR        | f_fr     | ca       |
| Catalan (Italy)                             | ca-IT        | f_it     | ca       |
| Catalan (Spain)                             | ca-ES        | f_es     | ca       |
| Cebuano                                     | ceb          | f_ph     |          |
| Cebuano (Philippines)                       | ceb-PH       | f_ph     | ceb      |
| Central Atlas Tamazight                     | tzm          | f_ma     |          |
| Central Atlas Tamazight (Algeria)           | tzm-DZ       | f_dz     | tzm      |
| Central Atlas Tamazight (Arabic, Morocco)   | tzm-Arab-MA  | f_ma     | tzm-Arab |
| Central Atlas Tamazight (Arabic)            | tzm-Arab     | f_ma     | tzm      |
| Central Atlas Tamazight (Morocco)           | tzm-MA       | f_ma     | tzm      |
| Central Atlas Tamazight (Tifinagh, Morocco) | tzm-Tfng-MA  | f_ma     | tzm-Tfng |
| Central Atlas Tamazight (Tifinagh)          | tzm-Tfng     | f_ma     | tzm      |
| Central Kurdish                             | ckb          | f_iq     |          |
| Central Kurdish (Iran)                      | ckb-IR       | f_ir     | ckb      |
| Central Kurdish (Iraq)                      | ckb-IQ       | f_iq     | ckb      |
| Chakma                                      | ccp          | f_bd     |          |
| Chakma (Bangladesh)                         | ccp-BD       | f_bd     | ccp      |
| Chakma (India)                              | ccp-IN       | f_in     | ccp      |
| Chechen                                     | ce           | f_ru     |          |
| Chechen (Russia)                            | ce-RU        | f_ru     | ce       |
| Cherokee                                    | chr          | f_us     |          |
| Cherokee (United States)                    | chr-US       | f_us     | chr      |
| Chiga                                       | cgg          | f_ug     |          |
| Chiga (Uganda)                              | cgg-UG       | f_ug     | cgg      |
| Chinese                                     | zh           | f_cn     |          |
| Chinese (Simplified, China)                 | zh-Hans-CN   | f_cn     | zh-Hans  |
| Chinese (Simplified, Hong Kong SAR China)   | zh-Hans-HK   | f_hk     | zh-Hans  |
| Chinese (Simplified, Macao SAR)             | zh-Hans-MO   | f_mo     | zh-Hans  |
| Chinese (Simplified, Singapore)             | zh-Hans-SG   | f_sg     | zh-Hans  |
| Chinese (Simplified)                        | zh-Hans      | f_cn     | zh       |
| Chinese (Traditional, Hong Kong SAR China)  | zh-Hant-HK   | f_hk     | zh-Hant  |
| Chinese (Traditional, Macao SAR)            | zh-Hant-MO   | f_mo     | zh-Hant  |
| Chinese (Traditional, Taiwan)               | zh-Hant-TW   | f_tw     | zh-Hant  |
| Chinese (Traditional)                       | zh-Hant      | f_cn     | zh       |
| Church Slavic                               | cu           | f_ru     |          |
| Church Slavic (Russia)                      | cu-RU        | f_ru     | cu       |
| Colognian                                   | ksh          | f_de     |          |
| Colognian (Germany)                         | ksh-DE       | f_de     | ksh      |
| Cornish                                     | kw           | f_gb     |          |
| Cornish (United Kingdom)                    | kw-GB        | f_gb     | kw       |
| Corsican                                    | co           | f_fr     |          |
| Corsican (France)                           | co-FR        | f_fr     | co       |
| Croatian                                    | hr           | f_hr     |          |
| Croatian (Bosnia & Herzegovina)             | hr-BA        | f_ba     | hr       |
| Croatian (Croatia)                          | hr-HR        | f_hr     | hr       |
| Czech                                       | cs           | f_cz     |          |
| Czech (Czechia)                             | cs-CZ        | f_cz     | cs       |
| Danish                                      | da           | f_dk     |          |
| Danish (Denmark)                            | da-DK        | f_dk     | da       |
| Danish (Greenland)                          | da-GL        | f_gl     | da       |
| Divehi                                      | dv           | f_mv     |          |
| Divehi (Maldives)                           | dv-MV        | f_mv     | dv       |
| Dogri                                       | doi          | f_in     |          |
| Dogri (India)                               | doi-IN       | f_in     | doi      |
| Duala                                       | dua          | f_cm     |          |
| Duala (Cameroon)                            | dua-CM       | f_cm     | dua      |
| Dutch                                       | nl           | f_nl     |          |
| Dutch (Aruba)                               | nl-AW        | f_aw     | nl       |
| Dutch (Belgium)                             | nl-BE        | f_be     | nl       |
| Dutch (Caribbean Netherlands)               | nl-BQ        | f_nl     | nl       |
| Dutch (Curaçao)                             | nl-CW        | f_nl     | nl       |
| Dutch (Netherlands)                         | nl-NL        | f_nl     | nl       |
| Dutch (Sint Maarten)                        | nl-SX        | f_nl     | nl       |
| Dutch (Suriname)                            | nl-SR        | f_sr     | nl       |
| Dzongkha                                    | dz           | f_bt     |          |
| Dzongkha (Bhutan)                           | dz-BT        | f_bt     | dz       |
| Embu                                        | ebu          | f_ke     |          |
| Embu (Kenya)                                | ebu-KE       | f_ke     | ebu      |
| English                                     | en           | f_us     |          |
| English (American Samoa)                    | en-AS        | f_as     | en       |
| English (Anguilla)                          | en-AI        | f_ai     | en       |
| English (Antigua & Barbuda)                 | en-AG        | f_ag     | en       |
| English (Australia)                         | en-AU        | f_au     | en       |
| English (Austria)                           | en-AT        | f_at     | en       |
| English (Bahamas)                           | en-BS        | f_bs     | en       |
| English (Barbados)                          | en-BB        | f_bb     | en       |
| English (Belgium)                           | en-BE        | f_be     | en       |
| English (Belize)                            | en-BZ        | f_bz     | en       |
| English (Bermuda)                           | en-BM        | f_bm     | en       |
| English (Botswana)                          | en-BW        | f_bw     | en       |
| English (British Indian Ocean Territory)    | en-IO        | f_io     | en       |
| English (British Virgin Islands)            | en-VG        | f_vg     | en       |
| English (Burundi)                           | en-BI        | f_bi     | en       |
| English (Cameroon)                          | en-CM        | f_cm     | en       |
| English (Canada)                            | en-CA        | f_ca     | en       |
| English (Caribbean)                         | en-029       | f_us     | en       |
| English (Cayman Islands)                    | en-KY        | f_ky     | en       |
| English (Christmas Island)                  | en-CX        | f_cx     | en       |
| English (Cocos [Keeling] Islands)           | en-CC        | f_cc     | en       |
| English (Cook Islands)                      | en-CK        | f_ck     | en       |
| English (Cyprus)                            | en-CY        | f_cy     | en       |
| English (Denmark)                           | en-DK        | f_dk     | en       |
| English (Dominica)                          | en-DM        | f_dm     | en       |
| English (Eritrea)                           | en-ER        | f_er     | en       |
| English (Eswatini)                          | en-SZ        | f_sz     | en       |
| English (Europe)                            | en-150       | f_us     | en       |
| English (Falkland Islands)                  | en-FK        | f_fk     | en       |
| English (Fiji)                              | en-FJ        | f_fj     | en       |
| English (Finland)                           | en-FI        | f_fi     | en       |
| English (Gambia)                            | en-GM        | f_gm     | en       |
| English (Germany)                           | en-DE        | f_de     | en       |
| English (Ghana)                             | en-GH        | f_gh     | en       |
| English (Gibraltar)                         | en-GI        | f_gi     | en       |
| English (Grenada)                           | en-GD        | f_gd     | en       |
| English (Guam)                              | en-GU        | f_gu     | en       |
| English (Guernsey)                          | en-GG        | f_us     | en       |
| English (Guyana)                            | en-GY        | f_gy     | en       |
| English (Hong Kong SAR China)               | en-HK        | f_hk     | en       |
| English (India)                             | en-IN        | f_in     | en       |
| English (Indonesia)                         | en-ID        | f_id     | en       |
| English (Ireland)                           | en-IE        | f_ie     | en       |
| English (Isle of Man)                       | en-IM        | f_us     | en       |
| English (Israel)                            | en-IL        | f_il     | en       |
| English (Jamaica)                           | en-JM        | f_jm     | en       |
| English (Jersey)                            | en-JE        | f_us     | en       |
| English (Kenya)                             | en-KE        | f_ke     | en       |
| English (Kiribati)                          | en-KI        | f_ki     | en       |
| English (Lesotho)                           | en-LS        | f_ls     | en       |
| English (Liberia)                           | en-LR        | f_lr     | en       |
| English (Macao SAR)                         | en-MO        | f_mo     | en       |
| English (Madagascar)                        | en-MG        | f_mg     | en       |
| English (Malawi)                            | en-MW        | f_mw     | en       |
| English (Malaysia)                          | en-MY        | f_my     | en       |
| English (Malta)                             | en-MT        | f_mt     | en       |
| English (Marshall Islands)                  | en-MH        | f_mh     | en       |
| English (Mauritius)                         | en-MU        | f_mu     | en       |
| English (Micronesia)                        | en-FM        | f_fm     | en       |
| English (Montserrat)                        | en-MS        | f_ms     | en       |
| English (Namibia)                           | en-NA        | f_na     | en       |
| English (Nauru)                             | en-NR        | f_nr     | en       |
| English (Netherlands)                       | en-NL        | f_nl     | en       |
| English (New Zealand)                       | en-NZ        | f_nz     | en       |
| English (Nigeria)                           | en-NG        | f_ng     | en       |
| English (Niue)                              | en-NU        | f_nu     | en       |
| English (Norfolk Island)                    | en-NF        | f_nf     | en       |
| English (Northern Mariana Islands)          | en-MP        | f_mp     | en       |
| English (Pakistan)                          | en-PK        | f_pk     | en       |
| English (Palau)                             | en-PW        | f_pw     | en       |
| English (Papua New Guinea)                  | en-PG        | f_pg     | en       |
| English (Philippines)                       | en-PH        | f_ph     | en       |
| English (Pitcairn Islands)                  | en-PN        | f_pn     | en       |
| English (Puerto Rico)                       | en-PR        | f_pr     | en       |
| English (Rwanda)                            | en-RW        | f_rw     | en       |
| English (Samoa)                             | en-WS        | f_ws     | en       |
| English (Seychelles)                        | en-SC        | f_sc     | en       |
| English (Sierra Leone)                      | en-SL        | f_sl     | en       |
| English (Singapore)                         | en-SG        | f_sg     | en       |
| English (Sint Maarten)                      | en-SX        | f_us     | en       |
| English (Slovenia)                          | en-SI        | f_si     | en       |
| English (Solomon Islands)                   | en-SB        | f_sb     | en       |
| English (South Africa)                      | en-ZA        | f_za     | en       |
| English (South Sudan)                       | en-SS        | f_us     | en       |
| English (St Helena)                         | en-SH        | f_sh     | en       |
| English (St Kitts & Nevis)                  | en-KN        | f_kn     | en       |
| English (St Lucia)                          | en-LC        | f_lc     | en       |
| English (St Vincent & the Grenadines)       | en-VC        | f_vc     | en       |
| English (Sudan)                             | en-SD        | f_sd     | en       |
| English (Sweden)                            | en-SE        | f_se     | en       |
| English (Switzerland)                       | en-CH        | f_ch     | en       |
| English (Tanzania)                          | en-TZ        | f_tz     | en       |
| English (Tokelau)                           | en-TK        | f_tk     | en       |
| English (Tonga)                             | en-TO        | f_to     | en       |
| English (Trinidad & Tobago)                 | en-TT        | f_tt     | en       |
| English (Turks & Caicos Islands)            | en-TC        | f_tc     | en       |
| English (Tuvalu)                            | en-TV        | f_tv     | en       |
| English (Uganda)                            | en-UG        | f_ug     | en       |
| English (United Arab Emirates)              | en-AE        | f_ae     | en       |
| English (United Kingdom)                    | en-GB        | f_gb     | en       |
| English (United States, Computer)           | en-US-POSIX  | f_us     | en-US    |
| English (United States)                     | en-US        | f_us     | en       |
| English (US Outlying Islands)               | en-UM        | f_um     | en       |
| English (US Virgin Islands)                 | en-VI        | f_vi     | en       |
| English (Vanuatu)                           | en-VU        | f_vu     | en       |
| English (World)                             | en-001       | f_us     | en       |
| English (Zambia)                            | en-ZM        | f_zm     | en       |
| English (Zimbabwe)                          | en-ZW        | f_zw     | en       |
| Esperanto                                   | eo           |          |          |
| Esperanto (World)                           | eo-001       |          | eo       |
| Estonian                                    | et           | f_ee     |          |
| Estonian (Estonia)                          | et-EE        | f_ee     | et       |
| Ewe                                         | ee           | f_gh     |          |
| Ewe (Ghana)                                 | ee-GH        | f_gh     | ee       |
| Ewe (Togo)                                  | ee-TG        | f_tg     | ee       |
| Ewondo                                      | ewo          | f_cm     |          |
| Ewondo (Cameroon)                           | ewo-CM       | f_cm     | ewo      |
| Faroese                                     | fo           | f_fo     |          |
| Faroese (Denmark)                           | fo-DK        | f_dk     | fo       |
| Faroese (Faroe Islands)                     | fo-FO        | f_fo     | fo       |
| Filipino                                    | fil          | f_ph     |          |
| Filipino (Philippines)                      | fil-PH       | f_ph     | fil      |
| Finnish                                     | fi           | f_fi     |          |
| Finnish (Finland)                           | fi-FI        | f_fi     | fi       |
| French                                      | fr           | f_fr     |          |
| French (Algeria)                            | fr-DZ        | f_dz     | fr       |
| French (Belgium)                            | fr-BE        | f_be     | fr       |
| French (Benin)                              | fr-BJ        | f_bj     | fr       |
| French (Burkina Faso)                       | fr-BF        | f_bf     | fr       |
| French (Burundi)                            | fr-BI        | f_bi     | fr       |
| French (Cameroon)                           | fr-CM        | f_cm     | fr       |
| French (Canada)                             | fr-CA        | f_ca     | fr       |
| French (Caribbean)                          | fr-029       | f_fr     | fr       |
| French (Central African Republic)           | fr-CF        | f_cf     | fr       |
| French (Chad)                               | fr-TD        | f_td     | fr       |
| French (Comoros)                            | fr-KM        | f_km     | fr       |
| French (Congo - Brazzaville)                | fr-CG        | f_cg     | fr       |
| French (Congo - Kinshasa)                   | fr-CD        | f_cd     | fr       |
| French (Côte d’Ivoire)                      | fr-CI        | f_ci     | fr       |
| French (Djibouti)                           | fr-DJ        | f_dj     | fr       |
| French (Equatorial Guinea)                  | fr-GQ        | f_gq     | fr       |
| French (France)                             | fr-FR        | f_fr     | fr       |
| French (French Guiana)                      | fr-GF        | f_gf     | fr       |
| French (French Polynesia)                   | fr-PF        | f_pf     | fr       |
| French (Gabon)                              | fr-GA        | f_ga     | fr       |
| French (Guadeloupe)                         | fr-GP        | f_gp     | fr       |
| French (Guinea)                             | fr-GN        | f_gn     | fr       |
| French (Haiti)                              | fr-HT        | f_ht     | fr       |
| French (Luxembourg)                         | fr-LU        | f_lu     | fr       |
| French (Madagascar)                         | fr-MG        | f_mg     | fr       |
| French (Mali)                               | fr-ML        | f_ml     | fr       |
| French (Martinique)                         | fr-MQ        | f_mq     | fr       |
| French (Mauritania)                         | fr-MR        | f_mr     | fr       |
| French (Mauritius)                          | fr-MU        | f_mu     | fr       |
| French (Mayotte)                            | fr-YT        | f_yt     | fr       |
| French (Monaco)                             | fr-MC        | f_mc     | fr       |
| French (Morocco)                            | fr-MA        | f_ma     | fr       |
| French (New Caledonia)                      | fr-NC        | f_nc     | fr       |
| French (Niger)                              | fr-NE        | f_ne     | fr       |
| French (Réunion)                            | fr-RE        | f_re     | fr       |
| French (Rwanda)                             | fr-RW        | f_rw     | fr       |
| French (Senegal)                            | fr-SN        | f_sn     | fr       |
| French (Seychelles)                         | fr-SC        | f_sc     | fr       |
| French (St Barthélemy)                      | fr-BL        | f_fr     | fr       |
| French (St Martin)                          | fr-MF        | f_fr     | fr       |
| French (St Pierre & Miquelon)               | fr-PM        | f_pm     | fr       |
| French (Switzerland)                        | fr-CH        | f_ch     | fr       |
| French (Syria)                              | fr-SY        | f_sy     | fr       |
| French (Togo)                               | fr-TG        | f_tg     | fr       |
| French (Tunisia)                            | fr-TN        | f_tn     | fr       |
| French (Vanuatu)                            | fr-VU        | f_vu     | fr       |
| French (Wallis & Futuna)                    | fr-WF        | f_wf     | fr       |
| Friulian                                    | fur          | f_it     |          |
| Friulian (Italy)                            | fur-IT       | f_it     | fur      |
| Fulah                                       | ff           | f_bf     |          |
| Fulah (Adlam, Burkina Faso)                 | ff-Adlm-BF   | f_bf     | ff-Adlm  |
| Fulah (Adlam, Cameroon)                     | ff-Adlm-CM   | f_cm     | ff-Adlm  |
| Fulah (Adlam, Gambia)                       | ff-Adlm-GM   | f_gm     | ff-Adlm  |
| Fulah (Adlam, Ghana)                        | ff-Adlm-GH   | f_gh     | ff-Adlm  |
| Fulah (Adlam, Guinea-Bissau)                | ff-Adlm-GW   | f_gw     | ff-Adlm  |
| Fulah (Adlam, Guinea)                       | ff-Adlm-GN   | f_gn     | ff-Adlm  |
| Fulah (Adlam, Liberia)                      | ff-Adlm-LR   | f_lr     | ff-Adlm  |
| Fulah (Adlam, Mauritania)                   | ff-Adlm-MR   | f_mr     | ff-Adlm  |
| Fulah (Adlam, Niger)                        | ff-Adlm-NE   | f_ne     | ff-Adlm  |
| Fulah (Adlam, Nigeria)                      | ff-Adlm-NG   | f_ng     | ff-Adlm  |
| Fulah (Adlam, Senegal)                      | ff-Adlm-SN   | f_sn     | ff-Adlm  |
| Fulah (Adlam, Sierra Leone)                 | ff-Adlm-SL   | f_sl     | ff-Adlm  |
| Fulah (Adlam)                               | ff-Adlm      | f_bf     | ff       |
| Fulah (Latin, Burkina Faso)                 | ff-Latn-BF   | f_bf     | ff-Latn  |
| Fulah (Latin, Cameroon)                     | ff-Latn-CM   | f_cm     | ff-Latn  |
| Fulah (Latin, Gambia)                       | ff-Latn-GM   | f_gm     | ff-Latn  |
| Fulah (Latin, Ghana)                        | ff-Latn-GH   | f_gh     | ff-Latn  |
| Fulah (Latin, Guinea-Bissau)                | ff-Latn-GW   | f_gw     | ff-Latn  |
| Fulah (Latin, Guinea)                       | ff-Latn-GN   | f_gn     | ff-Latn  |
| Fulah (Latin, Liberia)                      | ff-Latn-LR   | f_lr     | ff-Latn  |
| Fulah (Latin, Mauritania)                   | ff-Latn-MR   | f_mr     | ff-Latn  |
| Fulah (Latin, Niger)                        | ff-Latn-NE   | f_ne     | ff-Latn  |
| Fulah (Latin, Nigeria)                      | ff-Latn-NG   | f_ng     | ff-Latn  |
| Fulah (Latin, Senegal)                      | ff-Latn-SN   | f_sn     | ff-Latn  |
| Fulah (Latin, Sierra Leone)                 | ff-Latn-SL   | f_sl     | ff-Latn  |
| Fulah (Latin)                               | ff-Latn      | f_bf     | ff       |
| Galician                                    | gl           | f_es     |          |
| Galician (Spain)                            | gl-ES        | f_es     | gl       |
| Ganda                                       | lg           | f_ug     |          |
| Ganda (Uganda)                              | lg-UG        | f_ug     | lg       |
| Georgian                                    | ka           | f_ge     |          |
| Georgian (Georgia)                          | ka-GE        | f_ge     | ka       |
| German                                      | de           | f_de     |          |
| German (Austria)                            | de-AT        | f_at     | de       |
| German (Belgium)                            | de-BE        | f_be     | de       |
| German (Germany)                            | de-DE        | f_de     | de       |
| German (Italy)                              | de-IT        | f_it     | de       |
| German (Liechtenstein)                      | de-LI        | f_li     | de       |
| German (Luxembourg)                         | de-LU        | f_lu     | de       |
| German (Switzerland)                        | de-CH        | f_ch     | de       |
| Greek                                       | el           | f_cy     |          |
| Greek (Cyprus)                              | el-CY        | f_cy     | el       |
| Greek (Greece)                              | el-GR        | f_gr     | el       |
| Guarani                                     | gn           | f_py     |          |
| Guarani (Paraguay)                          | gn-PY        | f_py     | gn       |
| Gujarati                                    | gu           | f_in     |          |
| Gujarati (India)                            | gu-IN        | f_in     | gu       |
| Gusii                                       | guz          | f_ke     |          |
| Gusii (Kenya)                               | guz-KE       | f_ke     | guz      |
| Hausa                                       | ha           | f_gh     |          |
| Hausa (Ghana)                               | ha-GH        | f_gh     | ha       |
| Hausa (Niger)                               | ha-NE        | f_ne     | ha       |
| Hausa (Nigeria)                             | ha-NG        | f_ng     | ha       |
| Hawaiian                                    | haw          | f_us     |          |
| Hawaiian (United States)                    | haw-US       | f_us     | haw      |
| Hebrew                                      | he           | f_il     |          |
| Hebrew (Israel)                             | he-IL        | f_il     | he       |
| Hindi                                       | hi           | f_in     |          |
| Hindi (India)                               | hi-IN        | f_in     | hi       |
| Hungarian                                   | hu           | f_hu     |          |
| Hungarian (Hungary)                         | hu-HU        | f_hu     | hu       |
| Ibibio                                      | ibb          | f_ng     |          |
| Ibibio (Nigeria)                            | ibb-NG       | f_ng     | ibb      |
| Icelandic                                   | is           | f_is     |          |
| Icelandic (Iceland)                         | is-IS        | f_is     | is       |
| Igbo                                        | ig           | f_ng     |          |
| Igbo (Nigeria)                              | ig-NG        | f_ng     | ig       |
| Inari Sami                                  | smn          | f_fi     |          |
| Inari Sami (Finland)                        | smn-FI       | f_fi     | smn      |
| Indonesian                                  | id           | f_id     |          |
| Indonesian (Indonesia)                      | id-ID        | f_id     | id       |
| Interlingua                                 | ia           |          |          |
| Interlingua (World)                         | ia-001       |          | ia       |
| Inuktitut                                   | iu           | f_ca     |          |
| Inuktitut (Canada)                          | iu-CA        | f_ca     | iu       |
| Inuktitut (Latin, Canada)                   | iu-Latn-CA   | f_ca     | iu-Latn  |
| Inuktitut (Latin)                           | iu-Latn      | f_ca     | iu       |
| Irish                                       | ga           | f_gb     |          |
| Irish (Ireland)                             | ga-IE        | f_ie     | ga       |
| Irish (United Kingdom)                      | ga-GB        | f_gb     | ga       |
| Italian                                     | it           | f_it     |          |
| Italian (Italy)                             | it-IT        | f_it     | it       |
| Italian (San Marino)                        | it-SM        | f_sm     | it       |
| Italian (Switzerland)                       | it-CH        | f_ch     | it       |
| Italian (Vatican City)                      | it-VA        | f_va     | it       |
| Japanese                                    | ja           | f_jp     |          |
| Japanese (Japan)                            | ja-JP        | f_jp     | ja       |
| Javanese                                    | jv           | f_id     |          |
| Javanese (Indonesia)                        | jv-ID        | f_id     | jv       |
| Javanese (Javanese, Indonesia)              | jv-Java-ID   | f_id     | jv-Java  |
| Javanese (Javanese)                         | jv-Java      | f_id     | jv       |
| Jola-Fonyi                                  | dyo          | f_sn     |          |
| Jola-Fonyi (Senegal)                        | dyo-SN       | f_sn     | dyo      |
| Kabuverdianu                                | kea          | f_cv     |          |
| Kabuverdianu (Cape Verde)                   | kea-CV       | f_cv     | kea      |
| Kabyle                                      | kab          | f_dz     |          |
| Kabyle (Algeria)                            | kab-DZ       | f_dz     | kab      |
| Kako                                        | kkj          | f_cm     |          |
| Kako (Cameroon)                             | kkj-CM       | f_cm     | kkj      |
| Kalaallisut                                 | kl           | f_gl     |          |
| Kalaallisut (Greenland)                     | kl-GL        | f_gl     | kl       |
| Kalenjin                                    | kln          | f_ke     |          |
| Kalenjin (Kenya)                            | kln-KE       | f_ke     | kln      |
| Kamba                                       | kam          | f_ke     |          |
| Kamba (Kenya)                               | kam-KE       | f_ke     | kam      |
| Kannada                                     | kn           | f_in     |          |
| Kannada (India)                             | kn-IN        | f_in     | kn       |
| Kanuri                                      | kr           | f_ng     |          |
| Kanuri (Latin, Nigeria)                     | kr-Latn-NG   | f_ng     | kr-Latn  |
| Kanuri (Latin)                              | kr-Latn      | f_ng     | kr       |
| Kashmiri                                    | ks           | f_in     |          |
| Kashmiri (Arabic, India)                    | ks-Arab-IN   | f_in     | ks-Arab  |
| Kashmiri (Arabic)                           | ks-Arab      | f_in     | ks       |
| Kashmiri (Devanagari, India)                | ks-Deva-IN   | f_in     | ks-Deva  |
| Kashmiri (Devanagari)                       | ks-Deva      | f_in     | ks       |
| Kazakh                                      | kk           | f_kz     |          |
| Kazakh (Kazakhstan)                         | kk-KZ        | f_kz     | kk       |
| Khmer                                       | km           | f_kh     |          |
| Khmer (Cambodia)                            | km-KH        | f_kh     | km       |
| Kikuyu                                      | ki           | f_ke     |          |
| Kikuyu (Kenya)                              | ki-KE        | f_ke     | ki       |
| Kinyarwanda                                 | rw           | f_rw     |          |
| Kinyarwanda (Rwanda)                        | rw-RW        | f_rw     | rw       |
| Konkani                                     | kok          | f_in     |          |
| Konkani (India)                             | kok-IN       | f_in     | kok      |
| Korean                                      | ko           | f_kp     |          |
| Korean (North Korea)                        | ko-KP        | f_kp     | ko       |
| Korean (South Korea)                        | ko-KR        | f_kr     | ko       |
| Koyra Chiini                                | khq          | f_ml     |          |
| Koyra Chiini (Mali)                         | khq-ML       | f_ml     | khq      |
| Koyraboro Senni                             | ses          | f_ml     |          |
| Koyraboro Senni (Mali)                      | ses-ML       | f_ml     | ses      |
| Kwasio                                      | nmg          | f_cm     |          |
| Kwasio (Cameroon)                           | nmg-CM       | f_cm     | nmg      |
| Kyrgyz                                      | ky           | f_kg     |          |
| Kyrgyz (Kyrgyzstan)                         | ky-KG        | f_kg     | ky       |
| Kʼicheʼ                                     | quc          | f_gt     |          |
| Kʼicheʼ (Guatemala)                         | quc-GT       | f_gt     | quc      |
| Lakota                                      | lkt          | f_us     |          |
| Lakota (United States)                      | lkt-US       | f_us     | lkt      |
| Langi                                       | lag          | f_tz     |          |
| Langi (Tanzania)                            | lag-TZ       | f_tz     | lag      |
| Lao                                         | lo           | f_la     |          |
| Lao (Laos)                                  | lo-LA        | f_la     | lo       |
| Latin                                       | la           | f_va     |          |
| Latin (Vatican City)                        | la-VA        | f_va     | la       |
| Latvian                                     | lv           | f_lv     |          |
| Latvian (Latvia)                            | lv-LV        | f_lv     | lv       |
| Lingala                                     | ln           | f_ao     |          |
| Lingala (Angola)                            | ln-AO        | f_ao     | ln       |
| Lingala (Central African Republic)          | ln-CF        | f_cf     | ln       |
| Lingala (Congo - Brazzaville)               | ln-CG        | f_cg     | ln       |
| Lingala (Congo - Kinshasa)                  | ln-CD        | f_cd     | ln       |
| Lithuanian                                  | lt           | f_lt     |          |
| Lithuanian (Lithuania)                      | lt-LT        | f_lt     | lt       |
| Low German                                  | nds          | f_nl     |          |
| Low German (Germany)                        | nds-DE       | f_de     | nds      |
| Low German (Netherlands)                    | nds-NL       | f_nl     | nds      |
| Lower Sorbian                               | dsb          | f_de     |          |
| Lower Sorbian (Germany)                     | dsb-DE       | f_de     | dsb      |
| Luba-Katanga                                | lu           | f_cd     |          |
| Luba-Katanga (Congo - Kinshasa)             | lu-CD        | f_cd     | lu       |
| Lule Sami                                   | smj          | f_se     |          |
| Lule Sami (Norway)                          | smj-NO       | f_no     | smj      |
| Lule Sami (Sweden)                          | smj-SE       | f_se     | smj      |
| Luo                                         | luo          | f_ke     |          |
| Luo (Kenya)                                 | luo-KE       | f_ke     | luo      |
| Luxembourgish                               | lb           | f_lu     |          |
| Luxembourgish (Luxembourg)                  | lb-LU        | f_lu     | lb       |
| Luyia                                       | luy          | f_ke     |          |
| Luyia (Kenya)                               | luy-KE       | f_ke     | luy      |
| Macedonian                                  | mk           | f_mk     |          |
| Macedonian (North Macedonia)                | mk-MK        | f_mk     | mk       |
| Machame                                     | jmc          | f_tz     |          |
| Machame (Tanzania)                          | jmc-TZ       | f_tz     | jmc      |
| Maithili                                    | mai          | f_in     |          |
| Maithili (India)                            | mai-IN       | f_in     | mai      |
| Makhuwa-Meetto                              | mgh          | f_mz     |          |
| Makhuwa-Meetto (Mozambique)                 | mgh-MZ       | f_mz     | mgh      |
| Makonde                                     | kde          | f_tz     |          |
| Makonde (Tanzania)                          | kde-TZ       | f_tz     | kde      |
| Malagasy                                    | mg           | f_mg     |          |
| Malagasy (Madagascar)                       | mg-MG        | f_mg     | mg       |
| Malay                                       | ms           | f_my     |          |
| Malay (Brunei)                              | ms-BN        | f_bn     | ms       |
| Malay (Indonesia)                           | ms-ID        | f_id     | ms       |
| Malay (Malaysia)                            | ms-MY        | f_my     | ms       |
| Malay (Singapore)                           | ms-SG        | f_sg     | ms       |
| Malayalam                                   | ml           | f_in     |          |
| Malayalam (India)                           | ml-IN        | f_in     | ml       |
| Maltese                                     | mt           | f_mt     |          |
| Maltese (Malta)                             | mt-MT        | f_mt     | mt       |
| Manipuri                                    | mni          | f_in     |          |
| Manipuri (Bangla, India)                    | mni-Beng-IN  | f_in     | mni-Beng |
| Manipuri (Bangla)                           | mni-Beng     | f_in     | mni      |
| Manx                                        | gv           |          |          |
| Manx (Isle of Man)                          | gv-IM        |          | gv       |
| Maori                                       | mi           | f_nz     |          |
| Maori (New Zealand)                         | mi-NZ        | f_nz     | mi       |
| Mapuche                                     | arn          | f_cl     |          |
| Mapuche (Chile)                             | arn-CL       | f_cl     | arn      |
| Marathi                                     | mr           | f_in     |          |
| Marathi (India)                             | mr-IN        | f_in     | mr       |
| Masai                                       | mas          | f_ke     |          |
| Masai (Kenya)                               | mas-KE       | f_ke     | mas      |
| Masai (Tanzania)                            | mas-TZ       | f_tz     | mas      |
| Mazanderani                                 | mzn          | f_ir     |          |
| Mazanderani (Iran)                          | mzn-IR       | f_ir     | mzn      |
| Meru                                        | mer          | f_ke     |          |
| Meru (Kenya)                                | mer-KE       | f_ke     | mer      |
| Metaʼ                                       | mgo          | f_cm     |          |
| Metaʼ (Cameroon)                            | mgo-CM       | f_cm     | mgo      |
| Mohawk                                      | moh          | f_ca     |          |
| Mohawk (Canada)                             | moh-CA       | f_ca     | moh      |
| Mongolian                                   | mn           | f_mn     |          |
| Mongolian (Mongolia)                        | mn-MN        | f_mn     | mn       |
| Mongolian (Mongolian, China)                | mn-Mong-CN   | f_cn     | mn-Mong  |
| Mongolian (Mongolian, Mongolia)             | mn-Mong-MN   | f_mn     | mn-Mong  |
| Mongolian (Mongolian)                       | mn-Mong      | f_mn     | mn       |
| Morisyen                                    | mfe          | f_mu     |          |
| Morisyen (Mauritius)                        | mfe-MU       | f_mu     | mfe      |
| Mundang                                     | mua          | f_cm     |          |
| Mundang (Cameroon)                          | mua-CM       | f_cm     | mua      |
| N’Ko                                        | nqo          | f_gn     |          |
| N’Ko (Guinea)                               | nqo-GN       | f_gn     | nqo      |
| Nama                                        | naq          | f_na     |          |
| Nama (Namibia)                              | naq-NA       | f_na     | naq      |
| Nepali                                      | ne           | f_np     |          |
| Nepali (India)                              | ne-IN        | f_in     | ne       |
| Nepali (Nepal)                              | ne-NP        | f_np     | ne       |
| Ngiemboon                                   | nnh          | f_cm     |          |
| Ngiemboon (Cameroon)                        | nnh-CM       | f_cm     | nnh      |
| Ngomba                                      | jgo          | f_cm     |          |
| Ngomba (Cameroon)                           | jgo-CM       | f_cm     | jgo      |
| Nigerian Pidgin                             | pcm          | f_ng     |          |
| Nigerian Pidgin (Nigeria)                   | pcm-NG       | f_ng     | pcm      |
| North Ndebele                               | nd           | f_zw     |          |
| North Ndebele (Zimbabwe)                    | nd-ZW        | f_zw     | nd       |
| Northern Luri                               | lrc          | f_iq     |          |
| Northern Luri (Iran)                        | lrc-IR       | f_ir     | lrc      |
| Northern Luri (Iraq)                        | lrc-IQ       | f_iq     | lrc      |
| Northern Sami                               | se           | f_se     |          |
| Northern Sami (Finland)                     | se-FI        | f_fi     | se       |
| Northern Sami (Norway)                      | se-NO        | f_no     | se       |
| Northern Sami (Sweden)                      | se-SE        | f_se     | se       |
| Northern Sotho                              | nso          | f_za     |          |
| Northern Sotho (South Africa)               | nso-ZA       | f_za     | nso      |
| Norwegian Bokmål                            | nb           | f_no     |          |
| Norwegian Bokmål (Norway)                   | nb-NO        | f_no     | nb       |
| Norwegian Bokmål (Svalbard & Jan Mayen)     | nb-SJ        | f_sj     | nb       |
| Norwegian Nynorsk                           | nn           | f_no     |          |
| Norwegian Nynorsk (Norway)                  | nn-NO        | f_no     | nn       |
| Nuer                                        | nus          |          |          |
| Nuer (South Sudan)                          | nus-SS       |          | nus      |
| Nyankole                                    | nyn          | f_ug     |          |
| Nyankole (Uganda)                           | nyn-UG       | f_ug     | nyn      |
| Occitan                                     | oc           | f_fr     |          |
| Occitan (France)                            | oc-FR        | f_fr     | oc       |
| Odia                                        | or           | f_in     |          |
| Odia (India)                                | or-IN        | f_in     | or       |
| Oromo                                       | om           | f_et     |          |
| Oromo (Ethiopia)                            | om-ET        | f_et     | om       |
| Oromo (Kenya)                               | om-KE        | f_ke     | om       |
| Ossetic                                     | os           | f_ge     |          |
| Ossetic (Georgia)                           | os-GE        | f_ge     | os       |
| Ossetic (Russia)                            | os-RU        | f_ru     | os       |
| Papiamento                                  | pap          |          |          |
| Papiamento (Caribbean)                      | pap-029      |          | pap      |
| Pashto                                      | ps           | f_pk     |          |
| Pashto (Afghanistan)                        | ps-AF        | f_af     | ps       |
| Pashto (Pakistan)                           | ps-PK        | f_pk     | ps       |
| Persian                                     | fa           | f_af     |          |
| Persian (Afghanistan)                       | fa-AF        | f_af     | fa       |
| Persian (Iran)                              | fa-IR        | f_ir     | fa       |
| Polish                                      | pl           | f_pl     |          |
| Polish (Poland)                             | pl-PL        | f_pl     | pl       |
| Portuguese                                  | pt           | f_pt     |          |
| Portuguese (Angola)                         | pt-AO        | f_ao     | pt       |
| Portuguese (Brazil)                         | pt-BR        | f_br     | pt       |
| Portuguese (Cape Verde)                     | pt-CV        | f_cv     | pt       |
| Portuguese (Equatorial Guinea)              | pt-GQ        | f_gq     | pt       |
| Portuguese (Guinea-Bissau)                  | pt-GW        | f_gw     | pt       |
| Portuguese (Luxembourg)                     | pt-LU        | f_lu     | pt       |
| Portuguese (Macao SAR)                      | pt-MO        | f_mo     | pt       |
| Portuguese (Mozambique)                     | pt-MZ        | f_mz     | pt       |
| Portuguese (Portugal)                       | pt-PT        | f_pt     | pt       |
| Portuguese (São Tomé & Príncipe)            | pt-ST        | f_st     | pt       |
| Portuguese (Switzerland)                    | pt-CH        | f_ch     | pt       |
| Portuguese (Timor-Leste)                    | pt-TL        | f_tl     | pt       |
| Prussian                                    | prg          |          |          |
| Prussian (World)                            | prg-001      |          | prg      |
| Punjabi                                     | pa           | f_pk     |          |
| Punjabi (Arabic, Pakistan)                  | pa-Arab-PK   | f_pk     | pa-Arab  |
| Punjabi (Arabic)                            | pa-Arab      | f_pk     | pa       |
| Punjabi (Gurmukhi, India)                   | pa-Guru-IN   | f_in     | pa-Guru  |
| Punjabi (Gurmukhi)                          | pa-Guru      | f_in     | pa       |
| Quechua                                     | qu           | f_bo     |          |
| Quechua (Bolivia)                           | qu-BO        | f_bo     | qu       |
| Quechua (Ecuador)                           | qu-EC        | f_ec     | qu       |
| Quechua (Peru)                              | qu-PE        | f_pe     | qu       |
| Romanian                                    | ro           | f_ro     |          |
| Romanian (Moldova)                          | ro-MD        | f_md     | ro       |
| Romanian (Romania)                          | ro-RO        | f_ro     | ro       |
| Romansh                                     | rm           | f_ch     |          |
| Romansh (Switzerland)                       | rm-CH        | f_ch     | rm       |
| Rombo                                       | rof          | f_tz     |          |
| Rombo (Tanzania)                            | rof-TZ       | f_tz     | rof      |
| Rundi                                       | rn           | f_bi     |          |
| Rundi (Burundi)                             | rn-BI        | f_bi     | rn       |
| Russian                                     | ru           | f_ru     |          |
| Russian (Belarus)                           | ru-BY        | f_by     | ru       |
| Russian (Kazakhstan)                        | ru-KZ        | f_kz     | ru       |
| Russian (Kyrgyzstan)                        | ru-KG        | f_kg     | ru       |
| Russian (Moldova)                           | ru-MD        | f_md     | ru       |
| Russian (Russia)                            | ru-RU        | f_ru     | ru       |
| Russian (Ukraine)                           | ru-UA        | f_ua     | ru       |
| Rwa                                         | rwk          | f_tz     |          |
| Rwa (Tanzania)                              | rwk-TZ       | f_tz     | rwk      |
| Saho                                        | ssy          | f_er     |          |
| Saho (Eritrea)                              | ssy-ER       | f_er     | ssy      |
| Samburu                                     | saq          | f_ke     |          |
| Samburu (Kenya)                             | saq-KE       | f_ke     | saq      |
| Sango                                       | sg           | f_cf     |          |
| Sango (Central African Republic)            | sg-CF        | f_cf     | sg       |
| Sangu                                       | sbp          | f_tz     |          |
| Sangu (Tanzania)                            | sbp-TZ       | f_tz     | sbp      |
| Sanskrit                                    | sa           | f_in     |          |
| Sanskrit (India)                            | sa-IN        | f_in     | sa       |
| Santali                                     | sat          | f_in     |          |
| Santali (Ol Chiki, India)                   | sat-Olck-IN  | f_in     | sat-Olck |
| Santali (Ol Chiki)                          | sat-Olck     | f_in     | sat      |
| Scottish Gaelic                             | gd           | f_gb     |          |
| Scottish Gaelic (United Kingdom)            | gd-GB        | f_gb     | gd       |
| Sena                                        | seh          | f_mz     |          |
| Sena (Mozambique)                           | seh-MZ       | f_mz     | seh      |
| Serbian                                     | sr           | f_ba     |          |
| Serbian (Cyrillic, Bosnia & Herzegovina)    | sr-Cyrl-BA   | f_ba     | sr-Cyrl  |
| Serbian (Cyrillic, Kosovo)                  | sr-Cyrl-XK   | f_ba     | sr-Cyrl  |
| Serbian (Cyrillic, Montenegro)              | sr-Cyrl-ME   | f_me     | sr-Cyrl  |
| Serbian (Cyrillic, Serbia)                  | sr-Cyrl-RS   | f_rs     | sr-Cyrl  |
| Serbian (Cyrillic)                          | sr-Cyrl      | f_ba     | sr       |
| Serbian (Latin, Bosnia & Herzegovina)       | sr-Latn-BA   | f_ba     | sr-Latn  |
| Serbian (Latin, Kosovo)                     | sr-Latn-XK   | f_ba     | sr-Latn  |
| Serbian (Latin, Montenegro)                 | sr-Latn-ME   | f_me     | sr-Latn  |
| Serbian (Latin, Serbia)                     | sr-Latn-RS   | f_rs     | sr-Latn  |
| Serbian (Latin)                             | sr-Latn      | f_ba     | sr       |
| Shambala                                    | ksb          | f_tz     |          |
| Shambala (Tanzania)                         | ksb-TZ       | f_tz     | ksb      |
| Shona                                       | sn           | f_zw     |          |
| Shona (Zimbabwe)                            | sn-ZW        | f_zw     | sn       |
| Sichuan Yi                                  | ii           | f_cn     |          |
| Sichuan Yi (China)                          | ii-CN        | f_cn     | ii       |
| Sindhi                                      | sd           | f_pk     |          |
| Sindhi (Arabic, Pakistan)                   | sd-Arab-PK   | f_pk     | sd-Arab  |
| Sindhi (Arabic)                             | sd-Arab      | f_pk     | sd       |
| Sindhi (Devanagari, India)                  | sd-Deva-IN   | f_in     | sd-Deva  |
| Sindhi (Devanagari)                         | sd-Deva      | f_in     | sd       |
| Sinhala                                     | si           | f_lk     |          |
| Sinhala (Sri Lanka)                         | si-LK        | f_lk     | si       |
| Skolt Sami                                  | sms          | f_fi     |          |
| Skolt Sami (Finland)                        | sms-FI       | f_fi     | sms      |
| Slovak                                      | sk           | f_sk     |          |
| Slovak (Slovakia)                           | sk-SK        | f_sk     | sk       |
| Slovenian                                   | sl           | f_si     |          |
| Slovenian (Slovenia)                        | sl-SI        | f_si     | sl       |
| Soga                                        | xog          | f_ug     |          |
| Soga (Uganda)                               | xog-UG       | f_ug     | xog      |
| Somali                                      | so           | f_so     |          |
| Somali (Djibouti)                           | so-DJ        | f_dj     | so       |
| Somali (Ethiopia)                           | so-ET        | f_et     | so       |
| Somali (Kenya)                              | so-KE        | f_ke     | so       |
| Somali (Somalia)                            | so-SO        | f_so     | so       |
| South Ndebele                               | nr           | f_za     |          |
| South Ndebele (South Africa)                | nr-ZA        | f_za     | nr       |
| Southern Sami                               | sma          | f_se     |          |
| Southern Sami (Norway)                      | sma-NO       | f_no     | sma      |
| Southern Sami (Sweden)                      | sma-SE       | f_se     | sma      |
| Southern Sotho                              | st           | f_ls     |          |
| Southern Sotho (Lesotho)                    | st-LS        | f_ls     | st       |
| Southern Sotho (South Africa)               | st-ZA        | f_za     | st       |
| Spanish                                     | es           | f_es     |          |
| Spanish (Argentina)                         | es-AR        | f_ar     | es       |
| Spanish (Belize)                            | es-BZ        | f_bz     | es       |
| Spanish (Bolivia)                           | es-BO        | f_bo     | es       |
| Spanish (Brazil)                            | es-BR        | f_br     | es       |
| Spanish (Chile)                             | es-CL        | f_cl     | es       |
| Spanish (Colombia)                          | es-CO        | f_co     | es       |
| Spanish (Costa Rica)                        | es-CR        | f_cr     | es       |
| Spanish (Cuba)                              | es-CU        | f_cu     | es       |
| Spanish (Dominican Republic)                | es-DO        | f_do     | es       |
| Spanish (Ecuador)                           | es-EC        | f_ec     | es       |
| Spanish (El Salvador)                       | es-SV        | f_sv     | es       |
| Spanish (Equatorial Guinea)                 | es-GQ        | f_gq     | es       |
| Spanish (Guatemala)                         | es-GT        | f_gt     | es       |
| Spanish (Honduras)                          | es-HN        | f_hn     | es       |
| Spanish (Latin America)                     | es-419       | f_es     | es       |
| Spanish (Mexico)                            | es-MX        | f_mx     | es       |
| Spanish (Nicaragua)                         | es-NI        | f_ni     | es       |
| Spanish (Panama)                            | es-PA        | f_pa     | es       |
| Spanish (Paraguay)                          | es-PY        | f_py     | es       |
| Spanish (Peru)                              | es-PE        | f_pe     | es       |
| Spanish (Philippines)                       | es-PH        | f_ph     | es       |
| Spanish (Puerto Rico)                       | es-PR        | f_pr     | es       |
| Spanish (Spain)                             | es-ES        | f_es     | es       |
| Spanish (United States)                     | es-US        | f_us     | es       |
| Spanish (Uruguay)                           | es-UY        | f_uy     | es       |
| Spanish (Venezuela)                         | es-VE        | f_ve     | es       |
| Standard Moroccan Tamazight                 | zgh          | f_ma     |          |
| Standard Moroccan Tamazight (Morocco)       | zgh-MA       | f_ma     | zgh      |
| Sundanese                                   | su           | f_id     |          |
| Sundanese (Latin, Indonesia)                | su-Latn-ID   | f_id     | su-Latn  |
| Sundanese (Latin)                           | su-Latn      | f_id     | su       |
| Swahili                                     | sw           | f_cd     |          |
| Swahili (Congo - Kinshasa)                  | sw-CD        | f_cd     | sw       |
| Swahili (Kenya)                             | sw-KE        | f_ke     | sw       |
| Swahili (Tanzania)                          | sw-TZ        | f_tz     | sw       |
| Swahili (Uganda)                            | sw-UG        | f_ug     | sw       |
| Swati                                       | ss           | f_sz     |          |
| Swati (Eswatini)                            | ss-SZ        | f_sz     | ss       |
| Swati (South Africa)                        | ss-ZA        | f_za     | ss       |
| Swedish                                     | sv           | f_se     |          |
| Swedish (Åland Islands)                     | sv-AX        | f_ax     | sv       |
| Swedish (Finland)                           | sv-FI        | f_fi     | sv       |
| Swedish (Sweden)                            | sv-SE        | f_se     | sv       |
| Swiss German                                | gsw          | f_ch     |          |
| Swiss German (France)                       | gsw-FR       | f_fr     | gsw      |
| Swiss German (Liechtenstein)                | gsw-LI       | f_li     | gsw      |
| Swiss German (Switzerland)                  | gsw-CH       | f_ch     | gsw      |
| Syriac                                      | syr          | f_sy     |          |
| Syriac (Syria)                              | syr-SY       | f_sy     | syr      |
| Tachelhit                                   | shi          | f_ma     |          |
| Tachelhit (Latin, Morocco)                  | shi-Latn-MA  | f_ma     | shi-Latn |
| Tachelhit (Latin)                           | shi-Latn     | f_ma     | shi      |
| Tachelhit (Tifinagh, Morocco)               | shi-Tfng-MA  | f_ma     | shi-Tfng |
| Tachelhit (Tifinagh)                        | shi-Tfng     | f_ma     | shi      |
| Taita                                       | dav          | f_ke     |          |
| Taita (Kenya)                               | dav-KE       | f_ke     | dav      |
| Tajik                                       | tg           | f_tj     |          |
| Tajik (Tajikistan)                          | tg-TJ        | f_tj     | tg       |
| Tamil                                       | ta           | f_in     |          |
| Tamil (India)                               | ta-IN        | f_in     | ta       |
| Tamil (Malaysia)                            | ta-MY        | f_my     | ta       |
| Tamil (Singapore)                           | ta-SG        | f_sg     | ta       |
| Tamil (Sri Lanka)                           | ta-LK        | f_lk     | ta       |
| Tasawaq                                     | twq          | f_ne     |          |
| Tasawaq (Niger)                             | twq-NE       | f_ne     | twq      |
| Tatar                                       | tt           | f_ru     |          |
| Tatar (Russia)                              | tt-RU        | f_ru     | tt       |
| Telugu                                      | te           | f_in     |          |
| Telugu (India)                              | te-IN        | f_in     | te       |
| Teso                                        | teo          | f_ke     |          |
| Teso (Kenya)                                | teo-KE       | f_ke     | teo      |
| Teso (Uganda)                               | teo-UG       | f_ug     | teo      |
| Thai                                        | th           | f_th     |          |
| Thai (Thailand)                             | th-TH        | f_th     | th       |
| Tibetan                                     | bo           | f_cn     |          |
| Tibetan (China)                             | bo-CN        | f_cn     | bo       |
| Tibetan (India)                             | bo-IN        | f_in     | bo       |
| Tigre                                       | tig          | f_er     |          |
| Tigre (Eritrea)                             | tig-ER       | f_er     | tig      |
| Tigrinya                                    | ti           | f_er     |          |
| Tigrinya (Eritrea)                          | ti-ER        | f_er     | ti       |
| Tigrinya (Ethiopia)                         | ti-ET        | f_et     | ti       |
| Tongan                                      | to           | f_to     |          |
| Tongan (Tonga)                              | to-TO        | f_to     | to       |
| Tsonga                                      | ts           | f_za     |          |
| Tsonga (South Africa)                       | ts-ZA        | f_za     | ts       |
| Tswana                                      | tn           | f_bw     |          |
| Tswana (Botswana)                           | tn-BW        | f_bw     | tn       |
| Tswana (South Africa)                       | tn-ZA        | f_za     | tn       |
| Turkish                                     | tr           | f_tr     |          |
| Turkish (Cyprus)                            | tr-CY        | f_cy     | tr       |
| Turkish (Turkey)                            | tr-TR        | f_tr     | tr       |
| Turkmen                                     | tk           | f_tm     |          |
| Turkmen (Turkmenistan)                      | tk-TM        | f_tm     | tk       |
| Ukrainian                                   | uk           | f_ua     |          |
| Ukrainian (Ukraine)                         | uk-UA        | f_ua     | uk       |
| Upper Sorbian                               | hsb          | f_de     |          |
| Upper Sorbian (Germany)                     | hsb-DE       | f_de     | hsb      |
| Urdu                                        | ur           | f_in     |          |
| Urdu (India)                                | ur-IN        | f_in     | ur       |
| Urdu (Pakistan)                             | ur-PK        | f_pk     | ur       |
| Uyghur                                      | ug           | f_cn     |          |
| Uyghur (China)                              | ug-CN        | f_cn     | ug       |
| Uzbek                                       | uz           | f_uz     |          |
| Uzbek (Arabic, Afghanistan)                 | uz-Arab-AF   | f_af     | uz-Arab  |
| Uzbek (Arabic)                              | uz-Arab      | f_af     | uz       |
| Uzbek (Cyrillic, Uzbekistan)                | uz-Cyrl-UZ   | f_uz     | uz-Cyrl  |
| Uzbek (Cyrillic)                            | uz-Cyrl      | f_uz     | uz       |
| Uzbek (Latin, Uzbekistan)                   | uz-Latn-UZ   | f_uz     | uz-Latn  |
| Uzbek (Latin)                               | uz-Latn      | f_uz     | uz       |
| Vai                                         | vai          | f_lr     |          |
| Vai (Latin, Liberia)                        | vai-Latn-LR  | f_lr     | vai-Latn |
| Vai (Latin)                                 | vai-Latn     | f_lr     | vai      |
| Vai (Vai, Liberia)                          | vai-Vaii-LR  | f_lr     | vai-Vaii |
| Vai (Vai)                                   | vai-Vaii     | f_lr     | vai      |
| Venda                                       | ve           | f_za     |          |
| Venda (South Africa)                        | ve-ZA        | f_za     | ve       |
| Vietnamese                                  | vi           | f_vn     |          |
| Vietnamese (Vietnam)                        | vi-VN        | f_vn     | vi       |
| Volapük                                     | vo           |          |          |
| Volapük (World)                             | vo-001       |          | vo       |
| Vunjo                                       | vun          | f_tz     |          |
| Vunjo (Tanzania)                            | vun-TZ       | f_tz     | vun      |
| Walser                                      | wae          | f_ch     |          |
| Walser (Switzerland)                        | wae-CH       | f_ch     | wae      |
| Welsh                                       | cy           | f_gb     |          |
| Welsh (United Kingdom)                      | cy-GB        | f_gb     | cy       |
| Western Frisian                             | fy           | f_fy     |          |
| Western Frisian (Netherlands)               | fy-NL        | f_nl     | fy       |
| Wolaytta                                    | wal          | f_et     |          |
| Wolaytta (Ethiopia)                         | wal-ET       | f_et     | wal      |
| Wolof                                       | wo           | f_sn     |          |
| Wolof (Senegal)                             | wo-SN        | f_sn     | wo       |
| Xhosa                                       | xh           | f_za     |          |
| Xhosa (South Africa)                        | xh-ZA        | f_za     | xh       |
| Yakut                                       | sah          | f_ru     |          |
| Yakut (Russia)                              | sah-RU       | f_ru     | sah      |
| Yangben                                     | yav          | f_cm     |          |
| Yangben (Cameroon)                          | yav-CM       | f_cm     | yav      |
| Yiddish                                     | yi           |          |          |
| Yiddish (World)                             | yi-001       |          | yi       |
| Yoruba                                      | yo           | f_bj     |          |
| Yoruba (Benin)                              | yo-BJ        | f_bj     | yo       |
| Yoruba (Nigeria)                            | yo-NG        | f_ng     | yo       |
| Zarma                                       | dje          | f_ne     |          |
| Zarma (Niger)                               | dje-NE       | f_ne     | dje      |
| Zulu                                        | zu           | f_za     |          |
| Zulu (South Africa)                         | zu-ZA        | f_za     | zu       |

## Screenshot

### iOS Screenshot

![LanguageDropdown_iOS](https://github.com/user-attachments/assets/abcdc47a-0e65-4ea0-9b63-a10c4c1dc1b3)

### Android

![LanguageDropdown_Android](https://github.com/user-attachments/assets/c923ba2c-7405-491d-a78a-a23e6768d713)

### Windows

![LanguageDropdown_Windows](https://github.com/user-attachments/assets/79ff833b-3c31-4eba-b8d1-6989fb6640c5)

## More links
* [CSharpCountryData: A simple cross platform offline .NET library for getting country data](https://github.com/erossini/CSharpCountryData)
* [CSharp Country Data](https://puresourcecode.com/dotnet/net8/country-data-library-for-net8/)
* [Demo Source Code](https://github.com/erossini/MAUILanguageDropdown)  
* [NuGet package](https://www.nuget.org/packages/PSC.Maui.Components.LanguageDropdown/)
* [Language Dropdown for MAUI on PureSourceCode](https://puresourcecode.com/dotnet/maui/language-dropdown-for-maui/)

---
    
## PureSourceCode.com

[PureSourceCode.com](https://www.puresourcecode.com/) is my personal blog where I publish posts about technologies and in particular source code and projects in [.NET](https://www.puresourcecode.com/category/dotnet/). 

In the last few months, I created a lot of components for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/).

My name is Enrico Rossini and you can contact me via:
- [Personal Twitter](https://twitter.com/erossiniuk)
- [LinkedIn](https://www.linkedin.com/in/rossiniuk)
- [Facebook](https://www.facebook.com/puresourcecode)

## Blazor Components

| Component name | Forum | NuGet | Website | Description |
| --- | --- | --- | --- | --- |
| AnchorLink | [Forum](https://puresourcecode.com/forum/anchorlink/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.AnchorLink) |     | An anchor link is a web link that allows users to leapfrog to a specific point on a website page. It saves them the need to scroll and skim read and makes navigation easier. This component is for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Autocomplete for Blazor](https://www.puresourcecode.com/dotnet/net-core/autocomplete-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/autocomplete-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Autocomplete) |     | Simple and flexible autocomplete type-ahead functionality for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.BrowserDetect) | [Demo](https://browserdetect.puresourcecode.com) | Browser detect for Blazor WebAssembly and Blazor Server |
| [ChartJs for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/chart-js-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Chartjs) | [Demo](https://chartjs.puresourcecode.com/) | Add beautiful graphs based on ChartJs in your Blazor application |
| [Clippy for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/clippy/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Clippy) | [Demo](https://clippy.puresourcecode.com/) | Do you miss Clippy? Here the implementation for Blazor |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CodeSnippet) |     | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CopyToClipboard) |     | Add a button to copy text in the clipboard |
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.DataTable) | [Demo](https://datatable.puresourcecode.com/) | DataTable component for Blazor WebAssembly and Blazor Server |
| Google Tag Manager | \[Forum\]() | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.GoogleTagManager) | [Demo](https://datatable.puresourcecode.com/) | Adds Google Tag Manager to the application and manages communication with GTM JavaScript (data layer). |
| [Icons and flags for Blazor](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Icons) |     | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| ImageSelect for Blazor | [Forum](https://puresourcecode.com/forum/imageselect/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ImageSelect) |     | This is a Blazor component to display a dropdown list with images based on ms-Dropdown by Marghoob Suleman. This component is built with NET7 for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://puresourcecode.com/forum/markdowneditor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.MarkdownEditor) | [Demo](https://markdown.puresourcecode.com/) | This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Modal dialog for Blazor](https://puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://puresourcecode.com/forum/modaldialog/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ModalDialog) |     | Simple Modal Dialog for Blazor WebAssembly |
| [Modal windows for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://puresourcecode.com/forum/modaldialog/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Modals) |     | Modal Windows for Blazor WebAssembly |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://puresourcecode.com/forum/blazor-components/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Quill) |     | Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [ScrollTabs](https://www.puresourcecode.com/dotnet/blazor/scrolltabs-component-for-blazor/) |     | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ScrollTabs) |     | Tabs with nice scroll (no scrollbar) and responsive |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://puresourcecode.com/forum/segments/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Segments) |     | This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://puresourcecode.com/forum/tabs/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tabs) |     | This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [Timeline for Blazor](https://www.puresourcecode.com/dotnet/blazor/timeline-component-for-blazor/) | [Forum](https://puresourcecode.com/forum/timeline/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Timeline) |     | This is a new responsive timeline for Blazor Web Assembly and Blazor Server |
| [Toast for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://puresourcecode.com/forum/blazor-components/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Toast) |     | Toast notification for Blazor applications |
| [Tours for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://puresourcecode.com/forum/blazor-components/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tours) |     | Guide your users in your Blazor applications |
| TreeView for Blazor | [Forum](https://puresourcecode.com/forum/treeview/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.TreeView) |     | This component is a native Blazor TreeView component for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/). The component is built with .NET7. |
| [WorldMap for Blazor](https://puresourcecode.com/dotnet/blazor/world-map-component-for-blazor) | [Forum](https://puresourcecode.com/forum/worldmap/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.WorldMap) | [Demo](https://worldmap.puresourcecode.com/) | Show world maps with your data |

## C# libraries for .NET6

| Component name | Forum | NuGet | Description |
|---|---|---|---|
| [PSC.Evaluator](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Evaluator) | PSC.Evaluator is a mathematical expressions evaluator library written in C#. Allows to evaluate mathematical, boolean, string and datetime expressions. |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Extensions) | A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |

## More examples and documentation

### Blazor
*   [Write a reusable Blazor component](https://www.puresourcecode.com/dotnet/blazor/write-a-reusable-blazor-component/)
*   [Getting Started With C# And Blazor](https://www.puresourcecode.com/dotnet/net-core/getting-started-with-c-and-blazor/)
*   [Setting Up A Blazor WebAssembly Application](https://www.puresourcecode.com/dotnet/blazor/setting-up-a-blazor-webassembly-application/)
*   [Working With Blazor Component Model](https://www.puresourcecode.com/dotnet/blazor/working-with-blazors-component-model/)
*   [Secure Blazor WebAssembly With IdentityServer4](https://www.puresourcecode.com/dotnet/blazor/secure-blazor-webassembly-with-identityserver4/)
*   [Blazor Using HttpClient With Authentication](https://www.puresourcecode.com/dotnet/blazor/blazor-using-httpclient-with-authentication/)
*   [InputSelect component for enumerations in Blazor](https://www.puresourcecode.com/dotnet/blazor/inputselect-component-for-enumerations-in-blazor/)
*   [Use LocalStorage with Blazor WebAssembly](https://www.puresourcecode.com/dotnet/blazor/use-localstorage-with-blazor-webassembly/)
*   [Modal Dialog component for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/)
*   [Create Tooltip component for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-tooltip-component-for-blazor/)
*   [Consume ASP.NET Core Razor components from Razor class libraries | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-5.0&tabs=visual-studio)
*   [ChartJs component for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/)
*   [Labels and OnClickChart for ChartJs](https://www.puresourcecode.com/dotnet/blazor/labels-and-onclickchart-for-chartjs/)

### Blazor & NET8
* [Custom User Management with NET8 and Blazor (1st part)](https://puresourcecode.com/dotnet/blazor/custom-user-management-with-net8-and-blazor/)
* [NET8, Blazor and Custom User Management (2nd part)](https://puresourcecode.com/dotnet/blazor/net8-blazor-and-custom-user-management/)
