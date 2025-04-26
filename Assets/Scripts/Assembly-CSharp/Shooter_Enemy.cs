using UnityEngine;
using UnityEngine.AI;

public class Shooter_Enemy : MonoBehaviour
{
	public enum TypeShooterEnemy
	{
		fight = 0,
		shoot = 1,
		health = 2,
		boss = 3
	}

	[SerializeField]
	private LayerMask layerShoot;

	private bool agressive;

	private float timeRandomWalk;

	[HideInInspector]
	public int shield;

	private float timeShield;

	private float healthOriginal;

	[SerializeField]
	[Header("Поведение")]
	private float health;

	[SerializeField]
	private float speedRun;

	public TypeShooterEnemy typeEnemy;

	[SerializeField]
	private GameObject itemDrop;

	[SerializeField]
	private Transform shieldObject;

	[SerializeField]
	private ParticleSystem shieldDestroy;

	[SerializeField]
	private ParticleSystem shieldDamage;

	[SerializeField]
	private GameObject objectDeath;

	private float timeCheckShoot;

	[Header("Стрелок")]
	[SerializeField]
	private Transform pointShoot;

	private bool needHeal;

	[Header("Хиллер")]
	[SerializeField]
	private AudioSource audioHeal;

	private Animator anim;

	private Vector2 animMove;

	private OffMeshLink link;

	private float oldLinkCost;

	private bool move;

	private NavMeshAgent nma;

	private float timeAniamtionJump;

	[SerializeField]
	[Header("Прыжок")]
	private AnimationCurve animationJumpUp;

	[SerializeField]
	private float speedJumpMove;

	[SerializeField]
	private ParticleSystem particleJumpFall;

	private float timeAnimationAttackNow;

	[Header("Атака")]
	[SerializeField]
	private float timeAnimationAttack;

	[SerializeField]
	private ParticleSystem particleAttack;

	[SerializeField]
	private Transform targetAttack;

	private Transform playerT;

	private Shooter_Main componentMain;

	private RaycastHit hit;

	private LayerMask layerFloor;

	[Header("Тело")]
	[SerializeField]
	private Shooter_Enemy_BodyPart[] bodyCollider;

	private int indexWasStep;

	private int indexWasJump;

	private int indexWasFall;

	private int indexWasShield;

	private AudioSource audios;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip[] soundsStep;

	[SerializeField]
	private AudioSource audioJump;

	[SerializeField]
	private AudioClip[] soundsJump;

	[SerializeField]
	private AudioClip[] soundsFall;

	[SerializeField]
	private AudioSource audioShield;

	[SerializeField]
	private AudioClip[] soundsShield;

	[SerializeField]
	private AudioClip[] soundsShieldDestroy;

	[SerializeField]
	private Audio_Data audioAttack;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void MoveStop()
	{
	}

	private void MoveToPoint(Vector3 _position)
	{
	}

	private void AcquireOffmeshLink()
	{
	}

	private void ReleaseOffmeshLink()
	{
	}

	private void OnDestroy()
	{
	}

	public bool Damage(float _damage)
	{
		return false;
	}

	private void Death()
	{
	}

	public void Attack()
	{
	}

	public void AttackSound()
	{
	}

	public void AttackShoot()
	{
	}

	public void Heal()
	{
	}

	public void Shield()
	{
	}

	public void Step()
	{
	}

	private void HeallerRun()
	{
	}

	private void ShooterRun()
	{
	}

	private bool CheckShoot()
	{
		return false;
	}

	private void Jump()
	{
	}

	private void Fall()
	{
	}
}
