using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Functions/Event/Event")]
public class Events_Data : MonoBehaviour
{
	[Header("Method [NewEvent] or [EV]")]
	public bool onStartZeroIndex;

	public UnityEvent[] _event;

	private void Start()
	{
	}

	public void EV(int x)
	{
	}

	public void NewEvent(int x)
	{
	}
}
