using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour {
    public float animationTime;

    public void Start()
    {
        StartCoroutine(FadeScene());
    }

    public IEnumerator FadeScene()
    {
        float currentTime = 0;
        float normTime = 0;
        CanvasGroup canvasGroup = GameObject.FindObjectOfType<CanvasGroup>();

        while (currentTime <= animationTime)
        {
            currentTime += Time.deltaTime;
            normTime = currentTime / animationTime;
            Color color = GetComponent<Renderer>().material.color;
            canvasGroup.alpha = Mathf.Lerp(0.0f, 1.0f, normTime);
            yield return null;
        }
    }
}
