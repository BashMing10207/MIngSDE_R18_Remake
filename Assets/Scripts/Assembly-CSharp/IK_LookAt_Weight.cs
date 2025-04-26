using RootMotion.FinalIK;
using UnityEngine;

public class IK_LookAt_Weight : MonoBehaviour
{
	[SerializeField]
	private float speedLerp;

	[SerializeField]
	private LookAtIK lookAt;

	[SerializeField]
	private bool weight;

	[SerializeField]
	private bool clampHead;

	private float weightNeed;

	private float clampHeadNeed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void WeightLerp(float x)
	{
	}

	public void ClampeHeadLerp(float x)
	{
	}
}
