# Device Utils for Unity

## Requirements

- Unity 5.3+
- iOS 8.0+
- Android API level 16+

## Table of Contents

* [Integration](#integration)
* [Usage](#usage)

## Integration

Import the SDK package  `funplus-unity-sdk-device-utils-<version>.unitypackage` to your project.

The FunPlus SDK is structured in this way:

```shell
Assets/
└── FunPlus/
    └── DeviceUtils/
        ├── Editor/
        ├── Example/
        └── Plugins/
            ├── Android/
            └── iOS/
```

The `Example` directory is not necessarily a part of the SDK. You can choose not to import it to your project.

### For Android Project Only

When exporting your game to Android project, there're some extra work to complete.

**Add Google Play Services**

FunPlus SDK uses the [Google Advertising ID](https://support.google.com/googleplay/android-developer/answer/6048248?hl=en) to uniquely identify devices. To allow the SDK to use the Google Advertising ID, you must integrate the [Google Play Services](http://developer.android.com/google/play-services/setup.html). If you haven't done this yet, please open the `build.gradle` file of your app and add the following line to the `dependencies` block:

```groovy
compile 'com.google.android.gms:play-services-analytics:9.4.0'
```

## Usage

To call methods provided by `DeviceUtils`, the first step is to import its namespace to your source files:

```c#
using FunPlus.DeviceUtils;
```

### Get Play Advertising ID (Android Only)

This method might return `null`.

```c#
string playAdId = DeviceUtils.GetPlayAdId ();
```

### Get Android ID (Android Only)

```c#
string androidId = DeviceUtils.GetAndroidId ();
```

### Get Identifier for Vendor (iOS Only)

This method might return `null`.

```c#
string idfv = DeviceUtils.GetIdentifierForVendor ();
```

### Get Advertising Identifier (iOS Only)

This method might return `null`.

```c#
string idfa = DeviceUtils.GetAdvertisingIdentifier ();
```

### Get System Name

```c#
string systemName = DeviceUtils.GetSystemName ();
```

### Get System Version

```c#
string systemVersion = DeviceUtils.GetSystemVersion ();
```

### Get Device Model Name

```c#
string modelName = DeviceUtils.GetModelName ();
```

### Get Device Manufacturer (Android Only)

```c#
string manufacturer = DeviceUtils.GetManufacturer ();
```

### Get Android API Level (Android Only)

```c#
string androidApiLevel = DeviceUtils.GetAndroidApiLevel ();
```

### Get App Name

```c#
string appName = DeviceUtils.GetAppName ();
```

### Get App Version

```c#
string appVersion = DeviceUtils.GetAppVersion ();
```

### Get App Display Language

This method gets the display language for the application, it might be different from the device language.

```c#
string appLanguage = DeviceUtils.GetAppLanguage ();
```

### Get Network Carrier Name

```c#
string carrier = DeviceUtils.GetNetworkCarrierName ();
```

### Set Screen Brightness

For Android project, add the following permission declaration before the `application` tag in your `AndroidManifest.xml` if they're not present already.

```xml
<uses-permission android:name="android.permission.WRITE_SETTINGS"/>
```

Note that on Android 6.0+, it will return false and lead the user to a window that requests the `WRITE_SETTINGS` permission for the first time this method is called.

Value of the `brightness` parameter should be between 0 and 255. values less than 0 will be treat as 0, and values greater than 255 will be treat as 255.

```c#
int brightness = 120;
bool isSuccess = DeviceUtils.SetScreenBrightness (brightness);
```
