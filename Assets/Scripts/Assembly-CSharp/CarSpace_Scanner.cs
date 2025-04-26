using UnityEngine;

public class CarSpace_Scanner : MonoBehaviour
{
	[Header("Другие")]
	[SerializeField]
	private Transform playerCarT;

	[SerializeField]
	private Transform bossT;

	[SerializeField]
	private Collider colliderCar;

	[SerializeField]
	private CarSpace_Player playerCarController;

	[Header("Визуал")]
	[SerializeField]
	private Transform scannerT;

	[SerializeField]
	private ParticleSystem particleScan;

	private float timeFlyUp;

	private float timeFly;

	private float timeMove;

	private float timeScannerPos;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve animationFly;

	[SerializeField]
	private AnimationCurve animationFlyUp;

	[SerializeField]
	private AnimationCurve animationScannerPosition;

	[SerializeField]
	private AnimationCurve animationMoveToCar;

	[SerializeField]
	private AnimationCurve animationMoveSide;

	[SerializeField]
	private AnimationCurve animationMoveDamage;

	private bool showPointer;

	[Header("Подсказка")]
	[SerializeField]
	private GameObject pointer;

	private Rigidbody rb;

	private SphereCollider colliderSelf;

	private float timeRacing;

	private int indexAnimation;

	private bool sideScan;

	private Vector3 positionStart;

	private float timeAnimationMoveSide;

	private float timeRandomMoveSide;

	private float sidePositionMoveSideWas;

	private float sidePositionMoveSide;

	private float animationRotate;

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void StartToCar()
	{
	}

	public void InfinityBack()
	{
	}

	public void RestartScanner()
	{
	}
}
