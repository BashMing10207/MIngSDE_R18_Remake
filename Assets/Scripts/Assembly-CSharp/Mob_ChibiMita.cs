using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Mob_ChibiMita : MonoBehaviour
{
	private NavMeshAgent nma;

	[HideInInspector]
	public UnityEvent eventWalkToPoint;

	private bool walkGo;

	private Vector3 pointGo;

	public Animator anim;

	public string nameAnimationWalk;

	public string nameAnimationIdle;

	private bool typeAnimation;

	private Mob_ChibiMita_Animation animationScript;

	private float animationTimePlay;

	private bool animationPlay;

	private AnimatorOverrideController animOver;

	private Character_LookSimple chibiLook;

	private float rotateNeed;

	private float timeNeedRotate;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateAnimation()
	{
	}

	public void GoWalk(Vector3 _positionWalk, UnityEvent _event)
	{
	}

	public void GoMoveAnimation(Mob_ChibiMita_Animation _scrChibiAnimation)
	{
	}

	public void AnimationPlay(Mob_ChibiMita_Animation _scrChibiAnimation)
	{
	}

	public void AnimationPlayFast(Mob_ChibiMita_Animation _scrChibiAnimation)
	{
	}

	public void AnimationStopPlay(Mob_ChibiMita_Animation _scrChibiAnimation)
	{
	}

	public void AnimationStop()
	{
	}

	public void Rotate(float x)
	{
	}

	public void TeleportTarget(Transform _target)
	{
	}

	public void MovePlay(Vector3 _pos)
	{
	}

	public void MoveStop()
	{
	}

	public void ReAnimationMove(AnimationClip _animationClipWalk)
	{
	}

	public void ReAnimationMove(AnimationClip _animationClipWalk, AnimationClip _animationClipIdle)
	{
	}

	public void AnimatorReset()
	{
	}
}
