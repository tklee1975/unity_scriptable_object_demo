using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleTDD;

public class ElementTest : BaseTest {
	public MaterialCount materialCount;

	void Start() {
		materialCount.Reset ();

		Debug.Log("Info: " + materialCount.Info);
		UpdateLog("Material Count:\n" + materialCount.Info);
	}

	void Update() {
		UpdateLog (materialCount.Info);
	}

	[Test]
	public void test1()
	{
		Debug.Log("###### TEST 1 ######");
	}

	[Test]
	public void test2()
	{
		Debug.Log("###### TEST 2 ######");
	}
}
