using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getName : MonoBehaviour
{
	public InputField name;
	public Text myText;

	public void display()
	{
		myText.text = name.text + " has passed the psychology room quiz!";
	}
}
