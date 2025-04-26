using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerPerson : MonoBehaviour
{
	[HideInInspector]
	public List<UnityEvent> eventsPlayer;

	private Animator anim;

	private bool blinkPlay;

	private float timeBlink;

	private float blinkTimeAnimation;

	private float timeEyesTarget;

	[SerializeField]
	[Header("Глаза")]
	private AnimationCurve animationBlink;

	[SerializeField]
	private SkinnedMeshRenderer meshHead;

	[SerializeField]
	private Transform ikEyesTarget;

	private Color setColor;

	private float timeReColor;

	[SerializeField]
	[Header("Цвет outline")]
	private SkinnedMeshRenderer[] meshes;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void BlinkPlay(bool x)
	{
	}

	public void EventKey(int _x)
	{
	}

	public void NewEvent(int _x)
	{
	}

	public void StepMove()
	{
	}

	public void Step()
	{
	}

	public void SetColorOutline(Color _color)
	{
	}
}
