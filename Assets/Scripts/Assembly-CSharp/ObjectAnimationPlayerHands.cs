using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectAnimationPlayerHands : MonoBehaviour
{
	public AnimationClip animationStart;

	public AnimationClip animationLoop;

	public AnimationClip animationStop;

	public UnityEvent eventStartLoop;

	public List<UnityEvent> eventsPlayer;

	public bool face;

	public bool keepItem;

	private PlayerMove scrpm;

	private void Start()
	{
	}

	public void AnimationPlay()
	{
	}

	public void AnimationPlayFast()
	{
	}

	public void AnimationStop()
	{
	}
}
