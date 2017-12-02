using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {
	public SpriteList fishSpriteList;

	public float swimSpeedMin = 1;
	public float swimSpeedMax = 3;

	private float swimSpeedY = 0;
	private float swimSpeedX = 1;
	public FishRuntimeSet runtimeSet;

	private void OnEnable()
	{
		runtimeSet.Add(this);
	}

	private void OnDisable()
	{
		runtimeSet.Remove(this);
	}


	// Use this for initialization
	void Start () {
		swimSpeedX = Random.Range (0.5f, 2f);
		GetComponent<SpriteRenderer> ().sprite = fishSpriteList.GetRandom ();	
	}
	
	// Update is called once per frame
	void Update () {
		// Swim 
		swimSpeedX += Random.Range(1f, 3f) * Time.deltaTime;
		swimSpeedX = Mathf.Clamp (swimSpeedX, swimSpeedMin, swimSpeedMax);

		swimSpeedY += Random.Range (-0.1f, 0.1f);

		Vector3 delta = new Vector3 (swimSpeedX, swimSpeedY, 0) * Time.deltaTime;

		Vector3 newPos = transform.position + delta;

		transform.position = newPos;

		if (transform.position.x > 8
			|| Mathf.Abs(transform.position.y) > 4) {
			Object.Destroy (this.gameObject);
		}
	}

}
