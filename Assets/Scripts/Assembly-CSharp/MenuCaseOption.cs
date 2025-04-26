using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCaseOption : MonoBehaviour
{
	public enum TypeCaseOption
	{
		Volume = 0,
		PostProcessing = 1,
		ColorEffect = 2,
		AO = 3,
		VSync = 4,
		Antialiasing = 5,
		Resolution = 6,
		WindowMode = 7,
		Language = 8,
		SpeedMouse = 9,
		SpeedMouseLerp = 10,
		ModeSub = 11,
		Bright = 12,
		HeadMove = 13,
		HintScreen = 14,
		VoicePlayer = 15,
		Shadow = 16,
		Particles = 17,
		Bloom = 18,
		QualityWorld = 19,
		Loadgame = 20,
		FOV = 21,
		ExitGame = 22,
		LanguageVoice = 23,
		DoorHand = 24,
		ShadowStyle = 25,
		VoicePlayerX = 26,
		Continue = 27,
		Exit = 28,
		Slide = 29,
		Toggle = 30,
		Restart = 31,
		Censorship = 32,
		VolumeVoice = 33
	}

	[SerializeField]
	private TypeCaseOption option;

	[SerializeField]
	[Header("Addone")]
	private GameObject[] objectsAddone;

	[SerializeField]
	private GameObject locationChangeOption;

	[SerializeField]
	private List<Interface_ChangeScreenButton_Class_ButtonInfo> scrIccb;

	[SerializeField]
	private Sprite spriteAddon;

	[SerializeField]
	private Sprite spriteToggleY;

	[SerializeField]
	private Sprite spriteToggleN;

	[SerializeField]
	private float defaultSlide;

	[Header("Slider настройки")]
	[SerializeField]
	private float sliderMultiple;

	[SerializeField]
	private float inputSlide;

	[SerializeField]
	private Text textSlider;

	[SerializeField]
	private MenuCaseOption_SliderImage[] imagesSlider;

	private int intiResolution;

	private Resolution[] resolutions;

	private string[] languages;

	private int iLanguage;

	private float secondF;

	private int frames;

	private float timeStartSec;

	private int timeStart;

	private Slider slider;

	private bool sliderFloat;

	private float sliderInt;

	private GameObject toggleImg;

	private int toggleActive;

	private ButtonMouseClick scrbmc;

	private bool firstStart;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void Click()
	{
	}

	public void ChangeResoulution()
	{
	}

	public void ChangeLanguage()
	{
	}

	public void ChangeLanguageLoading()
	{
	}

	public void ChangeLanguageVoice()
	{
	}

	public void LanguageVoiceEnterCase()
	{
	}

	public void LanguageVoiceExitCase()
	{
	}

	public void LaguageVoiceExit()
	{
	}

	public void ResetDefault()
	{
	}

	public void MouseEnter()
	{
	}

	private void UpdateCase()
	{
	}

	public void EnterMouse()
	{
	}
}
