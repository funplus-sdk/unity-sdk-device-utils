using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.XCodeEditor;
#endif
using System.IO;

public static class XCodePostProcess
{

#if UNITY_EDITOR
	[PostProcessBuild(999)]
	public static void OnPostProcessBuild( BuildTarget target, string pathToBuiltProject )
	{
		if (target != BuildTarget.iOS) {
			// Debug.LogWarning("Target is not iPhone. XCodePostProcess will not run");
			return;
		}

		string sentinel = Path.Combine (pathToBuiltProject, ".funplus");

		if (File.Exists (sentinel))
		{
			// Build in append mode.
			Debug.Log ("Build in append mode, will not modify the project");
			return;
		}

		// Create a new project object from build target
		XCProject project = new XCProject( pathToBuiltProject );

		string file = Path.Combine(Application.dataPath, "FunPlus/DeviceUtils/Editor/XUPorter/Mods/DeviceUtils.projmods");
		UnityEngine.Debug.Log("ProjMod File: "+file);
		project.ApplyMod( file );

		//TODO implement generic settings as a module option
		//project.overwriteBuildSetting("CODE_SIGN_IDENTITY[sdk=iphoneos*]", "iPhone Distribution", "Release");
		
		// Finally save the xcode project
		project.Save();

		// Create the sentinel file.
		File.WriteAllText (sentinel, "sentinel");
	}
#endif

	public static void Log(string message)
	{
		UnityEngine.Debug.Log("PostProcess: "+message);
	}
}
