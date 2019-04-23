using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctAnswer5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        int count = PlayerPrefs.GetInt("AnswersMoved", 0);
        count++;
        PlayerPrefs.SetInt("AnswersMoved", count);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        int count = PlayerPrefs.GetInt("AnswersMoved", 0);
        count--;
        PlayerPrefs.SetInt("AnswersMoved", count);
    }
}
