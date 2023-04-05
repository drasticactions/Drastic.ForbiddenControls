using Foundation;
using UIKit;

namespace Drastic.ForbiddenControlsSamples;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        DrasticForbiddenControls.CatalystControls.AllowsUnsupportedMacIdiomBehavior();
        return base.FinishedLaunching(application, launchOptions);
    }
}
