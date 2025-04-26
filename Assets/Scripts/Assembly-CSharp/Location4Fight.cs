using UnityEngine;

public class Location4Fight : MonoBehaviour
{
	public bool win;

	public bool play;

	public bool playEnemy;

	private bool sidePlayer;

	[Header("Игроки")]
	public Location4Fight_Person playerMain;

	public Location4Fight_Person playerEnemy;

	[Header("Интерфейс")]
	public RectTransform lineHealthPlayer;

	public RectTransform lineHealthEnemy;

	public GameObject[] healthPointPlayer;

	public GameObject[] healthPointEnemy;

	public GameObject KO;

	public Transform backroundPosition;

	[Header("Настройки")]
	public float distanceWall;

	private bool winWas;

	private int winG;

	private int loseG;

	[Header("Сюжет")]
	public MinigamesTelevisionGame gameController;

	[Range(0f, 6f)]
	public int enemyComplexity;

	private float timeStartEnemy;

	private int moveJump;

	private float timeDontJump;

	private float timeDontMove;

	private float timeDontAttack;

	private float timeDontSit;

	private float timeDamage;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void EnemyGetDamage()
	{
	}

	public void UpdateInterface()
	{
	}

	public void Win(bool _x)
	{
	}

	public void Continue()
	{
	}

	[ContextMenu("Перезапустить игру")]
	public void ResetGame()
	{
	}

	public void GamePlay(bool x)
	{
	}
}
