#if UNITY_IPHONE
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Collections;

namespace FunPlus.DeviceUtils
{

	public class DeviceUtilsiOS
	{

		[DllImport ("__Internal")]
		private static extern string _getIdentifierForVendor ();

		[DllImport ("__Internal")]
		private static extern string _getAdvertisingIdentifier ();

		[DllImport ("__Internal")]
		private static extern string _getModelName ();

		[DllImport ("__Internal")]
		private static extern string _getSystemName ();

		[DllImport ("__Internal")]
		private static extern string _getSystemVersion ();

		[DllImport ("__Internal")]
		private static extern string _getAppName ();

		[DllImport ("__Internal")]
		private static extern string _getAppVersion ();

		[DllImport ("__Internal")]
		private static extern string _getAppLanguage ();

		[DllImport ("__Internal")]
		private static extern string _getNetworkCarrierName ();

		[DllImport ("__Internal")]
		private static extern int _getScreenBrightness ();

		[DllImport ("__Internal")]
		private static extern bool _setScreenBrightness (int brightness);


		public static string GetIdentifierForVendor ()
		{
			return _getIdentifierForVendor ();
		}

		public static string GetAdvertisingIdentifier ()
		{
			return _getAdvertisingIdentifier ();
		}

		public static string GetModelName ()
		{
			return _getModelName ();
		}

		public static string GetSystemName ()
		{
			return _getSystemName ();
		}

		public static string GetSystemVersion ()
		{
			return _getSystemVersion ();
		}

		public static string GetAppName ()
		{
			return _getAppName ();
		}

		public static string GetAppVersion ()
		{
			return _getAppVersion ();
		}

		public static string GetAppLanguage ()
		{
			return _getAppLanguage ();
		}

		public static string GetNetworkCarrierName ()
		{
			return _getNetworkCarrierName ();
		}

		public static int GetScreenBrightness ()
		{
			return _getScreenBrightness ();
		}

		public static bool SetScreenBrightness (int brightness)
		{
			return _setScreenBrightness (brightness);
		}
	}

}

#endif