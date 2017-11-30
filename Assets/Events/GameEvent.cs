using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject {
	/// <summary>
	/// List of listeners will be received this event 
	/// </summary>

	private readonly List<GameEventListener> eventListenerList = new List<GameEventListener>();

	public void Raise() {
		foreach (GameEventListener listener in eventListenerList) {
			listener.OnEventRaised ();
		}		
	}

	public void RegisterListener(GameEventListener listener)
	{
		if (eventListenerList.Contains (listener) == false) {
			eventListenerList.Add (listener);
		}
	}

	public void UnregisterListener(GameEventListener listener) 
	{
		if (eventListenerList.Contains (listener)) {
			eventListenerList.Remove (listener);
		}
	}
}
