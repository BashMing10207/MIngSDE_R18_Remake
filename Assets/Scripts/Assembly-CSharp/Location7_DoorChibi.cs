using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location7_DoorChibi : MonoBehaviour
{
	[SerializeField]
	private Text textNow;

	[SerializeField]
	private GameObject[] chibis;

	[SerializeField]
	private Transform pointDoor;

	[SerializeField]
	private Animator animDoor;

	[SerializeField]
	private UnityEvent eventReady;

	private int chibiCountNow;

	private void Update()
	{
	}

	public void ChibiReady()
	{
	}
}
