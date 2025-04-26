using UnityEngine;
using UnityEngine.Events;

public class Trigger_MouseEvent : MonoBehaviour
{
	[SerializeField]
	private UnityEvent eventEnter;

	private bool enterVoke;

	[SerializeField]
	private UnityEvent eventExit;

	private bool exitVoke;

	[SerializeField]
	private bool oneTime;

	[SerializeField]
	private bool destroyEnterMouse;

	[SerializeField]
	private GameObject[] addonTrigger;

	private bool mouse;

	private PlayerMove scrpm;

	private bool timeEventReady;

	private float timeHoldNow;

	[SerializeField]
	[Header("Время")]
	private float timeHold;

	[SerializeField]
	private bool timeContinueHold;

	[SerializeField]
	private UnityEvent eventTimeEnd;

	[Header("Настройки")]
	[SerializeField]
	private float distance;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Enter()
	{
	}

	public void Exit()
	{
	}

	public void DestroyMe()
	{
	}

	public void DestroyThis()
	{
	}

	public void TimeHoldChangeIfMore(float x)
	{
	}

	public void ResetTime()
	{
	}
}
