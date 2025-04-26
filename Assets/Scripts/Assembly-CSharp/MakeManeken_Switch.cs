using UnityEngine;

public class MakeManeken_Switch : MonoBehaviour
{
	[SerializeField]
	private MakeManeken_Main main;

	[SerializeField]
	private AnimationCurve animationMove;

	private Vector3 positionWas;

	private Vector3 positionNeed;

	private float timeAnimationPosition;

	private MakeManeken_Interactive compI;

	private bool switchHold;

	private float ofs;

	private Vector3 audioPosWas;

	private AudioSource audioSource;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TakeSwitch()
	{
	}

	public void DropSwitch()
	{
	}
}
