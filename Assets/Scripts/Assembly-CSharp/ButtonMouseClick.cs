using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ButtonMouseClick : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	public ButtonMouseMenu menuButton;

	public bool interactable;

	public GameObject[] elements;

	public bool toggleSound;

	public bool offSound;

	public UnityEvent eventClick;

	public UnityEvent eventEnter;

	public UnityEvent eventExit;

	public UnityEvent eventUp;

	[Header("Переключение")]
	public ButtonMouseClick changeUp;

	public ButtonMouseClick changeDown;

	public ButtonMouseClick changeLeft;

	public ButtonMouseClick changeRight;

	[Header("Цвета")]
	public Color colorEnter;

	public Color colorExit;

	private bool stopKey;

	private bool firstStart;

	[HideInInspector]
	public bool changeNow;

	private float timeAnimation;

	private bool lockButton;

	private RectTransform change;

	private int timeStart;

	public void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void keyDown()
	{
	}

	public void LockClick(bool x)
	{
	}

	public void ActivationInteractive(bool x)
	{
	}

	public void PointerExit()
	{
	}

	public void PointerEnter()
	{
	}

	public void PointerDown()
	{
	}

	public void PointerUp()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}
}
