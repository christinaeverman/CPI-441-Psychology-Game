using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showPanel : MonoBehaviour
{
	[SerializeField] private Image customImage;


	void Update()
	{
		if(PlayerPrefs.GetInt("correctQuiz1", 0) == 1  && PlayerPrefs.GetInt("correctQuiz2", 0) == 1
			&& PlayerPrefs.GetInt("correctQuiz3", 0) == 1 && PlayerPrefs.GetInt("correctQuiz4", 0) == 1
			&& PlayerPrefs.GetInt("correctQuiz5", 0) == 1)
		{
			//Application.LoadLevel("End");
            SceneManager.LoadScene("End", LoadSceneMode.Single);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player") && PlayerPrefs.GetInt("FoundAllLevel1", 0) == 1
            && PlayerPrefs.GetInt("FoundAllLevel2", 0) == 1 && PlayerPrefs.GetInt("FoundAllLevel3", 0) == 1
			&& PlayerPrefs.GetInt("FoundAllLevel4", 0) == 1 && PlayerPrefs.GetInt("FoundAllLevel5", 0) == 1)
        {
			customImage.enabled = true;
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
            PlayerPrefs.SetInt("TakingQuiz", 1);
		}

	}

	void onTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player")) {
			customImage.enabled = false;
		}
	}
}
