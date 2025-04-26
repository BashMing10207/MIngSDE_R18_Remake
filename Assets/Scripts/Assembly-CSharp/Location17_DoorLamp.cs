using UnityEngine;
using UnityEngine.Events;

public class Location17_DoorLamp : MonoBehaviour
{
	public MeshRenderer meshLamp;

	[ColorUsage(false, true)]
	public Color colorLampLight;

	[Header("События")]
	public UnityEvent eventReady;

	public UnityEvent eventPlayerLose;

	public UnityEvent eventSwitchPlayerLose;

	private bool playerUseSwitch;

	public Time_Events[] playerLoseEvent;

	private int indexLoseEvent;

	[Header("Звуки")]
	public AudioSource audioLamp;

	public AudioClip[] soundsLamp;

	private bool withMita;

	private bool lampActive;

	private float timeRightSwitch;

	private float timeLeftSwitch;

	private bool ready;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void MitaWith()
	{
	}

	public void SwitchLeft()
	{
	}

	public void SwitchRight()
	{
	}

	public void MitaSwitchReady()
	{
	}
}
