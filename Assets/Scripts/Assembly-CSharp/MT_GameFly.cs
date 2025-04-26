using System.Collections.Generic;
using UnityEngine;

public class MT_GameFly : MonoBehaviour
{
	[SerializeField]
	private MinigamesTelevisionGame main;

	[Header("Интерфейс")]
	[SerializeField]
	private List<GameObject> heartsPlayer;

	[SerializeField]
	private List<GameObject> heartsMita;

	[Header("Игра")]
	[SerializeField]
	private GameObject playerShip;

	[SerializeField]
	private GameObject mitaShip;

	[SerializeField]
	private MT_GameFly_Wave[] waves;

	private bool waveNow;

	private float timeWave;

	private int indexWaveNow;

	private float timeNextWave;

	private int countCreateShipEnemy;

	[HideInInspector]
	public List<GameObject> shipsEnemy;

	[HideInInspector]
	public List<GameObject> bulletEnemy;

	private float snakingCamera;

	[Header("Мир")]
	[SerializeField]
	private Transform world;

	[SerializeField]
	private Transform cameraT;

	private bool lose;

	private bool win;

	private float timeWin;

	private float timeLose;

	[Header("Победа и поражение")]
	[SerializeField]
	private GameObject objectWin;

	[SerializeField]
	private GameObject objectLose;

	[Header("Звук")]
	public AudioSource audioPlayer;

	public AudioSource audioPlayerMove;

	public AudioSource audioPlayerDamage;

	public AudioSource audioMita;

	public AudioSource audioMitaMove;

	public AudioSource audioMitaDamage;

	public AudioSource audioEnemyShot;

	public AudioSource audioEnemyDamage;

	public AudioSource audioEnemyExplode;

	public AudioClip[] soundsShotPlayer;

	public AudioClip[] sounds;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool DamagePlayer(bool _isMita)
	{
		return false;
	}

	public void ShakingCamera(float x)
	{
	}

	public void NextWave()
	{
	}

	public void Play()
	{
	}

	public void DeleteShip(GameObject _objectShip)
	{
	}

	private void Win()
	{
	}

	private void Lose()
	{
	}

	public void ExplodePlayerShip(bool _isMita)
	{
	}
}
