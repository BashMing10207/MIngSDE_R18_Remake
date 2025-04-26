using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location8_InfinityRoom : MonoBehaviour
{
	private Transform playerT;

	private bool canNextIndex;

	[SerializeField]
	private int indexRoom;

	private int indexDigitalInfo;

	[Header("Комнаты")]
	public Loc8_Room[] roomsEvents;

	[SerializeField]
	private Text textDigitalInfo;

	private bool teleportRandomMita;

	private bool teleportRandomMitaWindow;

	private int indexRun;

	[Header("Мита")]
	public Location8_MitaBrokeLife mitaLife;

	public UnityEvent eventMitaWindow;

	[SerializeField]
	private GameObject[] dialogueRun;

	[Header("Монстр")]
	public Location8_SlouchLife slouchLife;

	[Header("Окна")]
	[SerializeField]
	private Renderer[] windows;

	[SerializeField]
	private Material[] materialsForWindows;

	private int timeLightUpdate;

	[SerializeField]
	[Header("Освещение")]
	private Light LightCopy;

	[SerializeField]
	private Light LightPaste;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void StartNextRoom()
	{
	}

	public void CanNext(bool _x)
	{
	}

	public void MitaTeleportActive(bool x)
	{
	}

	public void MitaWindowTeleport()
	{
	}

	[ContextMenu("Сказать про окно")]
	public void TalkWindow()
	{
	}

	public void WindowStep(int _step)
	{
	}

	public void TimeRoom(int x)
	{
	}
}
