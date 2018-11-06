using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoGazeClicker : MonoBehaviour {
    public Transform radialProgress;
    public float timer;
    private float totalTime = 0f;
    private bool enableAutoClick;
    private Button button;

    // Use this for initialization
    void Start () {
        enableAutoClick = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (enableAutoClick.Equals(false))
            return;

        totalTime += Time.deltaTime;

        radialProgress.GetComponent<Image>().fillAmount = totalTime / timer;
        //Debug.Log("Time: " + totalTime);
        if (totalTime > timer)
        {
            button.onClick.Invoke();
            Reset();
            DisableAutoClick();
        }
    }

    public void EnableAutoClick(Button _button)
    {
        enableAutoClick = true;
        button = _button;
    }

    public void DisableAutoClick()
    {
        enableAutoClick = false;
        button = null;
    }

    public void Reset()
    {
        totalTime = 0f;
        radialProgress.GetComponent<Image>().fillAmount = totalTime;
    }
}
