using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DialogueChange_Button : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	[SerializeField]
	private Image img;

	[SerializeField]
	private Text txt;

	[SerializeField]
	private Text txtKey;

	[SerializeField]
	private Shadow textShadow;

	[SerializeField]
	private Shadow textKeyShadow;

	[SerializeField]
	private Image imgFrameAlpha;

	[SerializeField]
	[Header("Иконка")]
	private Image imgFrameIcon;

	private Color colorFrameIconWas;

	private Color colorFrameIconNeed;

	[SerializeField]
	private Image imgAlphaCircle;

	private Color colorAlphaCircleWas;

	private Color colorAlphaCircleNeed;

	[SerializeField]
	private Image imgIcon;

	private Color colorImgIconWas;

	private Color colorImgIconNeed;

	[SerializeField]
	[Header("Звуки")]
	private AudioClip soundChange;

	[SerializeField]
	private AudioClip soundClick;

	private DialogueChanger dialogueChanger;

	private int indexButton;

	private bool click;

	private float timeAnimation;

	private bool destroyMe;

	private Color colorImgWas;

	private Color colorTxtWas;

	private Color colorImgFrameWas;

	private Color colorTxtShadowWas;

	private Color colorImgNeed;

	private Color colorTxtNeed;

	private Color colorImgFrameNeed;

	private Color colorTxtShadowNeed;

	private bool hide;

	private void Update()
	{
	}

	public void StartComponent(DialogueChanger _main, int _index, int _stringFile, Sprite _icon, string _keyText)
	{
	}

	public void KeyText(string _keyText)
	{
	}

	public void DestroyAlpha()
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

	private void LerpColorExit()
	{
	}

	private void OnDisable()
	{
	}

	private void LerpColor(Color _colorImgNeed, Color _colorTxtNeed, float _alphaFrame, float _alphaShadowText, Color _colorFrameIcon, Color _colorIcon, float _alphaCircleAlpha)
	{
	}

	private void LerpColorIgnoryHide(Color _colorImgNeed, Color _colorTxtNeed, float _alphaFrame, float _alphaShadowText, Color _colorFrameIcon, Color _colorIcon, float _alphaCircleAlpha)
	{
	}

	public void HideButton(bool x)
	{
	}

	public void Blink()
	{
	}
}
