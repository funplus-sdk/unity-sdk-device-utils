using UnityEditor;
using UnityEngine;
using System.Collections;
using System.IO;
using FunPlus.DeviceUtils;

public class DeviceUtilsConsoleEndpoint
{
	private const string FunPlusPath = "Assets/FunPlus/";

	public static void ExportPackage()
	{
		Debug.Log("Exporting Device Utils SDK Unity Package...");
		string path = OutputPath;
		Debug.Log ("XXXXX " + path);

		try
		{
			string[] files = (string[])Directory.GetFiles(FunPlusPath, "*.*", SearchOption.AllDirectories);

			AssetDatabase.ExportPackage(
				files,
				path,
				ExportPackageOptions.IncludeDependencies | ExportPackageOptions.Recurse);
		}
		finally
		{
			
		}

		Debug.Log("Finished exporting!");
	}

	private static string OutputPath
	{
		get
		{
			string projectRoot = Directory.GetCurrentDirectory();
			var outputDirectory = new DirectoryInfo(Path.Combine(projectRoot, "Release"));

			// Create the directory if it doesn't exist
			outputDirectory.Create();

			string packageName = string.Format("funplus-unity-sdk-device-utils-{0}.unitypackage", DeviceUtils.VERSION);
			return Path.Combine(outputDirectory.FullName, packageName);
		}
	}
}