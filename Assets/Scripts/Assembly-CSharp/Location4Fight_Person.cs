using UnityEngine;

public class Location4Fight_Person : MonoBehaviour
{
	public Location4Fight main;

	public bool side;

	public ParticleSystem getDamageParticle;

	public ParticleSystem fallParticle;

	public Transform enemy;

	[HideInInspector]
	public float timeAttack;

	[HideInInspector]
	public bool sit;

	private float sitF;

	private float moveF;

	private float gravityY;

	private int move;

	private float moveDamage;

	private float timeStopMove;

	private float timeDamage;

	private float timeJumping;

	private float timeRendLight;

	[Header("Анимация")]
	public Animator anim;

	public Renderer rend;

	private BoxCollider box;

	[HideInInspector]
	public bool death;

	[Header("Настройки")]
	public int damage;

	public float health;

	public Vector3 positionAttack;

	public LayerMask layerAttack;

	[Header("Движение")]
	public float jump;

	public float gravitySpeed;

	public float speed;

	[Header("звуки")]
	public AudioSource audioDeath;

	public AudioSource audioStep;

	public AudioClip[] soundsStep;

	public AudioSource audioMove;

	public AudioClip soundJump;

	public AudioClip soundFall;

	public AudioSource audioWing;

	public AudioClip soundWing;

	public AudioClip soundHit;

	[Header("Дополнения")]
	public Transform shadow;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void Kick()
	{
	}

	public void Jump()
	{
	}

	public void Sit(bool _x)
	{
	}

	public void Move(int x)
	{
	}

	public void Damage(int _damage)
	{
	}

	private void Attack(Vector3 _position)
	{
	}

	public void ReSide(bool x)
	{
	}

	public void ResetPerson()
	{
	}

	public void AttackTrigger()
	{
	}

	public void AttackTriggerSit()
	{
	}

	public void Step()
	{
	}

	public void Wing()
	{
	}
}
