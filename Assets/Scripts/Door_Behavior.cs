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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, raycastLength))
        {
            if (hit.collider.tag == "Door")
            {
                distance = Vector3.Distance(player.transform.position, transform.position);

                if (distance < 3f && LevelManager.FoundAll)
                {
                    exitPanel.gameObject.SetActive(true);

                    if (Input.GetKey("e"))
                    {
                        transform.localPosition += rotatePosition;
                        transform.Rotate(Vector3.down * 10);
                        SceneManager.LoadScene("Hub", LoadSceneMode.Single);
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

    /*
    void OnMouseDown()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < 3f && LevelManager.FoundAll)
        {
            transform.localPosition += new Vector3(0, 0, -0.2f);
            transform.Rotate(Vector3.up * -160);
            SceneManager.LoadScene("Hub", LoadSceneMode.Single);
        }
        else if (distance < 3f && !LevelManager.FoundAll)
        {
            panel.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
        }
    }
    */
}
