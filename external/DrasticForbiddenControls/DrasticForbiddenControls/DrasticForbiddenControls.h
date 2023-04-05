//
//  DrasticForbiddenControls.h
//  DrasticForbiddenControls
//
//  Created by ミラー・ティモシー on 2023/04/05.
//  https://steipete.com/posts/forbidden-controls-in-catalyst-mac-idiom/

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

//! Project version number for DrasticForbiddenControls.
FOUNDATION_EXPORT double DrasticForbiddenControlsVersionNumber;

//! Project version string for DrasticForbiddenControls.
FOUNDATION_EXPORT const unsigned char DrasticForbiddenControlsVersionString[];

// In this header, you should import all the public headers of your framework using statements like #import <DrasticForbiddenControls/PublicHeader.h>

@interface UIStepper (PrivateHaxx)
+ (void)_setAllowsUnsupportedMacIdiomBehavior:(int)behavior;
@end

@interface UIPickerView (PrivateHaxx)
+ (void)_setAllowsUnsupportedMacIdiomBehavior:(int)behavior;
@end

@interface UIRefreshControl (PrivateHaxx)
+ (void)_setAllowsUnsupportedMacIdiomBehavior:(int)behavior;
@end
