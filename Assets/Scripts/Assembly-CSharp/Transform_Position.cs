using UnityEngine;

public class Transform_Position : MonoBehaviour
{
	public Transform myParent;

	public TransformPoint[] positions;

	public float speedLerpLine;

	public AnimationCurve animationLerp;

	private int lerpLineIndex;

	private bool lerpLine;

	private float timeLerpLine;

	private Vector3 positionWas;

	private Quaternion rotationWas;

	private Transform parentOrigin;

	private bool f;

	private void Update()
	{
	}

	private void StartComponent()
	{
	}

	public void SetPositionAndRotation(int _index)
	{
	}

	public void SetParentZero(Transform _transform)
	{
	}

	public void SetParent(Transform _transform)
	{
	}

	public void ResetParent()
	{
	}

	public void ResetParentAndDeactive()
	{
	}

	public void LerpLinePositionAndRotation(int _index)
	{
	}

	public void LerpLineSpeed(float x)
	{
	}

	public void ResetParentAll()
	{
	}
}
