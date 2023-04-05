using Foundation;
using UIKit;

namespace DrasticForbiddenControls
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double DrasticForbiddenControlsVersionNumber;
		[Field ("DrasticForbiddenControlsVersionNumber", "__Internal")]
		double DrasticForbiddenControlsVersionNumber { get; }

		// extern const unsigned char[] DrasticForbiddenControlsVersionString;
		[Field ("DrasticForbiddenControlsVersionString", "__Internal")]
		byte[] DrasticForbiddenControlsVersionString { get; }
	}

	// @interface PrivateHaxx (UIStepper)
	[Category]
	[BaseType (typeof(UIStepper))]
	interface UIStepper_PrivateHaxx
	{
		// +(void)_setAllowsUnsupportedMacIdiomBehavior:(int)behavior;
		[Static]
		[Export ("_setAllowsUnsupportedMacIdiomBehavior:")]
		void _setAllowsUnsupportedMacIdiomBehavior (int behavior);
	}

	// @interface PrivateHaxx (UIPickerView)
	[Category]
	[BaseType (typeof(UIPickerView))]
	interface UIPickerView_PrivateHaxx
	{
		// +(void)_setAllowsUnsupportedMacIdiomBehavior:(int)behavior;
		[Static]
		[Export ("_setAllowsUnsupportedMacIdiomBehavior:")]
		void _setAllowsUnsupportedMacIdiomBehavior (int behavior);
	}

	// @interface PrivateHaxx (UIRefreshControl)
	[Category]
	[BaseType (typeof(UIRefreshControl))]
	interface UIRefreshControl_PrivateHaxx
	{
		// +(void)_setAllowsUnsupportedMacIdiomBehavior:(int)behavior;
		[Static]
		[Export ("_setAllowsUnsupportedMacIdiomBehavior:")]
		void _setAllowsUnsupportedMacIdiomBehavior (int behavior);
	}
}
