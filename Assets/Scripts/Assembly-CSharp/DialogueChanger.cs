using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogueChanger : MonoBehaviour
{
	public enum TypeSyleQuestDialogue
	{
		normal = 0,
		horror = 1
	}

	private GameObject canvas;

	private Image imgFrame;

	private RectTransform frameDialogue;

	private List<int> indexButtons;

	[Header("Интерфейс")]
	public DialogueChangerCase[] buttons;

	[Header("Методы")]
	public UnityEvent eventStart;

	public UnityEvent eventClose;

	public UnityEvent eventExit;

	public UnityEvent eventLastStop;

	public UnityEvent eventAgainFarAway;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip soundOn;

	[SerializeField]
	private AudioClip soundOff;

	[Header("Настройки")]
	public string fileQuest;

	[Label("Взгляд на:")]
	[SerializeField]
	private Transform positionDialogue;

	[Label("Выбрать стиль")]
	public TypeSyleQuestDialogue style;

	[Header("Взаимодействие")]
	[SerializeField]
	private GameObject objectInteractive;

	[SerializeField]
	private Location21_IconQuest iconQeust;

	private bool play;

	private bool overQuest;

	private GameObject exampleButton;

	private float timeClose;

	private bool canInteractive;

	private bool first;

	private void Start()
	{
	}

	public void StartComponent()
	{
	}

	private void Update()
	{
	}

	public void Close()
	{
	}

	public void EscapeClick()
	{
	}

	public void Play()
	{
	}

	public void PlayDistanceAgain()
	{
	}

	public void DialogueFinishPlayDistance()
	{
	}

	private void RepositionCase()
	{
	}

	private void ClearCases()
	{
	}

	public void ClickButton(int _indexButton)
	{
	}

	public void OpenCase(int x)
	{
	}

	public void CloseCase(int x)
	{
	}

	public void DialogueStart()
	{
	}

	public void DialogueFinish()
	{
	}

	public void InteractiveActivation(bool x)
	{
	}

	public void InteractiveActivationCheck()
	{
	}
}
