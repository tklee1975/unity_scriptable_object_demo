using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {
	public GameObject starPrefab;
	public GameObject starParent;

	// Use this for initialization
	public void SpawnRandomStar () {
		GameObject newStar = GameObject.Instantiate (starPrefab) as GameObject;

		float x = Random.Range (-3.0f, 3.0f);
		float y = Random.Range (-1.0f, 4.0f);
		newStar.transform.position = new Vector3 (x, y, 0);
		newStar.transform.SetParent(starParent.transform);
	}

	public void SpawnRandomSizeStar () {
		GameObject newStar = GameObject.Instantiate (starPrefab) as GameObject;

		float x = Random.Range (-3.0f, 3.0f);
		float y = Random.Range (-1.0f, 4.0f);
		float size = Random.Range (1, 4);

		newStar.transform.position = new Vector3 (x, y, 0);
		newStar.transform.localScale = new Vector3 (size, size, 1);
		newStar.transform.parent = starParent.transform;
	}


	public void ClearAllStar()
	{
		Transform[] childrens = starParent.GetComponentsInChildren<Transform> ();

		foreach (Transform child in childrens) {
			Destroy (child.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
