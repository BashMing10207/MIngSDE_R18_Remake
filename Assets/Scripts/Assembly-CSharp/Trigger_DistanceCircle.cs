using UnityEngine;
using UnityEngine.Events;

public class Trigger_DistanceCircle : MonoBehaviour
{
	public Transform target;

	public float radius;

	public UnityEvent eventEnter;

	public UnityEvent eventExit;

	[Header("Settings")]
	public bool destroyOnExit;

	[SerializeField]
	private bool loop;

	private bool one;

	private bool targetInside;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Restart()
	{
	}

	public void RestartNormal()
	{
	}
}
