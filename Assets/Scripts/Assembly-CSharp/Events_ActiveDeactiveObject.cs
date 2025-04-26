using UnityEngine;
using UnityEngine.Events;

public class Events_ActiveDeactiveObject : MonoBehaviour
{
	public bool active;

	public UnityEvent eventDisable;

	public UnityEvent eventEnable;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Activation(bool x)
	{
	}
}
