using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Audio
    AudioSource source;
    public AudioClip buttonSound;

    private IEnumerator waitCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        source = GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("mouseSensitivity", 0.8f);

        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        source.PlayOneShot(buttonSound, 0.4f);
        waitCoroutine = Wait(sceneName);
        StartCoroutine(waitCoroutine);
    }

    IEnumerator Wait(string sceneName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
