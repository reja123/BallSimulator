﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ShowPlayerPrefsKey : MonoBehaviour {


	[MenuItem("Settings/ShowPlayerPrefsKey")]
	public static void PlayerPrefsKeyNow()
	{
		var asset = PlayerPrefsKey.GetInstance ();
		EditorUtility.FocusProjectWindow();
		Selection.activeObject = asset;
	}
} 
