using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location1_InputNamePlayer : MonoBehaviour
{
	[SerializeField]
	private InputField inputName;

	[SerializeField]
	private List<string> badNames;

	[Header("События")]
	[Label("Всё правильно")]
	[SerializeField]
	private UnityEvent eventRight;

	[Label("Имя разработчика")]
	[SerializeField]
	private UnityEvent eventNameDevelopers;

	[Label("Плохое имя")]
	[SerializeField]
	private UnityEvent eventNameBad;

	[Label("Имя Миты")]
	[SerializeField]
	private UnityEvent eventNameMita;

	[Label("Имя с цифрами")]
	[SerializeField]
	private UnityEvent eventNameWithNumbers;

	private void Start()
	{
	}

	public void CheckName()
	{
	}
}
