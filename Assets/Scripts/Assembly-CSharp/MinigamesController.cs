using UnityEngine;
using UnityEngine.Events;

public class MinigamesController : MonoBehaviour
{
	private MinigamesAutomate gameAutomate;

	private float timeGame;

	[SerializeField]
	private bool isScene;

	public GameObject worldObject;

	public GameObject playerObject;

	public GameObject cameraObject;

	public LayerMask layerDefault;

	[Header("Туман и освещение")]
	[SerializeField]
	[ColorUsage(false)]
	private Color colorRenderer;

	[SerializeField]
	private float distanceShadow;

	[SerializeField]
	private bool fog;

	[SerializeField]
	[ColorUsage(false)]
	private Color colorFog;

	[SerializeField]
	private float fogStart;

	[SerializeField]
	private float fogEnd;

	private float fastMenuTimeWas;

	private bool fastMenu;

	private Component[] soundsPause;

	private bool exitGameGo;

	private bool mouseVisibleWas;

	private CursorLockMode mouseLockWas;

	[HideInInspector]
	public float timeAfterFastmenu;

	[Header("Быстрое меню")]
	public GameObject fastMenuMain;

	[SerializeField]
	private UnityEvent eventExitFastmenu;

	[SerializeField]
	[Header("Начальные настройки")]
	private bool onStartVisibleCursor;

	private void Awake()
	{
	}

	public void StartGame(MinigamesAutomate _automate)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void FastMenu()
	{
	}

	public void GameFinish()
	{
	}

	public void ExitGame()
	{
	}
}
