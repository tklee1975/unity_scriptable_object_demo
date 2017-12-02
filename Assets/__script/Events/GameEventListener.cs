using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Try to Add this Component to the GameObject want to listen to game event
/// </summary>
public class GameEventListener : MonoBehaviour 
{
	//[Tooltip("Event to register with")]
	public GameEvent gameEvent;


	[Tooltip("Response to invoke when Event is raised")]
	public UnityEvent gameResponse; 

	// Use this for initialization
	private void OnEnable() {
		gameEvent.RegisterListener(this);		
	}

	private void OnDisable() {
		gameEvent.UnregisterListener (this);
	}
	
	public void OnEventRaised() {
		gameResponse.Invoke();
	}
}
