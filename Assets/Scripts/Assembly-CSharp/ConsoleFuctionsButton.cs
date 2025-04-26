using UnityEngine;
using UnityEngine.EventSystems;

public class ConsoleFuctionsButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	private int indexCheat;

	private ConsoleInterface main;

	public void StartComponent(ConsoleInterface _main, int _indexCheat)
	{
	}

	public void Click()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
