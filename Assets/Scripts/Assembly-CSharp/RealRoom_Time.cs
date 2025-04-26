using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class RealRoom_Time : MonoBehaviour
{
	[SerializeField]
	private Text[] digitalTime;

	[SerializeField]
	private RealRoom_Time_Clock[] clockTime;

	[Range(0f, 23f)]
	[SerializeField]
	private int timeHour;

	[SerializeField]
	[Range(0f, 59f)]
	private int timeMinute;

	[SerializeField]
	[Range(0f, 59f)]
	private int timeSecond;

	[SerializeField]
	private TransformPositionsList[] things;

	[Header("Копировать")]
	[SerializeField]
	private Text[] otherTexts;

	private float timeUpdate;

	private void Update()
	{
	}

	public void SetTime()
	{
	}

	public void SetTimeSmartphone()
	{
	}

	public void SetTimeEveryDayMorning()
	{
	}

	public void SetTimeEveryDayFinishWork()
	{
	}

	public void SetTimeEveryDayAdd()
	{
	}

	[Button("Рандом вещей", EButtonEnableMode.Always)]
	public void ThingsRandom()
	{
	}
}
