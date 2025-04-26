using UnityEngine;

public class Location19_Game3 : MonoBehaviour
{
	[SerializeField]
	private Location19_GlitchGame main;

	private float timeAnimationCamera;

	[Header("Камера")]
	[SerializeField]
	private Transform cameraTarget;

	[SerializeField]
	private AnimationCurve cameraAnimation;

	private int figureSphere;

	private int figureStar;

	private int figureTriangle;

	[HideInInspector]
	public Location19_Game3_Place placeCast;

	[Header("Игра")]
	[SerializeField]
	private Location19_Game3_Planet[] planets;

	[SerializeField]
	private GameObject figurePrefab;

	[SerializeField]
	private GameObject placeTriggerPrefab;

	[SerializeField]
	private Vector3[] positionsPlacesFigure;

	private float timeScale;

	private GameObject figureHold;

	[HideInInspector]
	public Location19_Game3_Place placeChangeNow;

	private Location19_Game3_Place placeChangeWas;

	private float timeFigureLerp;

	private Vector3 figurePosWas;

	[Header("Рука")]
	[SerializeField]
	private Animator hand;

	private Vector3 audioDistanceHand;

	[Header("Звуки")]
	[SerializeField]
	private Audio_Data audioTake;

	[SerializeField]
	private Audio_Data audioDrop;

	[SerializeField]
	private AudioSource audioHandMove;

	private void Start()
	{
	}

	private int GetFigureCreate()
	{
		return 0;
	}

	private void Update()
	{
	}

	public void TakeFigure(int _index, int _planet)
	{
	}

	private void Check()
	{
	}

	private void Finish()
	{
	}
}
