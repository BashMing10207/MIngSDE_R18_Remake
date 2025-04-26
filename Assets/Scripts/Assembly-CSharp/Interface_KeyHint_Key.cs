using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interface_KeyHint_Key : MonoBehaviour
{
	[SerializeField]
	private Text textDescription;

	[SerializeField]
	private Text textKey;

	[SerializeField]
	private Image caseKey;

	[SerializeField]
	private Image frameAddon;

	[SerializeField]
	private RectTransform edgeFrame;

	[SerializeField]
	private RectTransform edgeFrameF;

	[Header("General")]
	[SerializeField]
	private string nameKey;

	[SerializeField]
	private string nameFile;

	public int indexString;

	public bool hide;

	private Transform cameraT;

	[Header("3D")]
	public bool button3D;

	public bool lookOnCamera;

	public float size;

	public float distanceHide;

	[Header("Control")]
	[Space(20f)]
	public bool keyDown;

	public bool destroyAfter;

	public bool downHide;

	public bool downBlind;

	public UnityEvent eventKeyDown;

	private PlayerMove scrpm;

	private float timeBlind;

	private Color colorImgKey1;

	private Color colorImgKey2;

	private Color colorImgFrame1;

	private Color colorImgFrame2;

	private bool destroyActive;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartComponent(string _nameKey, string _nameFile, int _stringIndex)
	{
	}

	public void Blind()
	{
	}

	public void SmoothDestroy()
	{
	}

	public void BlindAndDestroy()
	{
	}

	public void Hide(bool x)
	{
	}

	public void KeyDown()
	{
	}
}
