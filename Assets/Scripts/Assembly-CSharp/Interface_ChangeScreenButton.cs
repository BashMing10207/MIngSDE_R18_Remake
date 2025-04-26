using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interface_ChangeScreenButton : MonoBehaviour
{
	public enum TypeChangeScreenButton
	{
		ReturnString = 0,
		ReturnInt = 1
	}

	public GameObject buttonCancel;

	[HideInInspector]
	public UnityEvent eventReturn;

	[HideInInspector]
	public UnityEvent eventCaseEnter;

	[HideInInspector]
	public UnityEvent eventCaseExit;

	[HideInInspector]
	public UnityEvent eventExit;

	public List<Interface_ChangeScreenButton_Class_ButtonInfo> casesButton;

	public UI_Colors scriptColors;

	public GameObject buttonExample;

	public RectTransform changeNow;

	[SerializeField]
	private RectTransform changeBack;

	[SerializeField]
	private Text textAddon;

	[HideInInspector]
	public int indexChangeNow;

	private TypeChangeScreenButton typeChangeScreenButton;

	[HideInInspector]
	public string returnString;

	[HideInInspector]
	public int returnInt;

	public List<GameObject> buttonsNow;

	public void ClickTable(int index)
	{
	}

	public void EnterCase(int index)
	{
	}

	public void ExitCase(int index)
	{
	}

	public void Create(int _stringNumber, List<Interface_ChangeScreenButton_Class_ButtonInfo> buttonInfo, TypeChangeScreenButton typeReturn, GameObject returnLocation, GameObject returnButton, int indexChangeNow, Sprite _iconAddone)
	{
	}

	public void Close()
	{
	}
}
