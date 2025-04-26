using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MinigamesAutomate : MonoBehaviour
{
	[HideInInspector]
	public bool finish;

	private GameObject game;

	[Header("Игра")]
	[SerializeField]
	private string resourceGame;

	[SerializeField]
	private Vector3 positionCreateGame;

	[SerializeField]
	private string sceneGame;

	private bool finishReady;

	[SerializeField]
	[Header("События")]
	private UnityEvent eventStartGame;

	[SerializeField]
	private UnityEvent eventFinishGame;

	[SerializeField]
	private UnityEvent eventStopGame;

	[SerializeField]
	private GameObject[] objectDeactive;

	[SerializeField]
	private GameObject[] objectsVisual;

	[Header("Игровой автомат")]
	[SerializeField]
	private bool destroyInteractiveOnFinish;

	[SerializeField]
	private GameObject interactive;

	private bool interfaceShow;

	[Header("Интерфейс")]
	[SerializeField]
	private RectTransform lineLoading;

	[SerializeField]
	private GameObject interfaceMain;

	[SerializeField]
	private Image blackScreen;

	[SerializeField]
	private Text textLoadingInfo;

	private int screenNext;

	[SerializeField]
	[Header("Глобальный интерфейс")]
	private Image screen;

	private Color colorRenderer;

	private Color fogColor;

	private bool fog;

	private float fogStart;

	private float fogEnd;

	private AudioSource audioLoading;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioPlayer;

	[SerializeField]
	private AudioSource audioScreen;

	[SerializeField]
	private AudioClip soundScreenOn;

	[SerializeField]
	private AudioClip soundScreenOff;

	[SerializeField]
	private AudioClip soundLoading;

	[SerializeField]
	private AudioClip soundLoadingReady;

	[SerializeField]
	private AudioClip soundPlayerOut;

	private bool exitGame;

	private bool loading;

	private float timeLoadingReady;

	private ResourceRequest asyncLoading;

	private bool isScene;

	private AsyncOperation asyncLoadingScene;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartLoading()
	{
	}

	public void StartGame()
	{
	}

	public void StopGame()
	{
	}

	public void StartStopGame()
	{
	}

	private void PlayerHide(bool x)
	{
	}

	public void AnimationOffInterface()
	{
	}
}
