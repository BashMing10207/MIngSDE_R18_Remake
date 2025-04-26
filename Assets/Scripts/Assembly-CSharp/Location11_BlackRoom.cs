using System.Collections.Generic;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

public class Location11_BlackRoom : MonoBehaviour
{
	public GameObject roomExample;

	[SerializeField]
	private GameObject[] destroysRepeatStart;

	[SerializeField]
	private Transform doorRepeat;

	[SerializeField]
	private ObjectDoor doorA;

	[SerializeField]
	private ObjectDoor doorB;

	[SerializeField]
	private Transform mitaBlack;

	private float speedMouse;

	private int indexPuzleWork;

	[SerializeField]
	[Header("За столом")]
	private Location11_BlackRoom_Puzle[] framesFound;

	[SerializeField]
	private GameObject interactiveTable;

	[SerializeField]
	private Transform puzleGame;

	private float timeStartPuzle;

	[Header("Положить части пазл")]
	[SerializeField]
	private AudioClip[] soundsPaperMove;

	[SerializeField]
	private ObjectAnimationPlayer animationAddPaper;

	[SerializeField]
	private GameObject[] itemKeyPuzzles;

	[SerializeField]
	private WorldPlayer componentWorldPlayer;

	private int indexPuzleHold;

	private float timeStartPlayPuzle;

	private bool playPuzle;

	[SerializeField]
	[Header("Собирает картинку")]
	private Interface_KeyHint_Key buttonExit;

	[SerializeField]
	private LayerMask mouseOverLayer;

	[SerializeField]
	private GameObject mouseOverPlane;

	[SerializeField]
	private AnimationCurve animationStackPuzle;

	private bool glueWork;

	private float timePaperForGlue;

	[Header("Использование клея")]
	[SerializeField]
	private AnimationCurve animationStartWorkGlue;

	private float timeAnimationStartWorkGlue;

	[SerializeField]
	private ObjectAnimationPlayer animationGlueTake;

	[SerializeField]
	private ObjectAnimationPlayer animationGlueFinish;

	[SerializeField]
	private GameObject objectPaperForGlue;

	[SerializeField]
	private LineRenderer[] linesForGlue;

	[SerializeField]
	private Transform pointNeedleGlue;

	[SerializeField]
	private UnityEvent eventReadyGlue;

	[SerializeField]
	private AudioClip[] gluePut;

	private FullBodyBipedIK scrfbbik;

	private Transform rightElbowPlayerIK;

	[SerializeField]
	[Header("IK игрока")]
	private Transform rightHandPlayer;

	[SerializeField]
	private Transform rightElbowPlayer;

	[SerializeField]
	private Vector3 rotationHandPuzleWork;

	[SerializeField]
	private Vector3 positionHandPuzleWork;

	[Header("Телепорт игрока")]
	[SerializeField]
	private Transform positionTP;

	[SerializeField]
	private Transform animationPlayerOpenScarf;

	private DataValues_Objects objectsOriginal;

	private DataValues_Objects objectsClone;

	[HideInInspector]
	public GameObject roomRepeat;

	[Header("Комната")]
	[SerializeField]
	private Transform[] duplicateData;

	private Vector3 positionMouseAdd;

	private Vector3 positionMouse;

	private GameObject mitaBlackCopy;

	private List<SkinnedMeshRenderer> meshes;

	private List<SkinnedMeshRenderer> meshesAura;

	private float timeColorMita;

	private bool colorReady;

	[Header("Раскраска")]
	[SerializeField]
	private AnimationCurve animationDraw;

	private float timeDoorClose;

	private Transform playerT;

	private bool startRepeat;

	private bool playerInRoomPlay;

	[HideInInspector]
	public GameController scrgc;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void RepeatUpdate()
	{
	}

	private void StartRepeat()
	{
	}

	public void PlayerOpenScarf()
	{
	}

	public void PlayerStartRoom()
	{
	}

	public void AddFrame(int x)
	{
	}

	public void PlayerSit()
	{
	}

	private bool CheckPuzleAdd()
	{
		return false;
	}

	public void PutPuzle()
	{
	}

	public void ExitTable()
	{
	}

	public void PuzleTake(int _indexPuzle)
	{
	}

	public void PuzleDrop()
	{
	}

	private void PuzleReady()
	{
	}

	public void StartWorkGlue()
	{
	}

	private void GlueReady()
	{
	}

	public void MitaColorStart()
	{
	}

	public void MitaDestroyEyes()
	{
	}
}
