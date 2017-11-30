using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleTDD;

public class GameEventTest : BaseTest {
	public StarController starController;
	public GameEvent spawnStarEvent;

	[Test]
	public void SpawnStar()
	{
		starController.SpawnRandomStar ();
	}

	[Test]
	public void SpawnStarEvent()
	{
		spawnStarEvent.Raise ();
		//ScriptableObject.CreateInstance<SpawnStarEvent>();
	}

	[Test]
	public void ClearAllStar()
	{
		starController.ClearAllStar ();
	}

//	[Test]
//	public void Clear()
//	{
//		spawnStarEvent.Raise ();
//		//ScriptableObject.CreateInstance<SpawnStarEvent>();
//	}
}
