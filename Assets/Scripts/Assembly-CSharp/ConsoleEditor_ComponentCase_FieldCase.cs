using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ConsoleEditor_ComponentCase_FieldCase : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Text textName;

	[SerializeField]
	private InputField inputField;

	[SerializeField]
	private GameObject toggle;

	private FieldInfo field;

	private Component component;

	private bool useNow;

	private int updateTik;

	public void StartComponent(FieldInfo _field, Component _component)
	{
	}

	private void Update()
	{
	}

	private void UpdateField()
	{
	}

	public void Apply()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void UseNow()
	{
	}

	public void ToggleClick()
	{
	}
}
