using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeLanguageStartButton : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler, IPointerDownHandler
{
	[SerializeField]
	private ChangeLanguageStart main;

	private int index;

	private int typeButton;

	private Image img;

	private Text text;

	[Header("Интерфейс")]
	[SerializeField]
	private Color colorEnter;

	[SerializeField]
	private Color colorExit;

	[SerializeField]
	private GameObject iconCommunity;

	private void Start()
	{
	}

	public void StartComponentLanguage(ChangeLanguageStart _main, string _text, int _index, bool _community)
	{
	}

	public void StartComponentVoice(ChangeLanguageStart _main, string _text, int _index, bool _community)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void ColorRechange(Color _colorEnter, Color _colorExit, bool _update)
	{
	}
}
