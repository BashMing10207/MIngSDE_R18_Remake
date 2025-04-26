using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InputKeyboard_Main : MonoBehaviour
{
	[SerializeField]
	private UnityEvent eventEnter;

	[SerializeField]
	private char[] charsEng;

	[SerializeField]
	private char[] charsRus;

	[SerializeField]
	private GameObject[] keys;

	[SerializeField]
	private InputField inpField;

	[SerializeField]
	private int maxCount;

	[SerializeField]
	private Image imgInput;

	[Header("Пароль")]
	[SerializeField]
	private bool needPassword;

	[SerializeField]
	private string password;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip[] soundsTaps;

	[SerializeField]
	private AudioSource audioSource;

	private char[] changeChars;

	private bool upper;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ButtonUpper()
	{
	}

	public void ButtonEnter()
	{
	}

	public void AddKey(string _key)
	{
	}

	public void RemoveKey()
	{
	}

	public void AudioPlayTap()
	{
	}

	public void ResetName()
	{
	}
}
