using UnityEngine;

public class FightBoss_Player : MonoBehaviour
{
	[SerializeField]
	private Transform cameraT;

	private Vector3 moveControl;

	private Rigidbody rb;

	private float gravityY;

	[SerializeField]
	[Header("Физика")]
	private LayerMask layerFloor;

	private bool canJump;

	private float timeJump;

	private bool canDash;

	[Header("Характеристика")]
	[SerializeField]
	private float speed;

	[SerializeField]
	private float jump;

	private float timeStopMove;

	private float timeAnimRun;

	private float animRun;

	[Header("Анимация")]
	[SerializeField]
	private Animator animPerson;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void Step()
	{
	}
}
