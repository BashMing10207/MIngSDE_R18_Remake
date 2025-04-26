using System;
using UnityEngine;

[Serializable]
public class Player_PersonIvent
{
	public Event_CreateResource.EventDay holiday;

	[Header("Голова")]
	public Mesh meshHead;

	public Material[] materialsHead;

	public Texture2D[] texturesHead;
}
