using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsKey : ScriptableObject
{
	private static PlayerPrefsKey instance;

	public string countBallHitKey = "BALLHIT";

	public static PlayerPrefsKey GetInstance ()
	{
		if (instance == null)
			instance = (PlayerPrefsKey)Resources.Load ("PlayerPrefsKey");
		return instance;
	}

}
