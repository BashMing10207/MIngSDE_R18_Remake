using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Location18_ButtonPointer : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	[SerializeField]
	private UnityEvent eventDown;

	[SerializeField]
	private AudioClip soundClick;

	private bool active;

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void OnEnable()
	{
	}

	private void ColorPointer(bool x)
	{
	}

	public void Hide(bool x)
	{
	}

	public void HideDestroy()
	{
	}
}
