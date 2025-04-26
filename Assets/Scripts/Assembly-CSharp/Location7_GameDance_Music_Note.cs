using System;
using UnityEngine;

[Serializable]
public class Location7_GameDance_Music_Note
{
	public float time;

	[HideInInspector]
	public bool noteUse;

	[Range(0f, 2f)]
	public int side;
}
