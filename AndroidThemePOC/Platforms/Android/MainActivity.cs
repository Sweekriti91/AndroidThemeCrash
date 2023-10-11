using Android.App;
using Android.Content.PM;

namespace AndroidThemePOC;

[Activity(
    // Theme = "@style/Maui.SplashTheme", // From the blank MAUI app
    Theme = "@style/Theme.SplashScreen", // Message (Java.Lang.Throwable): "The style on this component requires your app theme to be Theme.MaterialComponents (or a descendant)."
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}

