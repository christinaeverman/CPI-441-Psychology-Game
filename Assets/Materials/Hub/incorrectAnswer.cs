using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class incorrectAnswer : MonoBehaviour
{
	[SerializeField] private Image customImage;
    [SerializeField] private Text customText;
    // Start is called before the first frame update
    void  Update()
	{
		if((PlayerPrefs.GetInt("correctQuiz1", 0) != 1 || PlayerPrefs.GetInt("correctQuiz2", 0) != 1 ||
            PlayerPrefs.GetInt("correctQuiz3", 0) != 1 || PlayerPrefs.GetInt("correctQuiz4", 0) != 1 ||
            PlayerPrefs.GetInt("correctQuiz5", 0) != 1) && PlayerPrefs.GetInt("AnswersMoved", 0) == 5)
		{
			customImage.enabled = true;
            customText.enabled = true;
		}

        if (PlayerPrefs.GetInt("AnswersMoved", 0) < 5)
        {
            customImage.enabled = false;
            customText.enabled = false;
        }
	}
}
