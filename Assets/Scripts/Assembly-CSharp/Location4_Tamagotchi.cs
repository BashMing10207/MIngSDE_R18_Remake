using UnityEngine;

public class Location4_Tamagotchi : MonoBehaviour
{
	private PlayerMove scrpm;

	private float timeAnimationCamera;

	private Camera cameraPlayer;

	private int indexAnimation;

	private float finishSit;

	private OutlinesPostprocessed colorLine;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve animationLerpMove;

	[SerializeField]
	private AnimationCurve animationLerpRotation;

	[SerializeField]
	private AnimationCurve animationLerpZoom;

	[SerializeField]
	private AnimationCurve animationLerpZoomFinish;

	[SerializeField]
	private GameObject smartphone;

	[SerializeField]
	private Color colorLineWorld;

	[SerializeField]
	private GameObject music;

	[SerializeField]
	private GameObject interfaceFinish;

	[Header("Тамагочи")]
	[SerializeField]
	private Transform cameraPosition;

	private bool canMove;

	private Vector3 movePosition;

	private float animationF;

	private float timeMove;

	private float timePointBlink;

	private float posZPlayer;

	[SerializeField]
	[Header("Игрок")]
	private Animator playerAnimator;

	[SerializeField]
	private Rigidbody playerRigi;

	[SerializeField]
	private SpriteRenderer pointForPlayer;

	[SerializeField]
	private AnimationCurve pointBlink;

	[SerializeField]
	private float positionDivide;

	private int indexPointMita;

	private bool mitaMove;

	[Header("Мита")]
	[SerializeField]
	private Vector3[] mitaMovePoints;

	[SerializeField]
	private Animator mitaAnim;

	[SerializeField]
	private Transform mitaT;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void PlayerCanMove(bool x)
	{
	}

	public void DestroyObjects()
	{
	}

	public void SmartphoneDestroy()
	{
	}

	public void GoMenu()
	{
	}
}
