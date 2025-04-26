using UnityEngine;

[AddComponentMenu("Functions/Time/Time event int")]
public class Time_EventsInt : MonoBehaviour
{
	public bool active;

	public int timer;

	[SerializeField]
	public TimePointInt[] events;

	private void FixedUpdate()
	{
	}

	public void DestroyComponent()
	{
	}

	public void ActivationTimer(bool x)
	{
	}

	public void RestartTimer()
	{
	}
}
