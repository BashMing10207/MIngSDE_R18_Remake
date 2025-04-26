using UnityEngine;

public class MenuMita : MonoBehaviour
{
	public Animator mitaAnim;

	public Transform cameraT;

	public Transform headIk;

	public Transform eyesIk;

	public ButtonMouseMenu changeMenu;

	public AnimationCurve animationActive;

	private float weightActive;

	public MenuMitaDance mitaDance;

	public float intensityJumpHeadDance;

	public AnimationCurve headDance;

	public float timeDance;

	[Header("Настроение")]
	public bool badEmotion;

	private bool active;

	private bool lookOnCamera;

	private float speedLerpLook;

	private float lookEyesOnCamera;

	private float timeRandomlookOnCamera;

	private float timeBlnk;

	[HideInInspector]
	public bool alternative;

	private float timeStopLookOnCamera;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LookEyesOnCamera()
	{
	}

	public void StartActive()
	{
	}

	public void Alternative()
	{
	}

	public void FastStart()
	{
	}

	public void Activation(bool x)
	{
	}

	public void ActiveLookOnCamera(bool x)
	{
	}

	private void Blink()
	{
	}

	public void NeedBedEmotion(bool x)
	{
	}
}
