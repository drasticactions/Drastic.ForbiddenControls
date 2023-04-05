using Foundation;
using UIKit;

namespace DrasticForbiddenControls
{
    public static class CatalystControls
    {
        public static void AllowsUnsupportedMacIdiomBehavior()
        {
            DrasticForbiddenControls.UIPickerView_PrivateHaxx.SetAllowsUnsupportedMacIdiomBehavior(new UIPickerView(), 1);
            DrasticForbiddenControls.UIStepper_PrivateHaxx.SetAllowsUnsupportedMacIdiomBehavior(new UIStepper(), 1);
            DrasticForbiddenControls.UIRefreshControl_PrivateHaxx.SetAllowsUnsupportedMacIdiomBehavior(new UIRefreshControl(), 1);
        }
    }
}