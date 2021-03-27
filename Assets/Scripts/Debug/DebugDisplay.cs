using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DebugHelper
{
    public class DebugDisplay : MonoBehaviour
    {

#if !UNITY_EDITOR

        static string myLog = "";
        private string output = "";
        private string stack = "";

        void OnEnable()
        {
            Application.logMessageReceived += HandleLog;
        }

        void OnDisable()
        {
            Application.logMessageReceived -= HandleLog;
        }

        void HandleLog(string logString, string stackTrace, LogType type)
        {
            output = logString;
            stack = stackTrace;
            myLog = output + "\n" + myLog;

            // cut it shorter if length is too big
            if (myLog.Length > 5000)
            {
                myLog = myLog.Substring(0, 4000);
            }
        }

        void OnGUI()
        {
            {
                myLog = GUI.TextArea(new Rect(10, 10, Screen.width - 10, Screen.height - 10), myLog);
            }


        }


#endif
    }

}

