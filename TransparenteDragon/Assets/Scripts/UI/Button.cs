using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
	[SerializeField]
	protected Sprite[] m_images;

	protected enum state : byte { IDLE = 0x00, CLICKED = 0x01, ON = 0x02, OFF = 0x03};
	protected bool isMouseOver;

	private void Start()
	{
		isMouseOver = false;
	}

	private void Update()
	{
		if (isMouseOver && Input.GetMouseButtonDown(0)) OnClick();
	}

	protected void SetImage(state p_value)
	{
		Sprite sprite = m_images[(int)p_value];
		gameObject.GetComponent<Image>().sprite = sprite;
	}

	void OnClick()
	{
		Debug.Log(gameObject.name + " Clicked");
		//SetImage(state.CLICKED);
	}

	protected void OnMouseOver() { isMouseOver = true; }
	protected void OnMouseExit() { isMouseOver = false; }

}
