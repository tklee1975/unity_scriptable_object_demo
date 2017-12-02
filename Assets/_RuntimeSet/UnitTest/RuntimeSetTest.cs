using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleTDD;

public class RuntimeSetTest : BaseTest {
	public FishMonitor fishMonitor;

	[Test]
	public void testSpawn()
	{
		fishMonitor.SpawnFish ();
	}

	[Test]
	public void test2()
	{
		Debug.Log("###### TEST 2 ######");
	}
}
