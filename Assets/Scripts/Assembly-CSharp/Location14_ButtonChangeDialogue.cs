using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Location14_ButtonChangeDialogue : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	[SerializeField]
	private Location14_GameQuestPlayer main;

	[SerializeField]
	private bool sideChange;

	[SerializeField]
	private Text text;

	private Image img;

	private bool mouse;

	private bool active;

	private void Update()
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

	public void Activation(string _text)
	{
	}

	public void Deactivation()
	{
	}
}
