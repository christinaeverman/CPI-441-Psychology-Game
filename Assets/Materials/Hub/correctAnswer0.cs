using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class correctAnswer0 : MonoBehaviour
{
	
	// Start is called before the first frame update

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Suite101"))
		{


			PlayerPrefs.SetInt("correctQuiz1", 1);

		}

	}
}