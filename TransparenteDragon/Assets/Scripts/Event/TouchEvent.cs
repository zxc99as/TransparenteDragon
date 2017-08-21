using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEvent : Event
{
	public override void ActiveEvent()
	{
		Debug.Log("Touched!");
	}
}
