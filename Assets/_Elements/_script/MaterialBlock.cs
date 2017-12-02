using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialBlock : MonoBehaviour
{

	public MaterialType type;
	public MaterialCount count;
	public List<MaterialType> availableTypes = new List<MaterialType>();

	void Start() {
		SetupWithRandomType ();
	}


	void SetupWithRandomType() {
		int randIndex = Random.Range (0, availableTypes.Count);
		MaterialType newType = availableTypes [randIndex];

		SetupWithType (newType);
	}

	void SetupWithType(MaterialType _type) {
		type = _type;

		// Setup Sprite 
		GetComponent<SpriteRenderer>().sprite = type.sprite;
	}

	void Update() {
	//	if
		if(Input.GetMouseButtonDown(0)) {

			BoxCollider2D collider = GetComponent<BoxCollider2D>();

			// 
			Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			touchPos.z = 0;
			Debug.Log ("bound=" + collider.bounds + " touch=" + touchPos);
			if (collider.bounds.Contains (touchPos)) {
				count.AddMaterial (type, 1);

				// change type 
				SetupWithRandomType ();
				return;
			}
		}

	}



}

