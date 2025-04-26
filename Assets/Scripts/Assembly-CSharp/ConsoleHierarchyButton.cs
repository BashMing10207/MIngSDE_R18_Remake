using UnityEngine;
using UnityEngine.EventSystems;

public class ConsoleHierarchyButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	private ConsoleEditor_HierarchyCase linkCase;

	private ConsoleEditor main;

	public void StartComponent(ConsoleEditor_HierarchyCase _linkCase, ConsoleEditor _main)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
