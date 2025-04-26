using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class MinigamesFastMenu_Case
{
	public RectTransform caseRect;

	public MenuCaseOption.TypeCaseOption typeCase;

	public UnityEvent eventClick;

	public bool isLock;
}
