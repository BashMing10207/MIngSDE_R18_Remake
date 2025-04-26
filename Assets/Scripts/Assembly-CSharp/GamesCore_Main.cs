using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GamesCore_Main : MonoBehaviour
{
	private float timeInstantiate;

	private int indexInstantiate;

	[SerializeField]
	[Header("Запуск программы ---------")]
	private GameObject screenStart;

	private bool playEntry;

	private int countChangesSphere;

	private Vector2 vectorOffsetLine;

	private bool entryReady;

	private float timeEntryReady;

	[SerializeField]
	[Header("Подтверждения входа ------")]
	private GameObject screenEntry;

	[SerializeField]
	private RectTransform sphereChange;

	[SerializeField]
	private GamesCore_Main_Sphere[] spheres;

	[SerializeField]
	private Sprite spheresActive;

	[SerializeField]
	private Sprite spheresDeactive;

	[SerializeField]
	private AudioSource audioApplyCircle;

	private int coutDontEntry;

	[Header("Вход не подтвержден ------")]
	[SerializeField]
	private GameObject screenDontEntry;

	[SerializeField]
	private UnityEvent eventTwoDontEntry;

	private bool playFolder;

	private float timeAnimationChangerPointer;

	private AnimationCurve animationChangerPointer;

	private int positionYFolderCreate;

	private GamesCore_Main_Folder foldersCreate;

	private List<GameObject> foldersInstantiate;

	private GameObject foldersLocationInstantite;

	private Text changerFolderPointer;

	private int indexDialoguePlayer;

	private bool speakPlayerNow;

	private int countFolder;

	[Header("Выбор папок ---------------")]
	[SerializeField]
	private GameObject screenFolders;

	[SerializeField]
	private GamesCore_Main_Folder[] folders;

	[SerializeField]
	private GameObject prefabFolder;

	[SerializeField]
	private GameObject prefabLocationFolder;

	[SerializeField]
	private RectTransform foldersChanger;

	[SerializeField]
	private AudioSource audioApplyFolder;

	[SerializeField]
	private GameObject[] dialoguePlayerNotFolder;

	[Header("Ввод -----------------------")]
	[SerializeField]
	private GameObject screenInput;

	[SerializeField]
	private UnityEvent eventRightMitaVersion;

	[SerializeField]
	private GameObject[] dialoguePlayerWrongVersion;

	[SerializeField]
	private UnityEvent eventRightIndexVersion;

	[SerializeField]
	private GameObject[] dialoguePlayerWrongIndex;

	[Header("Логи -----------------")]
	[SerializeField]
	private Text textLog;

	[Header("Флешка ----------------")]
	[SerializeField]
	private bool flash;

	[SerializeField]
	private GameObject interfaceFlash;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartProgramma()
	{
	}

	public void StopProgramma()
	{
	}

	public void StartEntry()
	{
	}

	public void StartEntryCircles()
	{
	}

	private void ClearSpheres()
	{
	}

	private void UpdateChangerCphere()
	{
	}

	public void StartFolders()
	{
	}

	private void OpenFolder(GamesCore_Main_Folder _folder)
	{
	}

	private void ClearFolders()
	{
	}

	private void UpdateChangerFolder()
	{
	}

	public void PlayerFinishSpeak()
	{
	}

	public void ClickFlash()
	{
	}

	public void StartVersionMita()
	{
	}

	public void WrongVersion()
	{
	}

	public void StartIndex()
	{
	}

	public void WrongIndex()
	{
	}

	public void HeartHit()
	{
	}
}
