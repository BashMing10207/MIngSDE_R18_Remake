using RootMotion.FinalIK;
using UnityEngine;

public class MenuMitaDance : MonoBehaviour
{
	public AudioSource audioMusicMain;

	public Transform mitaT;

	public float[] spectrum;

	private float angryMouse;

	[Header("Мышка и Мита")]
	public LayerMask layerMouse;

	public GameObject particleClick;

	[Header("Танец")]
	public float intensityDance;

	public int indexDance;

	public float speedLerp;

	[HideInInspector]
	public bool cloth;

	private float timeAnimationMitaCloth;

	private float timeAnimationCamReturn;

	private Animator mitaAnim;

	private float rotationPlace;

	private int rotateSide;

	private int animationNextOther;

	private bool mouseRotate;

	private float timeSpeedRotate;

	private bool ikHandUp;

	[Header("Одежда")]
	public Transform placeMita;

	public MenuMita mitaIK;

	public Animator animCam;

	public int maxOtherAnimation;

	public LimbIK limbRightHand;

	public LimbIK limbLeftHand;

	private bool description;

	private bool playDance;

	[HideInInspector]
	public float lerpJump;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayDance()
	{
	}

	public void ClothActive(bool x)
	{
	}

	public void Personage(bool x)
	{
	}

	public void ClickRotate(int _rotateSpeed)
	{
	}

	public void AnimationMita()
	{
	}
}
