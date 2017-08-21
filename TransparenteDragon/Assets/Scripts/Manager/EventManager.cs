using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
	public static EventManager g_instance; // 싱글턴

	private Queue<Event> m_eventList; // 이벤트 리스트
    public ushort m_eventMax; // 이벤트 리스트 최대갯수

    private void Awake()
	{
        g_instance = this;
        m_eventList = new Queue<Event>();
	}

    private void Update()
    {
        HandleEvent();
    }

    // 이벤트 리스트를 돌며 실행합니다.
	public void HandleEvent()
	{
        Event eventTemp;

        while(m_eventList.Count != 0)
        {
            eventTemp = m_eventList.Dequeue();
            eventTemp.ActiveEvent();
        }
	}

    // 이벤트 삽입
	public void AddQueue(Event e)
	{
        if(m_eventList.Count < m_eventMax)
            m_eventList.Enqueue(e);
	}
}
