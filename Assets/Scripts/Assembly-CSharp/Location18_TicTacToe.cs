using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location18_TicTacToe : MonoBehaviour
{
	[SerializeField]
	private Location18_Novella main;

	[SerializeField]
	private Image imageFrame;

	public UnityEvent eventFinish;

	private bool destroyGame;

	private float alpha;

	private int step;

	[HideInInspector]
	public List<int> caseClick;

	private bool waitClick;

	private bool dialogueDown;

	private float timeDialogueNext;

	[Header("Диалог")]
	[SerializeField]
	private Transform dialogueT;

	private float timeAnimationBoardAlpha;

	[Header("Доска")]
	[SerializeField]
	private List<GameObject> cases;

	public Sprite[] figure;

	[SerializeField]
	private AnimationCurve animationBoardAlpha;

	private AudioSource audioSource;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip soundEnterMouse;

	[SerializeField]
	private AudioClip[] soundsPen;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void StartGame()
	{
	}

	private void ClickCaseMita(int[] indexes)
	{
	}

	public void ClickCase(int _index, bool _player)
	{
	}

	public void DestroyGame()
	{
	}

	private void CanClick(bool x)
	{
	}

	public void StepMita()
	{
	}

	public void StepPlayer()
	{
	}

	private void MitaCheckRightStep()
	{
	}

	private void ShowWinCase(int _index, bool _player)
	{
	}

	private bool CheckLastStep(bool _player)
	{
		return false;
	}

	private void Finish()
	{
	}

	public void AudioMouseEnter()
	{
	}
}
