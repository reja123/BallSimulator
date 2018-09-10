using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

	public GameObject btnBack;
	public BallController ballController;
	public Image backgroundColor;
	public Color earthBackgroundColor;
	public Color moonBackgroundColor;
	public Color jupiterBackgroundColor;
	public GameObject menuPanel;
	public GameObject gamePanel;
	public float earthGravity = 9.8f;
	public float moonGravity = 1.6f;
	public float jupiterGravity = 24.5f;

	void Awake()
	{
		#if !UNITY_EDITOR
		btnBack.SetActive (false);
		#endif


	}

	public void StartEarthMode ()
	{
		StartGame ();
		backgroundColor.color = earthBackgroundColor;
		ballController.rigidbodyBall.gravityScale = earthGravity;
	}

	public void StartMoonMode ()
	{

		StartGame ();
		backgroundColor.color = moonBackgroundColor;
		ballController.rigidbodyBall.gravityScale = moonGravity;
	}

	public void StartJupiterMode ()
	{
		StartGame ();
		backgroundColor.color = jupiterBackgroundColor;
		ballController.rigidbodyBall.gravityScale = jupiterGravity;
	}


	public void StartGame ()
	{
		
		menuPanel.SetActive (false);
		gamePanel.SetActive (true);
	}

	public void StartMenu ()
	{
		menuPanel.SetActive (true);
		gamePanel.SetActive (false);

	}

	public void Update ()
	{
		#if UNITY_ANDROID
		if (Input.GetKeyDown (KeyCode.Escape)) {
			StartMenu ();
		}
		#endif

	}

}
