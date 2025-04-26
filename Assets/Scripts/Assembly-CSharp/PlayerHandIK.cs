using RootMotion.FinalIK;
using UnityEngine;

public class PlayerHandIK : MonoBehaviour
{
	public AnimationCurve animationPoserHand;

	public bool rightHand;

	private float timeRotationFinger;

	[Header("Poser fingers")]
	public Vector3[] rotationsFingersWas;

	public Vector3[] rotationsFingers;

	[Header("ИНФОРМАЦИЯ")]
	public bool active;

	public GenericPoser handPoser;

	public Transform[] transformsHand;

	public PlayerHandIK_Prefab handPoseUse;

	public bool holdPose;

	private void Update()
	{
	}

	public void GetHand(PlayerHandIK_Prefab _hand, bool _position, bool _rotation)
	{
	}

	public void HandPoseSmoothApply(PlayerHandIK_Prefab _hand, bool _position, bool _rotation, bool _hold)
	{
	}

	public void HandPoseSharplyApply(PlayerHandIK_Prefab _hand, bool _position, bool _rotation, bool _hold)
	{
	}

	public void Deactive()
	{
	}

	public void HoldOff()
	{
	}
}
