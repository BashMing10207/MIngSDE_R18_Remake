using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TetrisGame : MonoBehaviour
{
	private float positionDefeatRandom;

	[Header("Интерфейс")]
	public Text textScore;

	public RectTransform textDefeat;

	public GameObject game;

	public GameObject defeat;

	private bool dontplay;

	private bool play;

	private float timeNextSpeed;

	private int score;

	private float speed;

	private Vector2 move;

	private float timeUpdateArray;

	private int timeCreateMoney;

	private int timeCreateDecoration;

	private int timeCreateEnemy;

	[Header("Игровые объекты")]
	public RectTransform background;

	public GameObject player;

	public GameObject enemy;

	public GameObject money;

	public GameObject decoration;

	public Sprite[] spritesDecoration;

	[Header("Звуки")]
	public AudioSource audioMoney;

	public AudioSource audioRemove;

	private float timeAutoRestart;

	private bool autoPlay;

	[Space(20f)]
	public List<GameObject> obejctsGameMove;

	public List<GameObject> obejctsEnemy;

	public List<GameObject> obejctsMoney;

	private void Update()
	{
	}

	[ContextMenu("Рестарт")]
	private void ScoreAdd(int x)
	{
	}

	private void RestartGame()
	{
	}

	private void ClearObejcts()
	{
	}

	private void UpdateArray()
	{
	}

	private void Death()
	{
	}

	public void StartRestart()
	{
	}

	public void DontPlay()
	{
	}
}
