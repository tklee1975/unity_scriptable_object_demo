using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public FloatVariable hp;

	// Use this for initialization
	void Start () {
		hp.Value = 1000;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
