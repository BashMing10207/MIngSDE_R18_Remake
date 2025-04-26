using UnityEngine;
using UnityEngine.Events;

public class Trigger_DistanceCamera : MonoBehaviour
{
	private Transform cameraT;

	[HideInInspector]
	public bool enter;

	public float distance;

	public UnityEvent eventEnter;

	public UnityEvent eventExit;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DestroyComponent()
	{
	}

	public void Exit(bool _deactiveAfter)
	{
	}

	public void Enter(bool _deactiveAfter)
	{
	}
}
