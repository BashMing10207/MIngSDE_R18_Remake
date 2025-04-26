using EPOOutline;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Outlinable))]
public class ObjectInteractive : MonoBehaviour
{
	private Outlinable outline;

	private Color clrOutline;

	private PlayerMove scrpm;

	private GameController scrgc;

	public bool active;

	public bool ignoryAnimationHand;

	[SerializeField]
	private float timeDeactive;

	private float timeDeactiveNow;

	public UnityEvent eventClick;

	[Header("Ссылка на объект")]
	[SerializeField]
	private GameObject objectInteractive;

	[HideInInspector]
	public bool interactiveIK;

	[Header("Дополнительные настройки")]
	[SerializeField]
	private bool destroyObjectInteractive;

	[SerializeField]
	private bool destroyComponent;

	[SerializeField]
	private bool deactiveObject;

	public float distanceFloor;

	private bool castNow;

	[HideInInspector]
	public ObjectInteractive_CaseInfo caseInfo;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Click()
	{
	}

	public void Activation(bool x)
	{
	}

	public void ActivationTime(float _x)
	{
	}

	public void DestroyObject()
	{
	}

	public void OnDisable()
	{
	}

	public void OnEnable()
	{
	}
}
