using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CentennialSceneController : MonoBehaviour {
    public AudioClip audioClip;

	void Start () {
        StartCoroutine(PlayIntro());
	}

    IEnumerator PlayIntro()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        SceneManager.LoadScene("VacationDestinations");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
