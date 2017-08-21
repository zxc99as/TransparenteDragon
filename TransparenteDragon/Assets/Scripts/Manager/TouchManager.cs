using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour
{
	[SerializeField]
	private Text m_text;

	private void Start ()
	{
		
	}

	private void Update ()
	{
		if (Input.GetMouseButtonDown(0)) Touch();
	}

	private void Touch()
	{
		//EventManager.instance.HandleEvent();
		//EventManager.instance.AddQueue();
	}
}
