using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CustomEditor(typeof(FocusController))]
public class FocusControllerEditor : Editor
{
	public override void OnInspectorGUI()
    {
        FocusController fc = (FocusController)target;
        
        try
        {
            fc.canvas = EditorGUILayout.ObjectField(fc.canvas, typeof(Canvas), true) as Canvas ;
            fc.focusesCount = EditorGUILayout.IntField("Focus Count", fc.focusesCount);

            for (int i = 0; i < fc.focusesCount; i++)
            {
                Focus focus = new Focus();
                fc.focuses.Add(focus);
            }

            if (fc.focusesCount > 0)
            {
                for (int i = 0; i < fc.focusesCount; i++)
                {
                    fc.focuses[i] =
                        EditorGUILayout.ObjectField("Focus" + i.ToString(), fc.focuses[i], typeof(Focus), true) as Focus;
                }
            }
            
            if (GUI.changed)
            {
                EditorUtility.SetDirty(fc);
            }
        }
        
        catch(Exception ex)
        {

        }
    }
}
