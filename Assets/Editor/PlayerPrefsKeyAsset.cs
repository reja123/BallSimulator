using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerPrefsKeyAsset : MonoBehaviour {


		[MenuItem("Settings/CreateAsset/PlayerPrefsKeyAsset")]
		public static void CreateAsset ()
		{
			ScriptableObjectUtility.CreateAsset<PlayerPrefsKey> ();
		}
}
