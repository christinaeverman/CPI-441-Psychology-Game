using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public bool menuOpened;

    // Start is called before the first frame update
    void Start()
    {
        menuOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowObject(GameObject obj)
    {
        obj.gameObject.SetActive(true);
    }

    public void HideObject(GameObject obj)
    {
        obj.gameObject.SetActive(false);
    }

    public void LoadMainMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
