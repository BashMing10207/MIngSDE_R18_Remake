using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleEditor_ComponentCase : MonoBehaviour
{
	public RectTransform pointerShow;

	public Text textName;

	public Text textAddon;

	[HideInInspector]
	public float size;

	[HideInInspector]
	public ConsoleEditor main;

	private Component component;

	private int index;

	[HideInInspector]
	public List<GameObject> methodCases;

	[HideInInspector]
	public List<GameObject> fieldCases;

	[SerializeField]
	[Header("Методы")]
	private GameObject methodCase;

	[SerializeField]
	private GameObject fieldCase;

	private int indexEnabled;

	public void StartComponent(ConsoleEditor _main, int _index, Component _component)
	{
	}

	public void ClickOpen()
	{
	}

	public void ClickEnable()
	{
	}

	public void ClickDelete()
	{
	}

	private void Update()
	{
	}

	private void UpdateTextProps()
	{
	}

	private void CreateMethods()
	{
	}

	private void DestroyMethods()
	{
	}

	private void CreateField()
	{
	}

	private void DestroyFields()
	{
	}
}
