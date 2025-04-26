using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ConsoleEditor_ComponentCase_MethodCase : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	private ConsoleEditor_ComponentCase main;

	private MethodInfo method;

	private Component component;

	private float timeClick;

	private bool mouse;

	private bool canUse;

	[SerializeField]
	private Text textName;

	[SerializeField]
	private GameObject invokePlay;

	[SerializeField]
	private GameObject inputText;

	[SerializeField]
	private GameObject inputBoolean;

	private void Update()
	{
	}

	public void StartComponent(MethodInfo _method, Component _component, ConsoleEditor_ComponentCase _main)
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

	public void PlayInvoke(object[] _object)
	{
	}

	public void ButtonToggle()
	{
	}

	public void ButtonPlayInvoke()
	{
	}
}
