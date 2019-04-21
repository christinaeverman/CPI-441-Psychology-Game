using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Behavior : MonoBehaviour
{
    public GameObject player;
    public GameObject exitPanel;
    public GameObject moreCluesPanel;
    private float distance;
    RaycastHit hit;
    private float raycastLength = 3;
    public Vector3 rotatePosition;
    bool exit = false;

    // Audio
    AudioSource source;
    public AudioClip doorSound;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, raycastLength) && PlayerPrefs.GetInt("menuOpened", 0) == 0)
        {
            if (hit.collider.tag == "Door")
            {
                distance = Vector3.Distance(player.transform.position, transform.position);

                if (distance < 3f && LevelManager.FoundAll)
                {
                    exitPanel.gameObject.SetActive(true);

                    if (Input.GetKey("e") && !exit)
                    {
                        source.PlayOneShot(doorSound, 0.3f);
                        transform.localPosition += rotatePosition;
                        transform.Rotate(Vector3.down * 10);
                        StartCoroutine("Wait");
                        exit = true;
                    }
                }
                else if (distance < 3f && !LevelManager.FoundAll)
                {
                    moreCluesPanel.gameObject.SetActive(true);
                }
            }
            else
            {
                moreCluesPanel.gameObject.SetActive(false);
                exitPanel.gameObject.SetActive(false);
            }
        }
    }

    // for coroutine
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(34f * Time.deltaTime);
        SceneManager.LoadScene("Hub", LoadSceneMode.Single);
    }
}