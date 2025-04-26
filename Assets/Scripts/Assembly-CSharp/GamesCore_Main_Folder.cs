using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class GamesCore_Main_Folder
{
	public int nameFolder;

	public bool isBack;

	public bool needChange;

	public UnityEvent eventClick;

	public GamesCore_Main_Folder[] folders;

	[HideInInspector]
	public bool dontShow;
}
