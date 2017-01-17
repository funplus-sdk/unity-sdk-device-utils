using UnityEngine;
using System.Collections;
using FunPlus.DeviceUtils;

public class UIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.LogFormat ("IDFV: {0}", DeviceUtils.GetIdentifierForVendor ());
		Debug.LogFormat ("IDFA: {0}", DeviceUtils.GetAdvertisingIdentifier ());
		Debug.LogFormat ("Android ID: {0}", DeviceUtils.GetAndroidId ());
		Debug.LogFormat ("Play AD ID: {0}", DeviceUtils.GetPlayAdId ());
		Debug.LogFormat ("Model name: {0}", DeviceUtils.GetModelName ());
		Debug.LogFormat ("Manufacturer: {0}", DeviceUtils.GetManufacturer ());
		Debug.LogFormat ("System name: {0}", DeviceUtils.GetSystemName ());
		Debug.LogFormat ("System version: {0}", DeviceUtils.GetSystemVersion ());
		Debug.LogFormat ("Android API level: {0}", DeviceUtils.GetAndroidApiLevel ());
		Debug.LogFormat ("App name: {0}", DeviceUtils.GetAppName ());
		Debug.LogFormat ("App version: {0}", DeviceUtils.GetAppVersion ());
		Debug.LogFormat ("App language: {0}", DeviceUtils.GetAppLanguage ());
		Debug.LogFormat ("Network carrier: {0}", DeviceUtils.GetNetworkCarrierName ());

		int brightness = 20;
		bool isSuccess = DeviceUtils.SetScreenBrightness (brightness);
		Debug.LogFormat ("Set screen brightness: {0}", isSuccess ? "true" : "false");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
