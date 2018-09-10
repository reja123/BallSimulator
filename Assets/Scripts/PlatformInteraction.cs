using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformInteraction : MonoBehaviour
{

	Image imagePlatform;

	void Awake ()
	{
		imagePlatform = GetComponent<Image> ();

	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		imagePlatform.color = Random.ColorHSV ();

	}


}
