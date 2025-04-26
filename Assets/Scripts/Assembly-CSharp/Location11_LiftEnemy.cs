using MagicaCloth;
using UnityEngine;

public class Location11_LiftEnemy : MonoBehaviour
{
	private Vector3 position;

	private float timeFly;

	[SerializeField]
	[Header("Полет")]
	private AnimationCurve animationFly;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	[Header("Частицы")]
	private ParticleSystem particleShot;

	[SerializeField]
	private ParticleSystem particleDeathShot;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioScreeching;

	private bool kill;

	[Header("Анимация убийства")]
	[SerializeField]
	private Transform positionAnimation;

	[SerializeField]
	private GameObject[] colliders;

	private Location11_Lift main;

	private bool flyLose;

	private MagicaBoneCloth cloth;

	[HideInInspector]
	public int hp;

	public void StartComponent(Location11_Lift _main)
	{
	}

	private void Update()
	{
	}

	public void DamageHead()
	{
	}

	public void DamageBody()
	{
	}

	private void Death()
	{
	}

	private void Attack()
	{
	}

	public void FlyLose()
	{
	}
}
