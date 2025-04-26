using System;
using UnityEngine;

[Serializable]
public class DataAchievementsValues
{
	public string steamAchievement;

	public Sprite icon;

	public int lineTranslate;

	[HideInInspector]
	public bool get;
}
