using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location1Tutorial : MonoBehaviour
{
	private bool requestPlayer;

	private bool play;

	private float timeCanMove;

	private int indexHint;

	[SerializeField]
	private UnityEvent eventYesQuest;

	[SerializeField]
	private UnityEvent eventNoQuest;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioFill;

	[SerializeField]
	private AudioSource audioOkey;

	[Header("Стиль общения")]
	[SerializeField]
	private GameObject frameStyle;

	[SerializeField]
	private GameObject frameTutorial;

	[SerializeField]
	private UnityEvent eventClickStyleSmile;

	[Header("Обучение 1")]
	[SerializeField]
	private GameObject objectMouseMove;

	[SerializeField]
	private Image imageTimeMouse;

	[SerializeField]
	private UnityEvent eventReadyMouse;

	[Header("Обучение 2")]
	[SerializeField]
	private GameObject objectMove;

	[SerializeField]
	private Image imageTimeMove;

	[SerializeField]
	private UnityEvent eventReadyMove;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ChangePlayerQuest(bool _x)
	{
	}

	public void CloseQuestHint()
	{
	}

	public void DestroyMe()
	{
	}

	public void ChangeStyleDialogue(bool x)
	{
	}
}
