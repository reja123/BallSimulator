using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	int countCollision;
	Vector2 startPos, endPos, direction;
	float touchTimeStart, touchTimeFinish, timeInterval;

	[HideInInspector]
	public Rigidbody2D rigidbodyBall;
	public float throwForce = 40f;

	void Awake ()
	{
		rigidbodyBall = GetComponent<Rigidbody2D> ();
		countCollision = PlayerPrefs.GetInt (PlayerPrefsKey.GetInstance ().countBallHitKey);
	}

	void Update ()
	{

		#if UNITY_EDITOR

		if (Input.GetMouseButton (0)) {
			var pos = Input.mousePosition;
			var direction = pos - transform.position;
			rigidbodyBall.AddForce (direction * throwForce);
		}

		#else

		if (Input.touchCount > 0) {
			Vector3 pos = new Vector3(Input.GetTouch (0).position.x, Input.GetTouch (0).position.y);
			var direction = pos - transform.position;
			rigidbodyBall.AddForce (direction * throwForce);
		}

		#endif
	}


	void OnCollisionEnter2D (Collision2D coll)
	{
		countCollision++;
		PlayerPrefs.SetInt (PlayerPrefsKey.GetInstance ().countBallHitKey, countCollision);

	}


}
