using UnityEngine;
using UnityEngine.Events;

public class Mob_ChibiMita_Animation : MonoBehaviour
{
	public Mob_ChibiMita mob;

	public bool animationPositionThis;

	public bool holdIKLook;

	[Space(15f)]
	public AnimationClip animationStart;

	public AnimationClip animationLoop;

	public AnimationClip animationStop;

	[Header("Events")]
	public UnityEvent eventStart;

	public UnityEvent eventStartLoop;

	public UnityEvent eventFinish;

	public void AnimationMovePlay()
	{
	}

	public void AnimationPlay()
	{
	}

	public void AnimationPlayFast()
	{
	}

	public void AnimationStopPlay()
	{
	}
}
