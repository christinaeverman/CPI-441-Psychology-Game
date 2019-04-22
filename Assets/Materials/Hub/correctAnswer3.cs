using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class correctAnswer3 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("correctQuiz4", 0);
    }

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Suite104"))
		{


			PlayerPrefs.SetInt("correctQuiz4", 1);

		}

	}
}