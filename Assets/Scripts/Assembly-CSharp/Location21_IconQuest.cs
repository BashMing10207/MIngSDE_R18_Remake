using UnityEngine;
using UnityEngine.UI;

public class Location21_IconQuest : MonoBehaviour
{
	private bool showOtherIcon;

	private bool hide;

	private float animationHide;

	[SerializeField]
	[Header("Интерфейс")]
	private Image imageFrame;

	[SerializeField]
	private Image imageIcon;

	[SerializeField]
	private Sprite[] sprites;

	private Transform cameraT;

	[SerializeField]
	[Header("Объекты")]
	private Transform headMita;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void Hide(bool x)
	{
	}

	public void IconShow(Sprite _spriteIcon)
	{
	}

	public void IconQuest()
	{
	}

	private void UpdateAlpha()
	{
	}
}
