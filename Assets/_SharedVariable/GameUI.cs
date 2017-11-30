using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {
	public IntVariable score;

	private Text mScoreText;

	// Use this for initialization
	void Awake() {
		mScoreText = transform.Find ("ScoreText").GetComponentInChildren<Text> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mScoreText.text = "Score: " + score.value;
	}
}
