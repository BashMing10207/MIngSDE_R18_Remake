using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class DialogueChangerCase
{
	[HideInInspector]
	public GameObject button;

	public int stringFile;

	public UnityEvent eventClick;

	public Sprite iconButton;

	public bool closeClick;

	public bool oneTime;

	public bool exitButton;

	public bool isClose;

	[Header("Unity инфо")]
	public bool oneTimeUse;
}
