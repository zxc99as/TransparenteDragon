using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
	[SerializeField]
	private GameObject m_backgroud;

	void Start()
	{
		Screen.SetResolution(Screen.width, Screen.height, true);
		m_backgroud.transform.localScale = new Vector3(Screen.width, Screen.height, 1.0f);
	}

	void Update()
	{

	}
}
