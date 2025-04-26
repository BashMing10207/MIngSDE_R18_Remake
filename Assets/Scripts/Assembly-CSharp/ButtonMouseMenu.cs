using UnityEngine;
using UnityEngine.UI;

public class ButtonMouseMenu : MonoBehaviour
{
	public GameObject startCase;

	public bool keyMove;

	private bool sf;

	[Header("Звуки")]
	public AudioSource audioEnter;

	public AudioSource audioClick;

	public AudioSource audioToggle;

	private bool showHint;

	private float timeShowHint;

	[Header("Подсказка настроек")]
	public GameObject objectHalfScreen;

	public Image spriteImage;

	[Space(20f)]
	public GameObject caseChangeNow;

	[HideInInspector]
	public ButtonMouseClick buttonBack;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ChangeCase(GameObject _case)
	{
	}

	public void EnterButton()
	{
	}

	public void ClickButton()
	{
	}

	public void ClickButtonToggle()
	{
	}

	public void ActiveKeyMove(bool x)
	{
	}

	public void ButtonBack(GameObject _button)
	{
	}

	public void ButtonBackDeactive()
	{
	}

	private void IgnoryFirstSound()
	{
	}

	public void ImageShow(Sprite _sprite)
	{
	}

	public void ImageHide()
	{
	}
}
