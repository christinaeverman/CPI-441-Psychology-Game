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
    /*org(orginal) stores its actual texture for when
	it needs to change back while my is the current texture that is 
	currently on the object itself
	*/
    Material org_material, my_material;
    List<Renderer> renderers = new List<Renderer>();
    public GameObject descriptionPanel;

    // Use this for initialization
    void Start()
    {
        //org_material = GetComponent<Renderer>().material;
        //my_material = GetComponent<Renderer>().material;

        foreach (Renderer renderer in GetComponentsInChildren<Renderer>())
        {
            renderers.Add(renderer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // highlights clue if close and hovering over it
        if (Seen && !Found)
        {
            //my_material.color = Color.yellow;

            //my_material.SetColor("_EMISSION", new Color(0.0927f, 0.4852f, 0.2416f, 0.42f));
            //my_material.EnableKeyword("_EMISSION");

            foreach (Renderer renderer in GetComponentsInChildren<Renderer>())
            {
                foreach (Material material in renderer.materials)
                {
                    //material.color = Color.yellow;
                    float intensity = 0.5f;
                    Color color = Color.yellow * intensity;
                    material.SetColor("_EmissionColor", color);
                    material.EnableKeyword("_EMISSION");
                }

                //renderer.material.color = Color.yellow;
            }

            descriptionPanel.SetActive(true);
        }
        // if the player does not click on the clue and hovers away from it, then it has not been found yet
        else if (!Found)
        {
            int count = 0;
            //my_material.color = Color.white;
            foreach (Renderer renderer in GetComponentsInChildren<Renderer>())
            {
                //Color originalColor = materials[count].color;
                //Material currentMaterial = renderer.material;
                //currentMaterial.color = originalColor;

                foreach (Material material in renderer.materials)
                {
                    //material.color = Color.white;
                    material.DisableKeyword("_EMISSION");
                }

                //renderer.material.color = Color.white;

                count++;
            }

            descriptionPanel.SetActive(false);
        }
    }
}
