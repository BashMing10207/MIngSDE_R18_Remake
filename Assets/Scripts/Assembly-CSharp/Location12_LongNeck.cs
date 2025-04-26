using UnityEngine;

public class Location12_LongNeck : MonoBehaviour
{
	[SerializeField]
	private Transform targetFollow;

	[SerializeField]
	private Transform target;

	[SerializeField]
	private Transform[] neck;

	[SerializeField]
	private Transform neckStart;

	[SerializeField]
	private AnimationCurve curveNeck;

	[SerializeField]
	private LayerMask layerWall;

	[SerializeField]
	private Vector3[] neckOrigin;

	private Vector3 positionHeadWas;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioNeck;

	private bool animationPlay;

	[SerializeField]
	[Header("Сценарий")]
	private RuntimeAnimatorController animatorHead;

	[SerializeField]
	private Animator animHead;

	private RaycastHit hit;

	private Vector3 targetRandomMove;

	private float resetRandom;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void PlayAnimation()
	{
	}
}
