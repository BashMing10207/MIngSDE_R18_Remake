using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location4ChangeSide : MonoBehaviour
{
	[SerializeField]
	private Transform CaseNo;

	[SerializeField]
	private Transform CaseYes;

	[SerializeField]
	private UnityEvent eventYes;

	[SerializeField]
	private UnityEvent eventNo;

	[Header("Интерфейс")]
	[SerializeField]
	private UI_Colors tasks;

	[SerializeField]
	private Sprite spriteReadyTask;

	[SerializeField]
	private GameObject objectLock;

	[SerializeField]
	private RectTransform rectTasks;

	[SerializeField]
	private Image[] taskSprites;

	private float timeAnimationLock;

	[Header("Замок")]
	[SerializeField]
	private AnimationCurve animationScaleLock;

	private bool lockYes;

	private Vector3 positionOriginNo;

	private Vector3 positionOriginNoNoise;

	private float timeUpdateNoNoise;

	public static bool nolookstove;

	public static bool takemagnetfridge;

	public static bool nolookventil;

	public static bool trysous;

	public static bool playconsole;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ChangeYes()
	{
	}

	public void ChangeNo()
	{
	}

	private void Click()
	{
	}

	public void CheckConditions()
	{
	}

	public static void ResetData()
	{
	}
}
