using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Controller : MonoBehaviour
{

    /*
	This class controls the movement of the player
	and is attached to the capsuale of the player but 
	does NOT control the mouse looking movement
	
	 */
    private float speed = 5.0f;
    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;


        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
