using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBallHit : MonoBehaviour {

	public Text ballHitText;

	void OnEnable() {
		ballHitText.text = PlayerPrefs.GetInt (PlayerPrefsKey.GetInstance().countBallHitKey).ToString();
	}
	

}
