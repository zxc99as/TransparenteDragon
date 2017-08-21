using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
	[SerializeField]
	private GameObject m_backgroud;

	private void Start()
	{
		Screen.SetResolution(Screen.width, Screen.height, true);
		Camera.main.orthographicSize = Screen.height / (100.0f * 2.0f);
		m_backgroud.transform.localScale = new Vector3(Screen.width, Screen.height, 1.0f);
	}

	private void Update()
	{

	}
}
