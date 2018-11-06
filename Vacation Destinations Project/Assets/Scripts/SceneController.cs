using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {
    public Texture menuTexture;
    public Texture location1;
    public Texture location2;
    public Texture location3;
    public int secondsDelay;

    private IDictionary<string, Texture> buttonSceneMap = new Dictionary<string, Texture>();

    public void Start()
    {
        buttonSceneMap.Add("AthensButton", location1);
        buttonSceneMap.Add("PlayaDelCarmenButton", location2);
        buttonSceneMap.Add("SienaButton", location3);
    }

    public void OnButtonClick(Button button)
    {
        StartCoroutine(ChangeTexture(button));
    }

    IEnumerator ChangeTexture(Button button)
    {
        //yield return FadeOut
        //changetexture
        //yield return FadeIN
        yield return new WaitForSeconds(secondsDelay);

        Texture texture = null;

        if (buttonSceneMap.TryGetValue(button.name, out texture))
            GetComponent<Renderer>().material.mainTexture = texture;
    }
}
