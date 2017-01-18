//
//  DeviceUtilsUnityBridge.mm
//  DeviceUtilsUnityBridge
//
//  Created by Yuankun Zhang on 17/01/2017.
//  Copyright © 2017 FunPlus. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <DeviceUtils/DeviceUtils-Swift.h>

extern "C"
{
    extern void UnitySendMessage(const char *, const char *, const char *);

    const char * _getIdentifierForVendor() {
        NSString *identifierForVendor = [DeviceUtilsOC getIdentifierForVendor];
        return strdup([identifierForVendor UTF8String]);
    }

    const char * _getAdvertisingIdentifier() {
        NSString *advertisingIdentifier = [DeviceUtilsOC getIdentifierForVendor];
        return strdup([advertisingIdentifier UTF8String]);
    }

    const char * _getModelName() {
        NSString *modelName = [DeviceUtilsOC getModelName];
        return strdup([modelName UTF8String]);
    }

    const char * _getSystemName() {
        NSString *systemName = [DeviceUtilsOC getSystemName];
        return strdup([systemName UTF8String]);
    }

    const char * _getSystemVersion() {
        NSString *systemVersion = [DeviceUtilsOC getSystemVersion];
        return strdup([systemVersion UTF8String]);
    }

    const char * _getAppName() {
        NSString *appName = [DeviceUtilsOC getSystemName];
        return strdup([appName UTF8String]);
    }

    const char * _getAppVersion() {
        NSString *appVersion = [DeviceUtilsOC getSystemVersion];
        return strdup([appVersion UTF8String]);
    }

    const char * _getAppLanguage() {
        NSString *appLanguage = [DeviceUtilsOC getAppLanguage];
        return strdup([appLanguage UTF8String]);
    }

    const char * _getNetworkCarrierName() {
        NSString *networkCarrierName = [DeviceUtilsOC getNetworkCarrierName];
        return strdup([networkCarrierName UTF8String]);
    }

    int _getScreenBrightness() {
        CGFloat value = [DeviceUtilsOC getScreenBrightness];
        return (int) (value * 255.0);
    }

    bool _setScreenBrightness(int brightness) {
        CGFloat value = brightness / 255.0;
        return [DeviceUtilsOC setScreenBrightnessWithBrightness: value];
    }
}
