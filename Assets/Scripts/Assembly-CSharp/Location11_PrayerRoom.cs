using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location11_PrayerRoom : MonoBehaviour
{
	private List<Location11_PrayerRoom_Message> objectsMessages;

	private float timeNewMessage;

	[Header("Сообщения")]
	[SerializeField]
	private GameObject prefabMessage;

	private bool inputCan;

	private int indexInput;

	[SerializeField]
	[Header("Ввод сообщения")]
	private Text textInput;

	[SerializeField]
	private GameObject iconCandle;

	[SerializeField]
	private GameObject iconHeart;

	[SerializeField]
	private Interface_KeyHint_Key keyAnykey;

	[SerializeField]
	private UnityEvent eventApply;

	private bool canChangeDiscord;

	[SerializeField]
	[Header("Дискорд")]
	private RectTransform changeCase;

	[SerializeField]
	private UnityEvent eventChangeDiscord;

	[SerializeField]
	[Header("Звуки")]
	private Audio_Data audioKeyboard;

	[SerializeField]
	private AudioSource audioNewMessage;

	[SerializeField]
	private AudioSource audioChange;

	[SerializeField]
	private AudioSource audioClick;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void CreateNewMessage(bool _player)
	{
	}

	public void DeleteMessage(int _index)
	{
	}

	public void CanInput(bool x)
	{
	}

	public void CanChangeDiscord()
	{
	}

	[Button("Нажать на символ", EButtonEnableMode.Always)]
	private void InputKeyDown()
	{
	}

	private void OpenDiscord()
	{
	}

	private string NameRandom()
	{
		return null;
	}

	private string SymG()
	{
		return null;
	}

	private string SymGn()
	{
		return null;
	}
}
