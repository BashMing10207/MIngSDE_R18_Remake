using UnityEngine;
using UnityEngine.Events;

public class Time_Pause : MonoBehaviour
{
	[SerializeField]
	private UnityEvent eventPause;

	[SerializeField]
	private UnityEvent eventPlay;

	[SerializeField]
	private Renderer[] renderers;

	private bool isPause;

	private void LateUpdate()
	{
	}

	public void Pause()
	{
	}

	public void Play()
	{
	}
}
