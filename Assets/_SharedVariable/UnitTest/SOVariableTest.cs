using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleTDD;

public class SOVariableTest : BaseTest {
	public IntVariable score;
	public GameObject touchParticle;

	public GameObject[] targetList;

	public bool doSpawning = false;

	public float mCooldown;

	void Start()
	{
		score.value = 0;
		mCooldown = 2;
	}

	void Update() {
		if(Input.GetMouseButtonDown(0)) {
			Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			touchPos.z = 0;
			ShowTouchParticle(touchPos);
		}



		// Spawning 
		if(doSpawning) {
			mCooldown -= Time.deltaTime;
			if(mCooldown <= 0) { 
				SpawnTarget();
				mCooldown = 2;
			}
		}
	}

	void ShowTouchParticle(Vector3 position)
	{
		position.z = -10;

		GameObject newObject = Object.Instantiate(touchParticle) as GameObject;
		newObject.transform.position = position;
		ParticleSystem particle = newObject.GetComponent<ParticleSystem>();
		Destroy(particle.gameObject, particle.main.duration);
	}

	void SpawnTarget() {
		int index = Random.Range(0, targetList.Length);
		GameObject target = targetList[index];

		float x = Random.Range(-5, 5);
		float y = Random.Range(-2, 3);
		Vector3 pos = new Vector3(x, y, 0);

		GameObject newObject = Object.Instantiate(target) as GameObject;
		newObject.transform.position = pos;


	}


	[Test]
	public void ChangeScore()
	{
		score.value += 10;
	}


	[Test]
	public void ShowTouchParticle()
	{
		ShowTouchParticle(Vector3.zero);
	}

	[Test]
	public void TestSpawn()
	{
		SpawnTarget();
	}

	[Test]
	public void ToggleSpawn()
	{
		doSpawning = doSpawning == false;
	}
}
