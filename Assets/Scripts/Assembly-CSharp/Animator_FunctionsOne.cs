using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Animator_FunctionsOne : MonoBehaviour
{
	[SerializeField]
	private string nameState;

	[SerializeField]
	private Events_AnimatorEvent[] events;

	private float timeAnimation;

	private Animator anim;

	private AnimatorOverrideController animOver;

	private bool fl;

	private void StartComponent()
	{
	}

	private void Update()
	{
	}

	public void AnimationPlay(AnimationClip _animationClip)
	{
	}

	public void AnimationStop()
	{
	}

	public void EventAnim(int _index)
	{
	}

	private void Reset()
	{
	}

	private void OnDisable()
	{
	}
}
