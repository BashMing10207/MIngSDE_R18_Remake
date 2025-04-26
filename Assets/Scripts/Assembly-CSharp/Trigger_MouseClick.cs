using EPOOutline;
using UnityEngine;
using UnityEngine.Events;

public class Trigger_MouseClick : MonoBehaviour
{
	public bool mouseInterface;

	public bool deactiveAfterClick;

	public UnityEvent eventClick;

	public UnityEvent eventEnter;

	public UnityEvent eventExit;

	private bool deactiveOutline;

	private Outlinable scroutline;

	private bool mouse;

	private bool active;

	private PlayerMove scrpm;

	private GameController scrgc;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ActivationOutline(bool x)
	{
	}

	public void Enter()
	{
	}

	public void Exit()
	{
	}

	[ContextMenu("Клик")]
	public void Click()
	{
	}

	private void OnDisable()
	{
	}

	public void ActivatedObject(bool x)
	{
	}

	public void Restart()
	{
	}
}
