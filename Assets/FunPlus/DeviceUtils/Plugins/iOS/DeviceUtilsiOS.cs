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
		private static extern void _setScreenBrightness (float brightness);


		public static string getIdentifierForVendor ()
		{
			return _getIdentifierForVendor ();
		}

		public static string getAdvertisingIdentifier ()
		{
			return _getAdvertisingIdentifier ();
		}

		public static string getModelName ()
		{
			return _getModelName ();
		}

		public static string getSystemName ()
		{
			return _getSystemName ();
		}

		public static string getSystemVersion ()
		{
			return _getSystemVersion ();
		}

		public static string getAppName ()
		{
			return _getAppName ();
		}

		public static string getAppVersion ()
		{
			return _getAppVersion ();
		}

		public static string getAppLanguage ()
		{
			return _getAppLanguage ();
		}

		public static bool setScreenBrightness (float brightness)
		{
			return _setScreenBrightness (brightness);
		}
	}

}

#endif