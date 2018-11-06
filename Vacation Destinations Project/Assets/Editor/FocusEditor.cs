using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Focus))]
public class FocusEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Focus focus = (Focus)target;
        EditorGUILayout.LabelField("Image Animation", EditorStyles.boldLabel);
        focus.imageAnimation = (Focus.ImageAnimationType)EditorGUILayout.EnumPopup("Image Animation Type", focus.imageAnimation);

        switch (focus.imageAnimation)
        {
            case Focus.ImageAnimationType.Single:        
                break;
            case Focus.ImageAnimationType.Animated:        
                focus.imageStartLocation = EditorGUILayout.Vector3Field("Image Start Location", focus.imageStartLocation);
                focus.imageEndLocation = EditorGUILayout.Vector3Field("Image End Location", focus.imageEndLocation);
                focus.imageAnimationCurve = EditorGUILayout.CurveField("Image Animation Curve", focus.imageAnimationCurve);
                break;
            default:
                break;
        }

        EditorGUILayout.LabelField("Text Animation", EditorStyles.boldLabel);
        focus.textAnimation = (Focus.TextAnimationType)EditorGUILayout.EnumPopup("Text Animation Type", focus.textAnimation);

        switch (focus.textAnimation)
        {
            case Focus.TextAnimationType.Single:
                break;
            case Focus.TextAnimationType.Animated:
                focus.textStartLocation = EditorGUILayout.Vector3Field("Text Start Location", focus.textStartLocation);
                focus.textEndLocation = EditorGUILayout.Vector3Field("Text End Location", focus.textEndLocation);
                focus.textAnimationCurve = EditorGUILayout.CurveField("Text Animation Curve", focus.textAnimationCurve);
                break;
            default:
                break;
        }
    }
}
