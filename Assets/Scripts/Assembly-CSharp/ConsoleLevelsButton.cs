using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ConsoleLevelsButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	private int indexLevel;

	public Text textLevelName;

	public void StartComponent(int _indexLevel)
	{
	}

	public void Click()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
