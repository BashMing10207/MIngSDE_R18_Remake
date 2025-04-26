using UnityEngine;
using UnityEngine.Events;

public class ItemInteractive : MonoBehaviour
{
	public UnityEvent eventClick;

	public Transform childObject;

	public float crosshairSize;

	[Header("Pause")]
	public UnityEvent eventPauseActive;

	public UnityEvent eventPauseDeactive;

	private bool toggleActive;

	private PlayerMove scrpm;

	private GameController scrgc;

	[Header("Информация")]
	public bool canUseOther;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void Pause(bool _pause)
	{
	}
}
