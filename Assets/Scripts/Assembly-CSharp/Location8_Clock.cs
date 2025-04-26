using System.Collections.Generic;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

public class Location8_Clock : MonoBehaviour
{
	private bool playerCanMoveClock;

	private bool playOtherClock;

	private bool playGame;

	private float timeClock;

	private float timeOtherClock;

	private bool win;

	private float timeWinAnimation;

	private float timeAnimationTimeMove;

	private List<float> otherTimesSound;

	[SerializeField]
	[Header("Часы")]
	private AudioSource audioClockMove;

	[SerializeField]
	private Transform clockSecond;

	[SerializeField]
	private Transform clockMinute;

	[SerializeField]
	private Transform clockHour;

	[SerializeField]
	private ObjectClock[] clocks;

	[SerializeField]
	private ObjectInteractive clockInteractive;

	[SerializeField]
	private AnimationCurve animationTimeMove;

	[SerializeField]
	private AnimationCurve animationWin;

	private PlayerPersonIK scrppik;

	private FullBodyBipedIK ikplayer;

	[Header("IK рук")]
	[SerializeField]
	private Animator animHandsClock;

	[SerializeField]
	private Transform targetHandRight;

	[Header("Прохождение")]
	[SerializeField]
	private UnityEvent eventStopTime;

	[SerializeField]
	private UnityEvent eventCheckWin;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayerCanMoveClock(bool _x)
	{
	}

	public void OtherClockMove(bool _x)
	{
	}

	public void CheckTime()
	{
	}

	public void DropClock()
	{
	}

	public void ContinueTime()
	{
	}
}
