using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hidePanel : MonoBehaviour
{
	[SerializeField] private Image customImage;
	// Start is called before the first frame update
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			customImage.enabled = false;
		}

	}
		
}
