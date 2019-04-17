using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showPanel : MonoBehaviour
{
	[SerializeField] private Image customImage;
    // Start is called before the first frame update
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")/* && PlayerPrefs.GetInt("FoundAllLevel1", 0) == 1
            && PlayerPrefs.GetInt("FoundAllLevel2", 0) == 1 && PlayerPrefs.GetInt("FoundAllLevel3", 0) == 1
            && PlayerPrefs.GetInt("FoundAllLevel4", 0) == 1 && PlayerPrefs.GetInt("FoundAllLevel5", 0) == 1*/)
        {
			customImage.enabled = true;
		}

	}

	void onTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player")) {
			customImage.enabled = false;
		}
	}
}
