using UnityEngine;
using UnityEngine.Events;

public class Trigger_Event : MonoBehaviour
{
	public UnityEvent eventEnter;

	public UnityEvent eventExit;

	public GameObject objectTarget;

	[Header("Settings")]
	public bool destroyOnExit;

	public bool loop;

	private Vector3 updateSize;

	public bool updateCast;

	public LayerMask layerUpdateCast;

	private bool enterTime;

	private bool exitTime;

	[Space(20f)]
	public bool triggerActive;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void TargetEnter()
	{
	}

	public void TargetExit()
	{
	}

	public void DestroyMe()
	{
	}

	public bool Check()
	{
		return false;
	}

	[ContextMenu("Restart trigger")]
	public void Restart()
	{
	}

	private void OnDisable()
	{
	}
}
