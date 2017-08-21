using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Utility;

public class TouchScreen : MonoBehaviour
{
    public Camera m_camera; // 카메라

    public ushort m_width; // 너비
    public ushort m_height; // 높이

    void Start()
    {
        m_camera = Camera.FindObjectOfType<Camera>();
    }

    void Update()
    {
        Vector3 pos = this.transform.position;

        DebugUtil.DrawDebugBox(m_width, m_height, pos, Color.green);

        if(Input.GetMouseButtonDown(0))
        {
            if (TouchCheck())
            {
                OnClick();
            }
        }
    }

    // 터치 확인
    bool TouchCheck()
    {
        float widthDel = (float)m_width / 2;
        float heightDel = (float)m_height / 2;

        Vector3 pos = this.transform.position;
        Vector3 touchPos = Input.mousePosition; // 마우스 스크린 좌표

        touchPos = m_camera.ScreenToWorldPoint(touchPos); // 월드 좌표로 변환

        if(pos.x - widthDel < touchPos.x &&  touchPos.x < pos.x + widthDel &&
            pos.y - heightDel < touchPos.y && touchPos.y < pos.y + heightDel)
            return true;
        else
            return false;
    }

    // 터치시 함수 실행되는 함수
    void OnClick()
    {
        EventManager.g_instance.AddQueue(new TouchEvent());
    }
}
