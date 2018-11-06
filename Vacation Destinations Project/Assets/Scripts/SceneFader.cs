using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFader : MonoBehaviour {
    public Transform item;

    public void OnButtonClick()
    {
        StartCoroutine(FadeScene(item));
    }

    public IEnumerator FadeScene(Transform item)
    {
        float animationTime = 2;
        float currentTime = 0;
        float normTime = 0;

        while (currentTime <= animationTime)
        {
            currentTime += Time.deltaTime;
            normTime = currentTime / animationTime;
            Color color = item.GetComponent<Renderer>().material.color;
            item.GetComponent<Renderer>().material.color = Color.Lerp(color, Color.black, normTime);
            yield return null;
        }

        animationTime = 2;
        currentTime = 0;
        normTime = 0;

        while (currentTime <= animationTime)
        {
            currentTime += Time.deltaTime;
            normTime = currentTime / animationTime;
            Color color = item.GetComponent<Renderer>().material.color;
            item.GetComponent<Renderer>().material.color = Color.Lerp(color, Color.white, normTime);
            yield return null;
        }
    }
}
