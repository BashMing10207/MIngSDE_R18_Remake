using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animator_FunctionsOverride : MonoBehaviour
{
	[Header("[EventKey] or [NewEvent]")]
	public List<UnityEvent> eventAnimation;

	protected Animator anim;

	[HideInInspector]
	public AnimatorOverrideController animOver;

	[HideInInspector]
	public float timeAnimationNext;

	private int timeAnimOtherFloat;

	private float animatorFloatOtherA;

	private float animatorFloatOtherB;

	private bool order;

	private AnimationClip animationNextFrameInstant;

	private bool animationInstantNextFrame;

	[Header("Settings")]
	public bool simpleAFloatNotExist;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void StartComponent()
	{
	}

	public void BoolOn(string x)
	{
	}

	public void BoolOff(string x)
	{
	}

	public void TriggerClick(string x)
	{
	}

	public void BoolSwitch(string x)
	{
	}

	public void EventKey(int x)
	{
	}

	public void NewEvent(int x)
	{
	}

	public void ResetOrder()
	{
	}

	public void CheckOrder()
	{
	}

	public void AnimationClipSimpleFrame(AnimationClip _animation)
	{
	}

	public void AnimationClipSimple(AnimationClip _animation)
	{
	}

	public void AnimationClipSimpleNext(AnimationClip _animation)
	{
	}

	public void AnimationClipWalk(AnimationClip _animation)
	{
	}

	public void ReAnimationClip(string _nameOriginAnimationClip, AnimationClip _animationClip)
	{
	}

	public void AnimationIdlePlayAfterWalk(AnimationClip _animcationClip)
	{
	}

	public void AnimationFloatSet(bool ab, float _float)
	{
	}
}
