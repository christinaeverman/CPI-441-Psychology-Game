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
    private float raycastLength = 3;
    private Clue_Object CurrentClueObj;

    public GameObject ePanel;

    Quaternion originalPos;

    void Start()
    {
        //player = this.transform.parent.gameObject;
        originalPos = transform.localRotation;

    }
    // Update is called once per frame
    void Update()
    {
        // This controls the players rotation of the camera
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));// md = Mouse Direction
        
        md = Vector2.Scale(md, new Vector2(sensitivityX * smoothing, sensitivityY * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        Quaternion xQuaternion = Quaternion.AngleAxis(mouseLook.x, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(mouseLook.y, Vector3.left);
        transform.localRotation = originalPos * xQuaternion * yQuaternion;

        //player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
        
        // This determines the ray casting #endregion
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, raycastLength))
        {
            Debug.Log(hit.collider.name);
            if (hit.collider.tag == "TagClue")
            {
                //Debug.Log("detected clue");
                CurrentClueObj = hit.collider.gameObject.GetComponent<Clue_Object>();
                CurrentClueObj.Seen = true;
                ePanel.gameObject.SetActive(true);
            }
            
            else {
                CurrentClueObj.Seen = false;
                Debug.Log("false");
                ePanel.gameObject.SetActive(false);
            }
        }
        Debug.DrawRay(ray.origin, ray.direction * raycastLength, Color.cyan);
    }
}
