using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class correctAnswer4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("correctQuiz5", 0);
    }

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Suite105"))
		{
			PlayerPrefs.SetInt("correctQuiz5", 1);
		}
        else if (other.CompareTag("Suite101") || other.CompareTag("Suite102") ||
            other.CompareTag("Suite103") || other.CompareTag("Suite104"))
        {
            PlayerPrefs.SetInt("correctQuiz5", 2);
        }

        int count = PlayerPrefs.GetInt("AnswersMoved", 0);
        count++;
        PlayerPrefs.SetInt("AnswersMoved", count);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Suite101") || other.CompareTag("Suite102") ||
            other.CompareTag("Suite103") || other.CompareTag("Suite104") ||
            other.CompareTag("Suite105"))
        {
            PlayerPrefs.SetInt("correctQuiz5", 0);
        }

        int count = PlayerPrefs.GetInt("AnswersMoved", 0);
        count--;
        PlayerPrefs.SetInt("AnswersMoved", count);
    }
}