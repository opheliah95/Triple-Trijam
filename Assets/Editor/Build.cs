using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.Build.Reporting;
using Debug = UnityEngine.Debug;

namespace Build
{
    public class Build : MonoBehaviour
    {
        public static void BuildGameWithVersion(BuildTarget target, string folderName)
        {
            // Get filename.
            string path = EditorUtility.SaveFolderPanel("Choose Location of Built Game", "Build", folderName);
            string[] levels = GetScene();
            // Build player.
            BuildReport report = BuildPipeline.BuildPlayer(levels, path, target, BuildOptions.None);

            // check if build is successful or not
            BuildSummary summary = report.summary;

            if (summary.result == BuildResult.Succeeded)
            {
                Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
            }

            if (summary.result == BuildResult.Failed)
            {
                Debug.Log("Build failed");
            }

        }

        // build windows version
        [MenuItem("Build/Build Windows 64")]
        static void BuildWindows64()
        {
            BuildGameWithVersion(BuildTarget.StandaloneWindows64, "Win64");

        }

        // build linux version
        [MenuItem("Build/Build Linux")]
        static void BuildLinux()
        {
            BuildGameWithVersion(BuildTarget.StandaloneLinux64, "Linux");

        }

        // build webgl version
        [MenuItem("Build/Build WebGL")]
        static void BuildWebGL()
        {
            BuildGameWithVersion(BuildTarget.WebGL, "WebGL");

        }



        // a function for accessing scenes
        // TODO: refactor with Linq
        static string[] GetScene()
        {
            List<string> scenes = new List<string>();
            foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
            {
                if (scene.enabled)
                {
                    Debug.Log(scene.path);
                    scenes.Add(scene.path);
                }
            }

            return scenes.ToArray();
        }


    }

}




