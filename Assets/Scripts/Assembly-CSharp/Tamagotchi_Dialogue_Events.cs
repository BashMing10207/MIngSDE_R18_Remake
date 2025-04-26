using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Tamagotchi_Dialogue_Events
{
	public int indexString;

	public UnityEvent eventStart;

	[Header("Мита")]
	public AnimationClip animationPlay;

	public AnimationClip animationIdle;

	public string emotion;

	public bool bodyIKActive;
}
