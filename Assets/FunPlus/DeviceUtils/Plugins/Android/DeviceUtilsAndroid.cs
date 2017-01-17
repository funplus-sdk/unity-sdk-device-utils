#if UNITY_ANDROID
using UnityEngine;
using System;
using System.Collections;

namespace FunPlus.DeviceUtils
{

	public class DeviceUtilsAndroid
	{

		private static T ResolveAndCallApi<T> (string api, object[] args = null)
		{
			AndroidJavaClass bridgeClass = new AndroidJavaClass ("com.funplus.sdk.device.DeviceUtilsUnityBridge");
			if (args != null)
			{
				return bridgeClass.CallStatic<T> (api, args);
			}
			else
			{
				return bridgeClass.CallStatic<T> (api);
			}
		}

		private static AndroidJavaObject AndroidApplication {
			get
			{
				AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
				AndroidJavaObject activity = jc.GetStatic<AndroidJavaObject> ("currentActivity");
				AndroidJavaObject application = activity.Call<AndroidJavaObject> ("getApplication");
				return application;
			}
		}
		
		public static string GetAndroidId ()
		{
			return ResolveAndCallApi<string> ("getAndroidId", new object[] { AndroidApplication });
		}

		public static string GetPlayAdId ()
		{
			return ResolveAndCallApi<string> ("getPlayAdId", new object[] { AndroidApplication });
		}

		public static string GetModelName ()
		{
			return ResolveAndCallApi<string> ("getModelName");
		}

		public static string GetManufacturer ()
		{
			return ResolveAndCallApi<string> ("getManufacturer");
		}

		public static string GetSystemName ()
		{
			return ResolveAndCallApi<string> ("getSystemName");
		}

		public static string GetSystemVersion ()
		{
			return ResolveAndCallApi<string> ("getSystemVersion");
		}

		public static string GetAndroidApiLevel ()
		{
			return ResolveAndCallApi<string> ("getApiLevel");
		}

		public static string GetAppName ()
		{
			return ResolveAndCallApi<string> ("getAppName", new object[] { AndroidApplication });
		}

		public static string GetAppVersion ()
		{
			return ResolveAndCallApi<string> ("getAppVersion", new object[] { AndroidApplication });
		}

		public static string GetAppLanguage ()
		{
			return ResolveAndCallApi<string> ("getAppLanguage");
		}

		public static string GetNetworkCarrierName ()
		{
			return ResolveAndCallApi<string> ("getNetworkCarrierName", new object[] { AndroidApplication });
		}

		public static bool SetScreenBrightness (int brightness)
		{
			return ResolveAndCallApi<bool> ("setScreenBrightness", new object[] { AndroidApplication, brightness });
		}
	}

}

#endif