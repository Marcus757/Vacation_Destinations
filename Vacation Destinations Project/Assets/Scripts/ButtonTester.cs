using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTester : MonoBehaviour {
    public SceneFader sceneFader;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "Scene Fader"))
        {
            sceneFader.OnButtonClick();
        }
    }
}
