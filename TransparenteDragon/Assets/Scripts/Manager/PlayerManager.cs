using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
	private float m_exp;

	private void Start()
	{
        m_exp = 1.0f;
	}

	public float Exp
	{
		get { return m_exp; }
		set { m_exp = value; }
	}
}
