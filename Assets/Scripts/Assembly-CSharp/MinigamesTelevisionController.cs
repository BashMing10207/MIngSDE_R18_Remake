using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MinigamesTelevisionController : MonoBehaviour
{
	private ResourceRequest loadResources;

	[Header("Общее")]
	[SerializeField]
	private Image blackScreen;

	[Header("Игры")]
	[SerializeField]
	private MinigamesTelevisionController_Game[] games;

	[SerializeField]
	private Transform screenGame;

	[SerializeField]
	private Transform interfaceKeys;

	private bool activation;

	private float timeActivation;

	[Header("Включение")]
	[SerializeField]
	private GameObject screenStarting;

	[SerializeField]
	private UnityEvent eventPlayedAll;

	[SerializeField]
	private GameObject dialogueStart;

	private int indexCaseChange;

	private bool menuActive;

	private bool canTalkAboutGame;

	private string textNeedNameGame;

	private Sprite spriteNeedBackground;

	private int countPlayed;

	[SerializeField]
	[Header("Меню")]
	private GameObject screenMenu;

	[SerializeField]
	private GameObject prefabCaseGame;

	[SerializeField]
	private Text nameGame;

	[SerializeField]
	private Image backgroundGame;

	[SerializeField]
	private Interface_KeyHint_Key[] keysMenu;

	[SerializeField]
	private GameObject[] dualogueGoNext;

	[SerializeField]
	[Header("Загрузка")]
	private GameObject screenLoading;

	[SerializeField]
	private RectTransform lineLoading;

	[SerializeField]
	[Header("Звуки")]
	private Audio_Data audioGamepadMita;

	[SerializeField]
	private Audio_Data audioGamepadPlayer;

	[SerializeField]
	private AudioSource audioStarting;

	[SerializeField]
	private AudioSource audioCase;

	[SerializeField]
	private AudioSource audioMenu;

	[SerializeField]
	private AudioSource audioLoading;

	[SerializeField]
	private AudioClip soundStart;

	[SerializeField]
	private AudioClip soundEnd;

	[SerializeField]
	private AudioClip soundCaseChange;

	[SerializeField]
	private AudioClip soundCaseReturn;

	[SerializeField]
	[Header("Установки")]
	private bool destroyAfter;

	[SerializeField]
	private bool playerWait;

	private void Update()
	{
	}

	[ContextMenu("Включить телевизор")]
	public void StartTelevision()
	{
	}

	public void StopTelevision()
	{
	}

	public void StartFinishTelevision()
	{
	}

	public void CanTalkAboutGame(bool x)
	{
	}

	public void StartMenu()
	{
	}

	public void StartControllerMenu()
	{
	}

	public void PlayerReady()
	{
	}

	private void StartLoadGame(string _nameResources)
	{
	}

	private void StartGame()
	{
	}

	public void TalkReadyListener()
	{
	}

	public void KeysMenuActive(bool x)
	{
	}

	public void KeysMenuActiveTrue()
	{
	}

	public void ChangeGame()
	{
	}

	private void ClearCases()
	{
	}

	private void TelevisionDisable()
	{
	}

	public void PlayGame()
	{
	}

	public void GameWin(UnityAction call)
	{
	}

	public void GameLose(UnityAction call)
	{
	}

	public void GameDraw(UnityAction call)
	{
	}

	public void CaseMove(bool _right)
	{
	}

	public void AudioGamepad(bool _player)
	{
	}
}
