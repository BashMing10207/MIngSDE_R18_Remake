using UnityEngine;
using UnityEngine.UI;

public class MenuCaseOptionSwitch : MonoBehaviour
{
	public enum TypeCaseSwitch
	{
		toggle = 0,
		slider = 1,
		volume = 2
	}

	[SerializeField]
	private TypeCaseSwitch typeCase;

	[Header("Переключатель")]
	public bool toggle;

	[SerializeField]
	private Image toggleImage;

	[SerializeField]
	private Sprite toggleOn;

	[SerializeField]
	private Sprite toggleOff;

	[Header("Кол-во")]
	public int volumeNow;

	[SerializeField]
	private int volumeMin;

	[SerializeField]
	private int volumeMax;

	[SerializeField]
	private Text volumeText;

	[SerializeField]
	[Header("Слайдер")]
	private Slider slider;

	[SerializeField]
	private float sliderDefault;

	private void Start()
	{
	}

	public void SetToggle(bool x)
	{
	}

	public void Click()
	{
	}

	public void ClickDefault()
	{
	}
}
