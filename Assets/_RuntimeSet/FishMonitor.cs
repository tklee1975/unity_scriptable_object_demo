using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMonitor : MonoBehaviour
{
	public FishRuntimeSet fishRuntimeSet;
	public int fishCount = 50;

	public GameObject fishPrefab;

	private float mSpawnCooldown;

	public void Start() {
		fishRuntimeSet = fishPrefab.GetComponent<Fish> ().runtimeSet;

		mSpawnCooldown = 0;
	}

	public void SpawnFish() {
		float y = Random.Range (-2f, 4f);
		Vector3 startPos = new Vector3 (-8, y, 0);

		GameObject newFish = Object.Instantiate (fishPrefab) as GameObject;
		newFish.transform.position = startPos;

		//Random.r
//		float startY = Random.Ra
		//Vector3 startPos = 


	}


	private void Update()
	{
		mSpawnCooldown -= Time.deltaTime;
		if (mSpawnCooldown <= 0) {
			mSpawnCooldown = 0.1f;
			// 
			if (fishRuntimeSet.Items.Count < fishCount) {
				SpawnFish ();
			}
		}
	}

//	private void OnEnable()
//	{
//		UpdateText();
//	}
//
//	private void Update()
//	{
//		if (previousCount != Set.Items.Count)
//		{
//			UpdateText();
//			previousCount = Set.Items.Count;
//		}
//	}
//
//	public void UpdateText()
//	{
//		Text.text = "There are " + Set.Items.Count + " things.";
//	}
}
