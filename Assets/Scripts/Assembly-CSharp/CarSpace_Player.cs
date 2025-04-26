using Colorful;
using UnityEngine;
using UnityEngine.UI;

public class CarSpace_Player : MonoBehaviour
{
	private bool inputDownSide;

	private bool play;

	[HideInInspector]
	public float speedCamera;

	private Vector3 positionLast;

	private float speedCameraLerp;

	private float snakeCamera;

	private bool finishEnd;

	[Header("Объекты")]
	public Transform car;

	public Transform cameraT;

	[Header("Частицы")]
	[SerializeField]
	private Transform particlesWorld;

	[SerializeField]
	[Header("Прочее")]
	private CarSpace_Music musicWorld;

	private float timeAnimationCamera;

	private bool boss;

	[Header("Интерфейс")]
	[SerializeField]
	private GameObject nitroObject;

	[SerializeField]
	private Image nitroLineReset;

	private CarSpace_Car carController;

	private RadialBlur efxRadialBlur;

	private bool nitroCan;

	[HideInInspector]
	public float nitro;

	private float nitroUseNow;

	private Camera cameraView;

	private float addDOV;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Play(bool x)
	{
	}

	public void AnimationCamera()
	{
	}

	public void SnakeCamera(float _intensity)
	{
	}

	public void NitroCan(bool x)
	{
	}

	public void RestartRacing()
	{
	}

	public void TeleportBoss()
	{
	}

	public void RestartBoss()
	{
	}

	public void FinishEnd()
	{
	}
}
