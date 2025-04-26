using System;
using UnityEngine;

[Serializable]
public class Location7_HammerButton_Animations
{
	[Header("Мита")]
	public Time_Events mitaButtonDown;

	public Time_Events mitaButtonDownStop;

	public Time_Events mitaButtonTakeHammer;

	public Time_Events mitaButtonTakeHammerPlayerBed;

	public Time_Events mitaStartHold;

	[Header("Игрок")]
	public ObjectAnimationPlayer playerButtonDown;

	public ObjectAnimationPlayer playerButtonDownStop;

	public ObjectAnimationPlayer playerButtonTakeHammer;

	public ObjectAnimationPlayer playerButtonCancel;

	public ObjectAnimationPlayer playerStartHold;

	public ObjectAnimationPlayer playerKickMe;
}
