using UnityEngine;
using UnityEngine.Events;

public class Metroidvania_Player : MonoBehaviour
{
	[Header("Настройка управления")]
	public float speedRun;

	public float intensityJump;

	[Header("Игра")]
	public Metroidvania_Camera cameraGame;

	private float gravity;

	private Rigidbody rb;

	private RaycastHit hit;

	[Header("Физика")]
	public LayerMask layerFloor;

	private bool fly;

	private float moveH;

	private float speedMoveH;

	private float timeMoveH;

	private float timeMoveHStop;

	private float timeMove;

	private bool side;

	private float timeJump;

	private bool canJump;

	private bool animationRun;

	private Vector3 positionAnimation;

	private UnityEvent eventAnimationFinish;

	private AnimationClip animationStart;

	private AnimationClip animationLoop;

	private AnimationClip animationFinish;

	[Header("Анимация")]
	public Animator anim;

	[Header("Частицы")]
	public ParticleSystem particleJump;

	public ParticleSystem particleStop;

	public ParticleSystem particleFall;

	private TypeMaterial typeMaterialNow;

	private int lastIntStep;

	[Header("Шаги")]
	public AudioSource audioStep;

	public FootSoundsTypes soundsStep;

	[Header("Стрельба")]
	public LayerMask layerShot;

	public GameObject exampleShot;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Animation()
	{
	}

	private void Jump()
	{
	}

	private void Fall()
	{
	}

	public void AnimationPlay(Vector3 _position, AnimationClip _animationStart, AnimationClip _animationLoop, AnimationClip _animationFinish, UnityEvent _eventAnimationFinish)
	{
	}

	public void Step()
	{
	}

	public void Shot()
	{
	}

	private AudioClip RandomStepCorrect(AudioClip[] _sounds)
	{
		return null;
	}
}
