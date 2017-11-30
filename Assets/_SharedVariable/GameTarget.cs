using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTarget : MonoBehaviour {
	public IntVariable scoreReference;
	public int hitScore = 10;
	public float appearTime = 1;
	public AudioClip hitSound;
	public AudioClip missSound;

	private float mTimeElapse = 0;


	void Start() {
		mTimeElapse = 0;
	}


	bool IsFallingInCircle(CircleCollider2D collider, Vector3 position)
	{
		position.z = 0;

		Vector3 centerPos = collider.transform.position;
		centerPos.z = 0;

		float scaledRadius = collider.radius * collider.transform.localScale.x;
		float distance = (position - centerPos).magnitude;
		Debug.Log("distance=" + distance + " radius=" + scaledRadius);
		return distance < scaledRadius;
	}

	void ShouldFadeOut()
	{
	}

	void Update() {
		if(Input.GetMouseButtonDown(0)) {
			
			CircleCollider2D collider = GetComponent<CircleCollider2D>();

			Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			if(IsFallingInCircle(collider, touchPos)) {
				OnHit(touchPos);
			}
		}

		mTimeElapse += Time.deltaTime;
		if(mTimeElapse > appearTime) {
			GetComponent<AudioSource>().clip = missSound;
			GetComponent<AudioSource>().Play();
			Destroy(this.gameObject);
		}
	}

	void OnHit(Vector3 position) {
		GetComponent<AudioSource>().clip = hitSound;
		GetComponent<AudioSource>().Play();
		scoreReference.value += hitScore;
		Destroy(this.gameObject);
	}


}
