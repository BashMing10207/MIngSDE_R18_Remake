using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonMouseColor : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	private Image img;

	[SerializeField]
	private UnityEvent eventClick;

	[SerializeField]
	private UnityEvent eventEnter;

	[SerializeField]
	private UnityEvent eventExit;

	[SerializeField]
	private UnityEvent eventUp;

	[SerializeField]
	private Color colorEnter;

	[SerializeField]
	private Color colorExit;

	private void OnEnable()
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

	public void ColorRechange(Color _colorEnter, Color _colorExit, bool _update)
	{
	}
}
