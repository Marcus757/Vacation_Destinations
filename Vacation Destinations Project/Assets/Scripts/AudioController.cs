using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour {
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public int secondsDelay;

    private IDictionary<string, AudioClip> buttonSceneMap = new Dictionary<string, AudioClip>();
    
    public void Start()
    {
        buttonSceneMap.Add("AthensButton", audioClip1);
        buttonSceneMap.Add("PlayaDelCarmenButton", audioClip2);
        buttonSceneMap.Add("SienaButton", audioClip3);
    }

    public void OnButtonClick(Button button)
    {
        StartCoroutine(PlayAudio(button));
    }


    IEnumerator PlayAudio(Button button)
    {
        yield return new WaitForSeconds(secondsDelay);
        AudioSource audioSource = GetComponent<AudioSource>();
        AudioClip audioClip = null;

        if (buttonSceneMap.TryGetValue(button.name, out audioClip))
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
