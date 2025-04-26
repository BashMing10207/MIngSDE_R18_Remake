using System.Collections.Generic;
using UnityEngine;

public class Location19_Game4 : MonoBehaviour
{
	private RaycastHit hit;

	[SerializeField]
	private Location19_GlitchGame main;

	private float timeAnimationCamera;

	[SerializeField]
	[Header("Камера")]
	private Transform cameraTarget;

	[SerializeField]
	private AnimationCurve cameraAnimation;

	[HideInInspector]
	public List<GameObject> createObjects;

	[Header("Кораблики")]
	[SerializeField]
	private Location19_Game4_ShipContol[] ships;

	[SerializeField]
	private GameObject wallPrefab;

	[SerializeField]
	private GameObject shipPrefab;

	[SerializeField]
	private GameObject particleDestroyShip;

	[SerializeField]
	private GameObject particleDamageShip;

	[SerializeField]
	private GameObject particleBullet;

	[SerializeField]
	private AnimationCurve animationRotateDamageShip;

	private float timeShot;

	[Header("Выстрел")]
	[SerializeField]
	private Transform positionShot;

	[SerializeField]
	private ParticleSystem particleShot;

	[SerializeField]
	private LineRenderer lineShot;

	[SerializeField]
	private ParticleSystem particleShotBack;

	[SerializeField]
	private GameObject sphereReady;

	[SerializeField]
	private ParticleSystem particlePreShot;

	private float timeRestart;

	private float timeLimitHand;

	[Header("Рука")]
	[SerializeField]
	private Transform hand;

	[SerializeField]
	private AnimationCurve animationLimit;

	private bool gameFinish;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void Shot()
	{
	}

	public void Death()
	{
	}

	private void RestartWorld()
	{
	}

	private void Finish()
	{
	}
}
