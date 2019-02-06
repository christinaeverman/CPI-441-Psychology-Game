using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadRoom1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider coll)
	{
		if(coll.gameObject.tag == "MainCamera")
			Application.LoadLevel("Psychoanalytic Level");
	}
}
