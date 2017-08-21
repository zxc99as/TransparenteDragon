using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
	public static EventManager instance;
	private Queue<Event> eventQ;

	private void Awake()
	{
		instance = this;
		eventQ = new Queue<Event>();
	}

	public void HandleEvent()
	{
		//e.ActiveEvent();
	}

	public void AddQueue(Event e)
	{
		eventQ.Enqueue(e);
	}
}
