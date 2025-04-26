using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location19_GlitchGame : MonoBehaviour
{
	private WorldPlayer componentWP;

	private int timeCast;

	[HideInInspector]
	public GameObject castObject;

	private float opacityHand;

	[HideInInspector]
	public bool play;

	private Camera cameraT;

	private bool otherUseHand;

	private float cameraNoise;

	[HideInInspector]
	public bool finish;

	[HideInInspector]
	public Vector3 positionCamera;

	[SerializeField]
	private Renderer rendReflection;

	[Header("Игра")]
	[SerializeField]
	private GameObject objectGame;

	[SerializeField]
	private Transform cameraTarget;

	public LayerMask layerCast;

	[HideInInspector]
	public bool handUse;

	[HideInInspector]
	public Vector3 positionHand;

	[Header("Рука в игре")]
	public Transform handPlayer;

	[SerializeField]
	private SkinnedMeshRenderer meshHand;

	public Transform castHand;

	public Vector3 handAddPosition;

	[SerializeField]
	private Vector3 startHandPosition;

	[HideInInspector]
	public float timeStartGame;

	[SerializeField]
	[Header("Анимации")]
	private ObjectAnimationPlayer animationKick;

	[SerializeField]
	private ObjectAnimationPlayer animationReady;

	[SerializeField]
	private AnimationCurve animationHandLerp;

	private float timeAnimationHandLerp;

	private float timeAnimationPositionCamera;

	private float timeAnimationFOVCamera;

	private AnimationCurve animationCamera;

	private Vector3 cameraWas;

	private Vector3 cameraNeed;

	private float cameraFovWas;

	private float cameraFovNeed;

	private RectTransform lineKick;

	[Header("Интерфейс")]
	[HideInInspector]
	public Image imageScreen;

	[SerializeField]
	private Animator animKick;

	private bool kickCan;

	[Header("События")]
	[SerializeField]
	private UnityEvent eventPlay;

	[SerializeField]
	private UnityEvent eventReady;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool CastObject(GameObject _objectCast)
	{
		return false;
	}

	public void StartKick()
	{
	}

	[ContextMenu("Запустить игру")]
	public void PlayGame()
	{
	}

	public void StopGame()
	{
	}

	public void CameraNoise(float x)
	{
	}

	public void Finish(Vector3 _positionEndHand, float _cameraFov, Vector3 _positionCamera)
	{
	}

	public void UseHandPosition(bool x)
	{
	}
}
