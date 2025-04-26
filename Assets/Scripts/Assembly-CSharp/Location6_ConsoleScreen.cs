using UnityEngine;
using UnityEngine.Events;

public class Location6_ConsoleScreen : MonoBehaviour
{
	public UnityEvent eventReady;

	public GameObject[] destroyItemsForHands;

	private bool ready;

	private bool stopActive;

	[Space(20f)]
	public bool playerWhoBusy;

	public bool mitaBusy;

	private void Update()
	{
	}

	public void PlayerWhoBusy(bool x)
	{
	}

	public void MitaBusy(bool x)
	{
	}

	public void PlayerClickStop()
	{
	}

	public void DestroyItems()
	{
	}
}
