using CommunityToolkit.Maui;
using PSC.Maui.Components.LanguageDropdown.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Maui.Components.LanguageDropdown
{
    public static class LanguageDropdownHelper
    {
        // create your own builder logic here
        public static MauiAppBuilder UseLanguageDropdown(this MauiAppBuilder builder)
        {
            // If your library has any nuget plugin dependencies, add all their documented builder setups here...
            // UseMauiCommunityToolkit is an example, it does report ".UseMauiCommunityToolkit()` must be chained to `.UseMauiApp<T>()" 
            // However, it really should be placed in MauiProgram. Even with the build Output error, the project executes successfully. 
            builder.UseMauiCommunityToolkit();

            // Add all of your project's library builder stuff here (if any).
            builder.Services.AddSingleton<LanguageHelper>();
            builder.Services.AddTransient<LanguageDropdown>();
            builder.Services.AddTransient<LanguagePicker>();

            // Return your custom builder object.
            return builder;
        }
    }
}
