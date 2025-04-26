using UnityEngine;

public class MT_GameCnowballs_Ball : MonoBehaviour
{
	[SerializeField]
	private MT_GameCnowballs main;

	[SerializeField]
	private Transform playerT;

	[SerializeField]
	private Transform mitaT;

	[SerializeField]
	private AnimationCurve flyAnimation;

	[SerializeField]
	private Transform shadow;

	private float timeAnimation;

	private Vector3 positionBall;

	public void Start()
	{
	}

	private void Update()
	{
	}
}
