using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue_Object : MonoBehaviour
{
    /*
		seen is what keep tracks if the clue has been been detected by the ray cast emitted by the player
	 */
    public bool Seen = false;
    public bool Found = false;
    //public static GameObject ePanel;
    /*org(orginal) stores its actual texture for when
	it needs to change back while my is the current texture that is 
	currently on the object itself
	*/
    Material org_material, my_material;
    public GameObject descriptionPanel;

    //List<Renderer> rendererList = new List<Renderer>();
    //List<Material> materialList = new List<Material>();
    //GameObject container;

    // Use this for initialization
    void Start()
    {
        /*
        foreach (Renderer renderer in container.GetComponentsInChildren<Renderer>())
        {
            materialList.Add(renderer.material);
        }
        */

        //ePanel = GameObject.Find("Press E Panel");
        org_material = GetComponent<Renderer>().material;
        my_material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // highlights clue if close and hovering over it
        if (Seen && !Found)
        {
            my_material.color = Color.yellow;
            descriptionPanel.SetActive(true);

            /*
            foreach (Material material in materialList)
            {
                material.color = Color.yellow;
            }
            */
            
        }
        // if the player does not click on the clue and hovers away from it, then it has not been found yet
        else if (!Found)
        {
            my_material.color = Color.white;
            descriptionPanel.SetActive(false);
        }

    }
    
    /*
    void OnMouseDown()
    {
        // clue is added to the inventory
        if (Seen == true)
        {
            Found = true;
            my_material.color = Color.red;
        }
    }
    */
}
