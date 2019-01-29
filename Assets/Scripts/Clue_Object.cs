using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue_Object : MonoBehaviour
{
    /*
		seen is what keep tracks if the clue has been been detected by the ray cast emitted by the player
	 */
    public bool Seen = false;
    /*org(orginal) stores its actual texture for when
	it needs to change back while my is the current texture that is 
	currently on the object itself
	*/
    Material org_material, my_material;

    // Use this for initialization
    void Start()
    {
        org_material = GetComponent<Renderer>().material;
        my_material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if it is seen or not if it is it changes color other wise it resetss
        if (Seen == true)
        {
            my_material.color = Color.yellow;
        }
        else {
            my_material.color = Color.gray;
        }
        Debug.Log(Seen);
    }
}
