using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_MouseLook : MonoBehaviour
{
    /*
	This class is attached to the player camera
	and is responsible for the rotation of the camera and
	the players ability to move the mouse and have the camera 
	rotate
	 */

    // Use this for initialization
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivityX = 0.7f;
    public float sensitivityY = 5.0f;
    private float smoothing = 2.0f;
    //GameObject player;

    public float minY = -75f;
    public float maxY = 75f;

    float rotationX = 0f;
    float rotationY = 0f;

    RaycastHit hit;
    //public GameObject Target;
    private float raycastLength = 2.9f;
    private Clue_Object CurrentClueObj;
    private Quaternion prevRotation;

    public GameObject ePanel;
    public GameObject menuPanel;
    public GameObject[] menuButtons;

    Quaternion originalPos;

    // audio
    AudioSource source;
    public AudioClip pickupPaper1;
    public AudioClip pickupPaper2;

    bool menuOpen = false;

    int selectPaperPickup;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        originalPos = transform.localRotation;
        source = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape") && !menuOpen)
        {
            menuOpen = true;
            menuPanel.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            for (int i = 0; i < 3; i++)
                menuButtons[i].gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown("escape") && menuOpen)
        {
            menuOpen = false;
            menuPanel.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            for (int i = 0; i < 3; i++)
                menuButtons[i].gameObject.SetActive(false);
        }

        if (!menuOpen)
            mouseMovement();
    }

    void mouseMovement()
    {
        // random number generator to select sounds
        selectPaperPickup = Random.Range(1, 3);

        // This controls the players rotation of the camera
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));// md = Mouse Direction

        Quaternion yQuaternion = prevRotation;
        md = Vector2.Scale(md, new Vector2(sensitivityX * smoothing, sensitivityY * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        Quaternion xQuaternion = Quaternion.AngleAxis(mouseLook.x, Vector3.up);

        if (mouseLook.y < 30 && mouseLook.y > -70)
            yQuaternion = Quaternion.AngleAxis(mouseLook.y, Vector3.left);

        transform.localRotation = originalPos * xQuaternion * yQuaternion;
        prevRotation = yQuaternion;

        // This determines the ray casting #endregion
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, raycastLength))
        {
            if (hit.collider.tag == "TagClue")
            {
                CurrentClueObj = hit.collider.gameObject.GetComponent<Clue_Object>();
                CurrentClueObj.Seen = true;

                if (Input.GetKey("e"))
                {
                    switch (selectPaperPickup)
                    {
                        case 1:
                            source.PlayOneShot(pickupPaper1, 1f);
                            break;
                        case 2:
                            source.PlayOneShot(pickupPaper2, 1f);
                            break;
                        default:
                            break;
                    }

                    //Debug.Log("Storing clue in inventory");
                    CurrentClueObj.descriptionPanel.SetActive(false);
                    
                    foreach (Transform child in CurrentClueObj.transform)
                    {
                        child.gameObject.SetActive(false);
                    }

                    CurrentClueObj.gameObject.SetActive(false);

                    CurrentClueObj.Found = true;
                    CurrentClueObj.transform.parent.gameObject.SetActive(false);
                    Debug.Log(selectPaperPickup);
                }

                if (CurrentClueObj.Found == false)
                    ePanel.gameObject.SetActive(true);
            }

            else
            {
                CurrentClueObj.Seen = false;
                ePanel.gameObject.SetActive(false);
            }
        }
        Debug.DrawRay(ray.origin, ray.direction * raycastLength, Color.cyan);
    }
}
