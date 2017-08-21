using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
	private void Start()
	{
		Screen.SetResolution(Screen.width, (Screen.width / 9) * 16, true);
		Camera.main.orthographicSize = ((Screen.width / 9) * 16) / (100.0f * 2.0f);
	}

	private void Update()
	{

	}
}
