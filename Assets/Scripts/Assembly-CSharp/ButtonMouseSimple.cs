using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ButtonMouseSimple : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	public UnityEvent eventClick;

	public UnityEvent eventEnter;

	public UnityEvent eventExit;

	public UnityEvent eventUp;

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
