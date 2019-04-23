using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadRoom : MonoBehaviour
{
    public string roomName;
    public string cluesFoundIn;

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
        if (coll.gameObject.tag == "Player" && PlayerPrefs.GetInt(cluesFoundIn, 0) != 1)
            Application.LoadLevel(roomName);
    }
}
