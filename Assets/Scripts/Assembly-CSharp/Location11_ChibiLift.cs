using RootMotion.FinalIK;
using UnityEngine;

public class Location11_ChibiLift : MonoBehaviour
{
	[SerializeField]
	[Header("Движение")]
	private Vector3[] pointsMove;

	[SerializeField]
	private GameObject particleRun;

	[SerializeField]
	private LayerMask layerPlayer;

	private float wasRotate;

	private float needRotate;

	private float timeJump;

	[SerializeField]
	[Header("Прыжок")]
	private AnimationCurve animationRotateJump;

	private float timeStopLook;

	[SerializeField]
	[Header("Взгляд")]
	private LookAtIK lookAt;

	private Animator animator;

	private int moveToPoint;

	private bool run;

	private bool walk;

	private float timeStop;

	private Transform cameraPlayer;

	private float timeNextDialoguePlayerStay;

	private int intDialoguePlayerStay;

	private float timeLong;

	private float timeLongGeneral;

	private float timePlayerNear;

	[Header("Диалоги")]
	[SerializeField]
	private GameObject[] dialoguePlayerStay;

	[SerializeField]
	private GameObject dialogueStop;

	[SerializeField]
	private MagicCloth_Blend cloth;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void RotateJump(Vector3 _position)
	{
	}

	public void StartRun()
	{
	}

	private void StartAngry()
	{
	}

	public void StartRunPlayer()
	{
	}
}
