using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

[AddComponentMenu("Functions/Animation/Animation Player")]
public class ObjectAnimationPlayer : MonoBehaviour
{
	public AnimationClip animationStart;

	public AnimationClip animationLoop;

	public AnimationClip animationStop;

	public PlayableDirector playableDirector;

	public bool stopPositionHips;

	public bool fastPortBody;

	[Header("Settings")]
	public bool keepItem;

	[Range(0f, 90f)]
	public float angleHeadRotate;

	[Header("Events")]
	public List<UnityEvent> eventsPlayer;

	public UnityEvent eventStartLoop;

	[HideInInspector]
	public bool firstEventFinishReady;

	public bool firstEventFinish;

	public UnityEvent eventFinish;

	public UnityEvent eventStartAnimaiton;

	private PlayerMove scrpm;

	private bool fs;

	private void Start()
	{
	}

	public void AnimationPlayFast()
	{
	}

	[ContextMenu("Запустить")]
	public void AnimationPlay()
	{
	}

	public void AnimationStop()
	{
	}

	public void AnimationPlayOnPlayer()
	{
	}
}
