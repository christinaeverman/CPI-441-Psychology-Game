using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Movement : MonoBehaviour
{
    public float speed = 0.1f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            transform.localPosition += Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up) * speed;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            transform.localPosition -= Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up) * speed;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.localPosition -= Vector3.ProjectOnPlane(Camera.main.transform.right, Vector3.up) * speed;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.localPosition += Vector3.ProjectOnPlane(Camera.main.transform.right, Vector3.up) * speed;
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)
            && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow)
            && !Input.GetKey(KeyCode.RightArrow))
            rb.velocity = Vector3.zero;
    }
}