using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class correctAnswer4 : MonoBehaviour
{

	// Start is called before the first frame update

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Suite105"))
		{


			PlayerPrefs.SetInt("correctQuiz5", 1);

		}

	}
}