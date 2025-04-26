using UnityEngine;

public class Location19_Game1 : MonoBehaviour
{
	[SerializeField]
	private Location19_GlitchGame main;

	[SerializeField]
	private Transform[] cases;

	private int indexCaseChangeNow;

	private Vector3 handPositionWas;

	private float lerpHandPosition;

	private float timeAnimationCamera;

	[Header("Камера")]
	[SerializeField]
	private Transform cameraTarget;

	[SerializeField]
	private AnimationCurve cameraAnimation;

	private float timeShot;

	private bool timeHalfShot;

	private bool finish;

	[Header("Выстрел")]
	[SerializeField]
	private ParticleSystem particleSphere;

	[SerializeField]
	private ParticleSystem particleShot;

	[SerializeField]
	private ParticleSystem particleShotFinish;

	[SerializeField]
	private Transform bullet;

	[SerializeField]
	private Transform bulletFinish;

	[SerializeField]
	private LineRenderer lineShot;

	[SerializeField]
	private float[] shotCurve;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void ClickCaseDown(int _index)
	{
	}

	public void ClickCaseUp()
	{
	}

	private void Shot()
	{
	}

	[ContextMenu("Перезапустить точки")]
	private void PointsRandom()
	{
	}

	private void Finish()
	{
	}
}
