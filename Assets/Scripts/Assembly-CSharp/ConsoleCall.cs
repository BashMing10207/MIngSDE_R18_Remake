using UnityEngine;
using UnityEngine.EventSystems;

public class ConsoleCall : MonoBehaviour
{
	[SerializeField]
	private bool liteVersion;

	private float timeCall;

	[Header("CONSOLE")]
	[SerializeField]
	private GameObject consoleObject;

	[SerializeField]
	private GameObject consoleObjectInformation;

	[SerializeField]
	private GameObject consoleObjectCameraInterface;

	private GameObject cosnoleCameraInterfaceNow;

	[SerializeField]
	private EventSystem eventSystem;

	[Header("Триггеры")]
	[SerializeField]
	private Material materialTriggerLine;

	[SerializeField]
	private Material materialTriggerPlane;

	private float timeHoldForFastTime;

	private GameObject cosnoleInfoNow;

	public static float timeSceneSecond;

	public static float timeSceneMinute;

	public static float timeSceneHours;

	private GameObject consoleObj;

	[HideInInspector]
	public GameObject cameraFlyObject;

	private GameObject cameraOrigin;

	private float timeExitGame;

	[HideInInspector]
	public ConsoleDrawTriggers triggersShow;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void CameraFly(bool _isConsole)
	{
	}

	public void CameraLight()
	{
	}

	public void ExitGameTime(float _time)
	{
	}

	public void ShowInformation()
	{
	}

	public void ShowTriggers()
	{
	}
}
