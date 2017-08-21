using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
	private float exp;

	private void Start()
	{
		exp = 1.0f;
	}

	public float Exp
	{
		get { return exp; }
		set { exp = value; }
	}
}
