# Device Utils for Unity

## Requirements

- Unity 5.3+
- iOS 8.0+
- Android API level 16+

## Table of Contents

* [Integration](#integration)
* [Usage](#usage)

## Integration

Import the SDK package  `funplus-unity-sdk-<version>.unitypackage` to your project.

The FunPlus SDK is structured in this way:

```shell
Assets/
└── FunPlus/
    └── DeviceUtils/
        ├── Editor/
        ├── Example/
        └── Plugins
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

**Add `WRITE_SETTINGS` permission**

Add the following permission declaration before the `application` tag in your `AndroidManifest.xml` if they're not present already.

```xml
<uses-permission android:name="android.permission.WRITE_SETTINGS"/>
```

## Usage

To call methods provided by `DeviceUtils`, the first step is to import its namespace to your source files:

```c#
using namespace FunPlus.DeviceUtils;
```

### Get the Play Advertising ID (Android Only)

```c#
string playAdId = DeviceUtils.GetPlayAdId ();
```

The returning value might be null.

### Get the Android ID (Android Only)

```c#
string androidId = DeviceUtils.GetAndroidId ();
```

### Get the Identifier for Vendor (iOS Only)

```c#
string idfv = DeviceUtils.GetIdentifierForVendor ();
```

The returning value might be null.

### Get the Advertising Identifier (iOS Only)

```c#
string idfa = DeviceUtils.GetAdvertisingIdentifier ();
```

### Get the System Name

```c#
string systemName = DeviceUtils.GetSystemName ();
```

### Get the System Version

```c#
string systemVersion = DeviceUtils.GetSystemVersion ();
```

### Get Device's Model Name

```c#
string modelName = DeviceUtils.GetModelName ();
```

### Get Device's Manufacturer (Android Only)

```c#
string manufacturer = DeviceUtils.GetManufacturer ();
```

### Get App's Name

```c#
string appName = DeviceUtils.GetAppName ();
```

### Get App's Version

```c#
string appVersion = DeviceUtils.GetAppVersion ();
```

### Get App's Language

```c#
string appLanguage = DeviceUtils.GetAppLanguage ();
```

### Get the Network Carrier Name

```c#
string carrier = DeviceUtils.GetNetworkCarrierName ();
```

### Set the Screen Brightness

```c#
int brightness = 120;
bool isSuccess = DeviceUtils.SetScreenBrightness (brightness);
```

Value of the `brightness` parameter should be between 0 and 255. values less than 0 will be treat as 0, and values greater than 255 will be treat as 255.

Note that on Android 6.0+, it will return false and lead the user to a window that requests the `WRITE_SETTINGS` permission for the first time this method is called.