using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class correctAnswer2 : MonoBehaviour
{

	// Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("correctQuiz3", 0);
    }


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Suite103"))
		{


			PlayerPrefs.SetInt("correctQuiz3", 1);

		}

	}
}