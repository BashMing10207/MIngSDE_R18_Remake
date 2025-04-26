using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class Shooter_Player : MonoBehaviour
{
	[Range(0f, 100f)]
	[SerializeField]
	private float health;

	[SerializeField]
	private MinigamesController mainMinigame;

	private float timeVignette;

	private AnimationCurve animationVignette;

	private Vector3 positionDamageLast;

	[Header("Интерфейс")]
	[SerializeField]
	private RectTransform lineHealth;

	[SerializeField]
	private Image crosshireDamage;

	[SerializeField]
	private GameObject crosshireEnemy;

	[SerializeField]
	private Image imgVignette;

	[SerializeField]
	private Image imgScreen;

	[SerializeField]
	private Animator heart;

	[SerializeField]
	private Image kill;

	[SerializeField]
	private Text textHealth;

	[SerializeField]
	private Image imagePositionDamage;

	private bool win;

	private bool death;

	private float timeCanJump;

	[Header("Игрок")]
	[SerializeField]
	private float speed;

	[SerializeField]
	private float jump;

	[SerializeField]
	private Transform head;

	[SerializeField]
	private Transform respawn;

	private Rigidbody rb;

	private RaycastHit hit;

	private float gravity;

	[Header("Физика")]
	[SerializeField]
	private LayerMask layerFloor;

	[SerializeField]
	private LayerMask layerShoot;

	private float animationWalkIntensity;

	private float timeAnimationWalk;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve armsWalkVertical;

	[SerializeField]
	private AnimationCurve armsWalkHorizontal;

	private Vector3 moveController;

	private Vector3 moveControllerFix;

	private Vector2 rotNoise;

	private float timeCameraFreeze;

	private float rotX;

	private float rotY;

	private float timeFly;

	private float timeJump;

	private bool fly;

	private float timeShot;

	private float timeShootSmoke;

	private Vector3 rotateArms;

	[Header("Оружие")]
	[SerializeField]
	private ParticleSystem particleShoot;

	[SerializeField]
	private ParticleSystem particleSmoke;

	[SerializeField]
	private Transform arms;

	[SerializeField]
	private GameObject bullet;

	[SerializeField]
	private GameObject particleDamageHead;

	private int soundWasJump;

	private int soundWasDamage;

	private int soundWasShot;

	private int soundWasStep;

	private int materialFloor;

	private float timeStep;

	private AudioSource audioPlayer;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioRotate;

	[SerializeField]
	private AudioClip[] sounds;

	[SerializeField]
	private AudioClip[] soundsJump;

	[SerializeField]
	private AudioClip[] soundsDamage;

	[SerializeField]
	private AudioClip[] soundsShot;

	[SerializeField]
	private AudioSource audioStep;

	[SerializeField]
	private AudioSource audioStepFall;

	[SerializeField]
	private AudioClip[] soundsStepDirt;

	[SerializeField]
	private AudioClip[] soundsStepLava;

	[SerializeField]
	private AudioClip[] soundsStepIron;

	[SerializeField]
	private AudioSource audioLavaDamage;

	[SerializeField]
	private AudioSource audioHeal;

	private float cameraHit;

	private float lavaTime;

	private Shooter_Main scrmain;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Win()
	{
	}

	private void Shoot()
	{
	}

	private void Kill()
	{
	}

	private void Jump()
	{
	}

	private void Landed(GameObject _objectLand)
	{
	}

	public void CameraHit(float x)
	{
	}

	private void Step()
	{
	}

	private void UpdateInterface()
	{
	}

	public void Health()
	{
	}

	public void Damage(Vector3 _positionDamage)
	{
	}

	[Button("Смерть", EButtonEnableMode.Always)]
	public void Death()
	{
	}

	[Button("Респавн", EButtonEnableMode.Always)]
	public void Respawn()
	{
	}

	private void RespawnPosition()
	{
	}
}
