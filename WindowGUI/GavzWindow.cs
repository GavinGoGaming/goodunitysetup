/*

Dont Edit unless you know what your doing!

*/

using UnityEditor;
using System;
using System.Diagnostics;
using UnityEngine;

public class GavzWindow : EditorWindow
{
    [MenuItem("Window/GavinGoGaming/Unity Helpful Tools/Contact")]
    public static void ShowWindow ()
    {
        GetWindow<GavzWindow>("Contact");
    }

    void OnGUI ()
    {
        //code.ForWindow(SHOW)
        GUILayout.Label("Contact Creator!", EditorStyles.boldLabel);
        if (GUILayout.Button("Contact"))
        {
            Process.Start("https://discord.gg/ZeHXydw");
        }
    }
}
