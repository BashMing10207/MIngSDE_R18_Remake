using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class CarSpace_Boss : MonoBehaviour
{
	[SerializeField]
	private CarSpace_Main main;

	private CarSpace_Car playerCarController;

	[SerializeField]
	private Transform playerCar;

	[SerializeField]
	private Transform boss;

	private int roketIndexCreate;

	private float timeAttackRoket;

	private float timeRoketStart;

	private Color colorRoket;

	[SerializeField]
	[Header("Ракеты")]
	private GameObject roketPrefab;

	[SerializeField]
	private MeshRenderer meshRoket;

	private int laserCountShoot;

	private float timeAttackLaser;

	private int laserIndexAttack;

	private float laserTimeShoot;

	private List<Color> colorsLaser;

	private float timeLaserSmoke;

	private float timeLaserPlace;

	[Header("Лазеры")]
	[SerializeField]
	private MeshRenderer[] meshLaser;

	[SerializeField]
	private SpriteRenderer[] spriteLaser;

	[SerializeField]
	private ParticleSystem particleLaserSmoke;

	[SerializeField]
	private ParticleSystem particleLaserShoot;

	[SerializeField]
	private Audio_Data laserAudioShoot;

	private float timeCrystallNext;

	private float timeCrystall;

	[SerializeField]
	[Header("Кристаллы")]
	private GameObject prefabCrystall;

	[SerializeField]
	[Header("Сканироващик")]
	private CarSpace_Scanner scanner;

	[SerializeField]
	private ParticleSystem scannerParticle;

	[SerializeField]
	private AudioClip[] scannerSounds;

	private int indexAttack;

	private bool attack;

	private float timeAttackStart;

	private float snake;

	private Vector3 snakePosition;

	private float snakeUpdate;

	private float timeAnimationPosition;

	private float timeAnimationUp;

	[SerializeField]
	[Header("Анимация")]
	private AnimationCurve animationPosition;

	[SerializeField]
	private AnimationCurve animationLerp;

	[SerializeField]
	private AnimationCurve animationBlinking;

	[SerializeField]
	private ParticleSystem particleDamage;

	private bool death;

	private void Start()
	{
	}

	public void Restart()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void CreateCrystall(float _position)
	{
	}

	private void LaserShoot()
	{
	}

	private void CreateRoket()
	{
	}

	[Button("Ракеты", EButtonEnableMode.Always)]
	private void AttackRoket()
	{
	}

	[Button("Лазеры", EButtonEnableMode.Always)]
	private void AttackLaser()
	{
	}

	[Button("Кристаллы", EButtonEnableMode.Always)]
	private void AttackCrystall()
	{
	}

	[Button("Сканироващик", EButtonEnableMode.Always)]
	private void AttackScanner()
	{
	}

	public void ScannerFinish()
	{
	}

	[Button("Получает урон", EButtonEnableMode.Always)]
	public void Damage()
	{
	}
}
