using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    // audio
    AudioSource source;
    public AudioClip footstep1;
    public AudioClip footstep2;
    public AudioClip footstep3;
    public AudioClip footstep4;

    int selectFootstepSound;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 1.0f;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.5f * speed;
        selectFootstepSound = Random.Range(1, 5);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
        
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
            
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) ||
            Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) && timer >= 1)
        {
            switch(selectFootstepSound)
            {
                case 1:
                    source.PlayOneShot(footstep1, 1f);
                    break;
                case 2:
                    source.PlayOneShot(footstep2, 1f);
                    break;
                case 3:
                    source.PlayOneShot(footstep3, 1f);
                    break;
                case 4:
                    source.PlayOneShot(footstep4, 1f);
                    break;
                default:
                    Debug.Log("Error in footstep sound");
                    break;
            }

            timer = 0.0f;
        }
    }
}