using EPOOutline;
using UnityEngine;
using UnityEngine.Events;

public class Location19_TriggerClick : MonoBehaviour
{
	public bool active;

	[SerializeField]
	private Location19_GlitchGame main;

	public UnityEvent eventClickDown;

	[SerializeField]
	private UnityEvent eventClickUp;

	[SerializeField]
	private float distance;

	private Outlinable outline;

	private bool mouseClick;

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	public void Activation(bool x)
	{
	}

	private void CheckCast()
	{
	}
}
