using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GamesCore_InputField : MonoBehaviour
{
	[SerializeField]
	private bool canInput;

	private UnityEvent eventRight;

	private UnityEvent eventUnright;

	private List<GameObject> buttonsClick;

	private List<GameObject> fieldCases;

	private int indexCharNow;

	private int indexButtonNow;

	private List<GamesCore_InputField_Char> fieldCharsNow;

	private string fieldCharsNeed;

	private float timeAnimationAlpha;

	private AnimationCurve animationAlpha;

	[Header("Префабы интерфейса")]
	[SerializeField]
	private RectTransform frameField;

	[SerializeField]
	private GameObject prefabButton;

	[SerializeField]
	private GameObject buttonEnter;

	[SerializeField]
	private GameObject buttonBackspace;

	[SerializeField]
	private RectTransform changerButton;

	[SerializeField]
	private GameObject prefabCaseChar;

	[SerializeField]
	private RectTransform changeChar;

	public void StartComponent(string _fieldChars)
	{
	}

	private void Update()
	{
	}

	public void InstantiateField(string _fieldChars)
	{
	}

	public void NeedField(string _fieldChars, UnityEvent _right, UnityEvent _unright)
	{
	}

	private List<GamesCore_InputField_Char> ConvertString(string _string)
	{
		return null;
	}

	private void ButtonEnter()
	{
	}

	private void ButtonBackspace()
	{
	}

	private void ButtonClick()
	{
	}

	private void UpdateChanger()
	{
	}

	public void CanInput(bool _x)
	{
	}
}
