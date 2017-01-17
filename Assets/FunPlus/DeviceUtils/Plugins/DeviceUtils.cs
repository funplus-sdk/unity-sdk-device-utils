using UnityEngine;
using System.Collections;

namespace FunPlus.DeviceUtils
{

	public class DeviceUtils
	{
		private const string CALLING_IN_UNITY_EDITOR = "Calling DeviceUtis.{0} in the Unity Editor";
		private const string UNSUPPORTED_PLATFORM = "Error calling DeviceUtils.{0}: unsupported platform";

		public static string getIdentifierForVendor ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getIdentifierForVendor()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.getIdentifierForVendor ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getIdentifierForVendor()");
			#endif
		}

		public static string getAdvertisingIdentifier ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getAdvertisingIdentifier()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.getAdvertisingIdentifier ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getAdvertisingIdentifier()");
			#endif
		}

		public static string getAndroidId ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getAndroidId()");
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getAndroidId ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getAndroidId()");
			#endif
		}

		public static string getPlayAdvertisingId ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getPlayAdvertisingId()");
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getPlayAdvertisingId ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getPlayAdvertisingId()");
			#endif
		}

		public static string getModelName ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getModelName()");
			#elif UNITY_IOS
			#elif UNITY_ANDROID
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getModelName()");
			#endif
		}

		public static string getManufacturer ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getManufacturer()");
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getManufacturer ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getManufacturer()");
			#endif
		}

		public static string getSystemName ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getSystemName()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.getSystemName ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getSystemName ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getSystemName()");
			#endif
		}

		public static string getSystemVersion ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getSystemVersion()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.getSystemVersion ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getSystemVersion ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getSystemVersion()");
			#endif
		}

		public static string getAndroidApiLevel ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getAndroidApiLevel()");
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getAndroidApiLevel ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getAndroidApiLevel()");
			#endif
		}

		public static string getAppName()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getAppName()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.getAppName ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getAppName ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getAppName()");
			#endif
		}

		public static string getAppVersion()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getAppVersion()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.getAppVersion ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getAppVersion ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getAppVersion()");
			#endif
		}

		public static string getAppLanguage()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getAppLanguage()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.getAppLanguage ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getAppLanguage ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getAppLanguage()");
			#endif
		}

		public static string getNetworkCarrierName()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "getNetworkCarrierName()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.getNetworkCarrierName ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.getNetworkCarrierName ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "getNetworkCarrierName()");
			#endif
		}

		public static bool setScreenBrightness(float brightness)
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "setScreenBrightness()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.setScreenBrightness (brightness);
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.setScreenBrightness (brightness);
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "setScreenBrightness()");
			#endif
		}
	}

}