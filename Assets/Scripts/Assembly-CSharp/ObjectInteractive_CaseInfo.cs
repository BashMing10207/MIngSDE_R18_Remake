using UnityEngine;
using UnityEngine.UI;

public class ObjectInteractive_CaseInfo : MonoBehaviour
{
	public int indexString;

	[Header("Предустановки префаба")]
	[SerializeField]
	private Image frameText;

	[SerializeField]
	private Text text;

	[SerializeField]
	private Image frameIcon;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image alpha;

	[SerializeField]
	private AnimationCurve animationText;

	public bool dontDestroyAfter;

	private ObjectInteractive interactiveMe;

	private bool active;

	private float interactiveTime;

	private bool destroySmooth;

	private Transform cameraT;

	private float timeColorBlind;

	private Color colorGradient1;

	private Color colorGradient2;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateFrameText()
	{
	}

	public void Activation(bool x)
	{
	}

	public void DestroySmooth()
	{
	}
}
