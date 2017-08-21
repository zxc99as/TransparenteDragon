using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Utility;

public class Button : MonoBehaviour
{
	[SerializeField]
	protected Sprite[] m_images;

	[SerializeField]
	protected float m_width, m_height;

	protected enum state : byte { IDLE = 0x00, CLICKED = 0x01, ON = 0x02, OFF = 0x03};

	private void Update()
	{
		DebugUtil.DrawDebugBox(m_width, m_height, transform.position, Color.green);

		if (Input.GetMouseButtonDown(0))
		{
			if (ClickCheck())
			{
				OnClick();
			}
		}
	}

	protected void SetImage(state p_value)
	{
		Sprite sprite = m_images[(int)p_value];
		gameObject.GetComponent<Image>().sprite = sprite;
	}

	protected bool ClickCheck()
	{
		Vector3 pos = transform.position;
		Vector3 touchPos = Input.mousePosition;

		touchPos = Camera.main.ScreenToWorldPoint(touchPos);

		if (pos.x - m_width / 2 < touchPos.x && touchPos.x < pos.x + m_width / 2
			&& pos.y - m_height / 2 < touchPos.y && touchPos.y < pos.y + m_height / 2)
			return true;

		else return false;
	}

	void OnClick()
	{
		Debug.Log(gameObject.name + " Clicked");
		//SetImage(state.CLICKED);
	}
}
