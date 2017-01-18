using UnityEngine;
using System.Collections;

namespace FunPlus.DeviceUtils
{

	public class DeviceUtils
	{
		public static string VERSION = "4.0.0-alpha.0";

		private const string CALLING_IN_UNITY_EDITOR = "Calling DeviceUtis.{0} in the Unity Editor";
		private const string UNSUPPORTED_PLATFORM = "Error calling DeviceUtils.{0}: unsupported platform";

		public static string GetIdentifierForVendor ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetIdentifierForVendor()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetIdentifierForVendor ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetIdentifierForVendor()");
			#endif
		}

		public static string GetAdvertisingIdentifier ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetAdvertisingIdentifier()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetAdvertisingIdentifier ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetAdvertisingIdentifier()");
			#endif
		}

		public static string GetAndroidId ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetAndroidId()");
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetAndroidId ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetAndroidId()");
			#endif
		}

		public static string GetPlayAdId ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetPlayAdId()");
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetPlayAdId ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetPlayAdId()");
			#endif
		}

		public static string GetModelName ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetModelName()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetModelName ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetModelName ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetModelName()");
			#endif
		}

		public static string GetManufacturer ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetManufacturer()");
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetManufacturer ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetManufacturer()");
			#endif
		}

		public static string GetSystemName ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetSystemName()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetSystemName ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetSystemName ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetSystemName()");
			#endif
		}

		public static string GetSystemVersion ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetSystemVersion()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetSystemVersion ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetSystemVersion ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetSystemVersion()");
			#endif
		}

		public static string GetAndroidApiLevel ()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetAndroidApiLevel()");
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetAndroidApiLevel ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetAndroidApiLevel()");
			#endif
		}

		public static string GetAppName()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetAppName()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetAppName ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetAppName ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetAppName()");
			#endif
		}

		public static string GetAppVersion()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetAppVersion()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetAppVersion ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetAppVersion ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetAppVersion()");
			#endif
		}

		public static string GetAppLanguage()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetAppLanguage()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetAppLanguage ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetAppLanguage ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetAppLanguage()");
			#endif
		}

		public static string GetNetworkCarrierName()
		{
			#if UNITY_EDITOR
			return string.Format (CALLING_IN_UNITY_EDITOR, "GetNetworkCarrierName()");
			#elif UNITY_IOS
			return DeviceUtilsiOS.GetNetworkCarrierName ();
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.GetNetworkCarrierName ();
			#else
			return string.Format (UNSUPPORTED_PLATFORM, "GetNetworkCarrierName()");
			#endif
		}

		public static bool SetScreenBrightness(int brightness)
		{
			#if UNITY_EDITOR
			Debug.LogFormat (CALLING_IN_UNITY_EDITOR, "SetScreenBrightness()");
			return false;
			#elif UNITY_IOS
			return DeviceUtilsiOS.SetScreenBrightness (brightness);
			#elif UNITY_ANDROID
			return DeviceUtilsAndroid.SetScreenBrightness (brightness);
			#else
			Debug.LogFormat (CALLING_IN_UNITY_EDITOR, "SetScreenBrightness()");
			return false;
			#endif
		}
	}

}