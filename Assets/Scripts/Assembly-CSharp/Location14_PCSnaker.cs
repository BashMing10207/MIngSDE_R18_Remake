using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class Location14_PCSnaker : MonoBehaviour
{
	[SerializeField]
	private Location14_PCGames main;

	private int score;

	[Header("Интерфейс")]
	[SerializeField]
	private Text scoreApple;

	private GameObject apple;

	[Header("Объекты")]
	[SerializeField]
	private GameObject bodyPrefab;

	[SerializeField]
	private GameObject applePrefab;

	[SerializeField]
	private GameObject objectHit;

	[SerializeField]
	private GameObject lose;

	[SerializeField]
	private GameObject win;

	[SerializeField]
	private GameObject eat;

	private bool playNow;

	private float timeNextStep;

	private int directionMove;

	private List<GameObject> bodySnake;

	private List<int> snakePositionX;

	private List<int> snakePositionY;

	[Header("Змейка")]
	[SerializeField]
	private Sprite spriteHead;

	[SerializeField]
	private Sprite spriteTail;

	[SerializeField]
	private Sprite spriteBody;

	[SerializeField]
	private Sprite spriteBodyRotate;

	private List<List<int>> grid;

	private bool winScore;

	private float timeLose;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource snakeMove;

	[SerializeField]
	private AudioSource music;

	public void StartComponent()
	{
	}

	public void CloseGame()
	{
	}

	private void Update()
	{
	}

	private void NextStep()
	{
	}

	private void SnakeUpdate()
	{
	}

	private int CheckPositionForHead(int _posHeadX, int _posHeadY, int _rotHead)
	{
		return 0;
	}

	private void CreateApple()
	{
	}

	[Button("Перезапуск", EButtonEnableMode.Always)]
	private void RestartGame()
	{
	}

	private void Lose()
	{
	}
}
